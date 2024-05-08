using ListaTelefonica;

bool CheckIfExists(string path, string file)
{
    if (!Directory.Exists(path))
    {
        Directory.CreateDirectory(path);
    }
    if (!File.Exists(path + file))
    {
        File.Create(path + file);
    }
    return true;
}

void SaveFile(List<Contact> list, string path, string file)
{
    if (CheckIfExists(path, file))
    {
        StreamWriter sWriter = new(path + file);

        foreach (var item in list)
        {
            sWriter.WriteLine(item.ToString());
        }
        sWriter.Close();
    }
}

List<Contact> LoadFile(string path, string file)
{
    List<Contact> contactList = new();
    if (CheckIfExists(path, file))
    {
        string[] contact;
        foreach (var item in File.ReadAllLines(path + file))
        {
            contact = item.Split(';');

            List<string> numbers = new();
            string[] numbersInContact = contact[1].Split("-");
            foreach (string number in numbersInContact)
            {
                numbers.Add(number);
            }
            
            Address address = new Address(contact[2], contact[3], contact[4], contact[5], contact[6], contact[7]);

            contactList.Add(new Contact(contact[0], numbers, address, contact[8]));
        }
    }
    return contactList;
}

void ShowAll(List<Contact> contactList)
{
    foreach (var item in contactList)
    {
        Console.WriteLine(item.ToString());
    }
}

List<string> CreatePhoneNumbers()
{
    List<string> numbers = new();
    int option;
    do
    {
        Console.WriteLine("Digite um número de telefone: ");
        numbers.Add(Console.ReadLine());

        Console.WriteLine("Deseja inserir mais um telefone?");
        Console.WriteLine("1 - sim | 2 - não");
        option = int.Parse(Console.ReadLine());
    } while (option != 1);
    return numbers;
}
Address CreateAddress()
{
	Console.Write("Estado: ");
	string state = Console.ReadLine();

	Console.Write("Cidade: ");
	string city = Console.ReadLine();

	Console.Write("Rua: ");
	string street = Console.ReadLine();

	Console.Write("Numero: ");
	string number = Console.ReadLine();

	Console.Write("Bairro: ");
	string neighborhood = Console.ReadLine();

	Console.Write("CEP: ");
	string CEP = Console.ReadLine();

    return new Address(city, street, state, number, neighborhood, CEP);
}
Contact CreateContact()
{
    Console.WriteLine(">>Informações do Contato<<");

    Console.Write("Nome: ");
    string name = Console.ReadLine().ToLower();

    Console.Write("Email: ");
    string email = Console.ReadLine().ToLower();

    Console.WriteLine(">Telefones<");
    List<string> PhoneNumbers = CreatePhoneNumbers();

    Console.WriteLine(">Endereço<");
    Address address = CreateAddress();

    return new Contact(name, PhoneNumbers, address, email);

}

string path = Environment.CurrentDirectory + @"\Arquivos\";
string file = "Contatos.txt";


List<Contact> contacts = LoadFile(path, file);

contacts.Add(CreateContact());

ShowAll(contacts);
SaveFile(contacts, path, file);

Console.WriteLine();
