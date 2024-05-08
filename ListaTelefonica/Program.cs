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

            string[] stringAddress = contact[2].Split(";");
            Address address = new(stringAddress[0], stringAddress[1], stringAddress[2], stringAddress[3], stringAddress[4], stringAddress[5]);

            contactList.Add(new Contact(contact[0], numbers, address, contact[3]));
        }
    }
    return contactList;
}

string path = Environment.CurrentDirectory + @"\Arquivos\";
string file = "Contatos.txt";


List<Contact> contacts = LoadFile(path, file);
Console.WriteLine();

List<string> phones = new();
List<string> phones2 = new();

phones2.Add("1397813");
phones2.Add("9523536");


phones.Add("99832123");
phones.Add("99763284");

/*Contact con = new("Sandro", phones, new("Tocantins", "Rua dos Bobos", "São Paulo", "0", "Seilandia", "140023"), "Sandro@gmail.com");
Contact con2 = new("Carlin", phones2, new("Tocantins", "Av 02", "São Paulo", "423", "Jardim Pitaia", "140058"), "CarlinFuguete@gmail.com");
contacts.Add(con);
contacts.Add(con2);
//phoneList.PrintList();
Console.WriteLine(con.ToString());
Console.WriteLine(con2.ToString());*/



SaveFile(contacts, path, file);

Console.WriteLine();
