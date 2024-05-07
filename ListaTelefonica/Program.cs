using ListaTelefonica;

Phone p = new("321");
Phone p2 = new("123");
Phone p3 = new("7689");
PhoneList phoneList = new PhoneList();
phoneList.Add(p);
phoneList.Add(p2);
phoneList.Add(p3);


Console.WriteLine();

phoneList.Remove("123");

Contact con = new("Sandro", phoneList, new("Tocantins", "Rua dos Bobos", "São Paulo", "0", "Seilandia", "140023"), "Sandro@gmail.com");
Contact con2 = new("Carlin", phoneList, new("Tocantins", "Av 02", "São Paulo", "423", "Jardim Pitaia", "140058"), "CarlinFuguete@gmail.com");

//phoneList.PrintList();
con.PrintContact();
con2.PrintContact();
Console.WriteLine();
