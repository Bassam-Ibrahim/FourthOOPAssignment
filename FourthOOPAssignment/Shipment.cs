using System;
using System.Collections.Generic;
using System.Text;

namespace FourthOOPAssignment
{

    public abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;

         public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public abstract decimal EstimatedCost { get; }
        public abstract void PrintShipment();

        protected Shipment(string trackingCode, string description,
                           decimal weight, decimal deliveryFee,
                           DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public void UpdateWeight(decimal newWeight)
        {
            Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            Weight = newWeight + extraPackingWeight;
        }

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Base customs report.");
        }
    }
}
