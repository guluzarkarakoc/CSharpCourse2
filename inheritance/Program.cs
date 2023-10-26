Person[] persons = new Person[2];
{
    new Customer(FirstName = "Ali");, new Student(FirstName = "Salih");
        };
foreach (var person in persons)
{
    Console.WriteLine(person.FirstName);
}


class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
}
class Customer : Person
{
    public string City { get; set; }
}
class Student : Person
{

}class Person2
{

}