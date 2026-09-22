using System;
using System.Collections.Generic;
using System.Text;

namespace FourthOOPAssignment
{
    public interface ITrackable
    {
        string GetTrackingStatus();
    }

    public interface IInsurable/* وانا برفع الانترفيس ده مكنتش قولت اني رافع ده معاه */
    {
        decimal CalculateInsurance();
    }
}
