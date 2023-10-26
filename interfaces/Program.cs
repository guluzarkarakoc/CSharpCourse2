using interfaces;

PersonManager manager = new PersonManager();
manager.Add(new Customer { Id = 2, FirstName = "Salih",  });
Customer customer = new Customer();


Student student = new Student();

manager.Add(customer);
manager.Add(student);

CustomerManager customerManager = new CustomerManager();
customerManager.Add(new OracleCustomerrDal());

ICustomerDal[] customerDals = new ICustomerDal[2] { new SqlServerDal(), new OracleCustomerrDal(), };
foreach ( var customerDal in customerDals)
{
    customerDal.Add();
}


Console.ReadLine();


interface IPerson
{
    int Id { get; set; }
    string FirstName { get; set; }
    string LastName { get; set; }
}
class Customer : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Address { get; set; }
}
class Student : IPerson
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Department { get; set; }
}
//class PersonManager
//{
//    public void Add(Customer customer) 
//   {
//       Console.WriteLine(customer.FirstName);  }}
class PersonManager
{
    public void Add(IPerson person)
    {
        Console.WriteLine(person.FirstName);
    }
}
