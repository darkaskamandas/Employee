using System;

internal struct Employees
{
    internal string firstName;
    internal string secondName;
    internal byte age;
    internal char gender;
    internal long IDNumber;
    internal uint UniqueEN;
}

class FirmEmployeesTest
{
    static void Main(string[] args)
    {
        uint numberOfEmployees = 3;
        Employees[] employees = new Employees[numberOfEmployees];

        employees[0].firstName = "Gosho";
        employees[0].secondName = "Patrona";
        employees[0].age = 23;
        employees[0].gender = 'm';
        employees[0].IDNumber = 222222;
        employees[0].UniqueEN = 27560001;

        employees[1].firstName = "Ferucho";
        employees[1].secondName = "Lashion";
        employees[1].age = 24;
        employees[1].gender = 'm';
        employees[1].IDNumber = 111111;
        employees[1].UniqueEN = 27560002;

        employees[2].firstName = "Tanq";
        employees[2].secondName = "Stoqnova";
        employees[2].age = 38;
        employees[2].gender = 'f';
        employees[2].IDNumber = 333333;
        employees[2].UniqueEN = 27560003;

        PrintEmployees(employees);
    }

    static void PrintEmployees(Employees[] employees)
    {
        Console.WriteLine("List of employees: \n");

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine("Name: {0} {1}", employees[i].firstName, employees[i].secondName);
            Console.WriteLine("Age: {0}", employees[i].age);
            Console.WriteLine("Gender: {0}",
                (employees[i].gender == 'm' ? "Male" : (employees[i].gender == 'f' ? "Female" : "unknown")));
            Console.WriteLine("ID Number: {0}", employees[i].IDNumber);
            Console.WriteLine("Unique employee number: {0}", employees[i].UniqueEN);

            Console.WriteLine();
        }
    }
}