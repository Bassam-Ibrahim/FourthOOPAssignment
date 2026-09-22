using System;
using System.Collections.Generic;
using System.Text;

namespace FourthOOPAssignment
{
    using System;

    public class DeliveryCenter
    {
        private Shipment[] shipments;
        private int count;

        public string CenterName { get; set; }
        public Driver Driver { get; set; }   

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[20];
            count = 0;
        }

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return shipments[index];
                return null;
            }
            set
            {
                if (index >= 0 && index < count)
                    shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                        return shipments[i];
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < count; i++)
            {
                if (shipments[i].TrackingCode == trackingCode)
                {
                    for (int j = i; j < count - 1; j++)
                        shipments[j] = shipments[j + 1];

                    shipments[count - 1] = null;
                    count--;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine($"Delivery Center : {CenterName}");
            Console.WriteLine();

            for (int i = 0; i < count; i++)
            {
                shipments[i].PrintShipment();
                Console.WriteLine();
            }
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("Tracking Status");

            for (int i = 0; i < count; i++)
            {
                if (shipments[i] is ITrackable t)
                    Console.WriteLine(t.GetTrackingStatus());
            }
        }
    }
}
