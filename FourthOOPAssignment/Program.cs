using FourthOOPAssignment;
using System;

class Program
{
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