using FourthOOPAssignment;
using System;

class Program
{
    #region Theo Questions
    /*
     
Q1) Abstraction

a) Abstraction means hiding the complex details and showing only
   what the user really needs. It focuses on what the object does
   not how it does it. In C# we use abstract classes and interfaces.

b) It is one of the four pillars because:
   - It makes code simpler by hiding details.
   - It lets us write code that works with many types.
   - It defines a common shape that many classes can follow.
   - It helps us change the implementation later without
     breaking the rest of the program.


Q2) Abstract Class vs Interface

a) Differences:
   - Abstract class can have normal methods and fields, but a class
     can inherit from only one abstract class.
   - Interface has only method signatures (no fields), but a class
     can implement many interfaces.
   - Abstract class is used for "is a" relation.
   - Interface is used for "can do" relation.

b) I use an interface when:
   - I want many different classes to share the same ability.
   - I need to implement more than one type.
   - I only need a contract without any shared code.

c) A class cannot inherit from more than one abstract class.
   But it can implement many interfaces.
*/
     
     
    #endregion
    static void Main(string[] args)
    {
        DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Tahrir", 15);
        StandardShipment s1 = new StandardShipment(
            "SH001", "Laptop", 3, 80, addr1);

        DeliveryAddress addr2 = new DeliveryAddress("Giza", "Pyramids", 22);
        ExpressShipment s2 = new ExpressShipment(
            "SH002", "Mobile Phone", 2, 60, addr2, 30);

        DeliveryAddress addr3 = new DeliveryAddress("Alex", "Corniche", 5);
        InternationalShipment s3 = new InternationalShipment(
            "SH003", "Television", 8, 120, addr3, "Germany", 100);

        DeliveryCenter center = new DeliveryCenter("Cairo Center");
        center.AddShipment(s1);
        center.AddShipment(s2);
        center.AddShipment(s3);

        Console.WriteLine("Delivery Center");
        Console.WriteLine();
        center.PrintAllShipments();

        center.PrintTrackingStatuses();
        Console.WriteLine();

        Console.WriteLine("Insurance");
        DeliveryReport report = new DeliveryReport();
        report.PrintInsurance(s1);
        report.PrintInsurance(s2);
        report.PrintInsurance(s3);
        Console.WriteLine();

        ITrackable[] trackables = { s1, s2, s3 };
        foreach (ITrackable t in trackables)
            Console.WriteLine(t.GetTrackingStatus());
        Console.WriteLine();

        IInsurable[] insurables = { s1, s2, s3 };
        foreach (IInsurable i in insurables)
            Console.WriteLine($"{i.CalculateInsurance():F2} EGP");

        Console.WriteLine();
        Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
    }
}