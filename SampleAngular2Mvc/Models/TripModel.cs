﻿using Candor.Sample;

namespace SampleAngular2Mvc.Models
{
    /// <summary>
    /// Model returning a custom representation of a Trip for display purposes.
    /// This may add formatted properties ready for consumption by javascript,
    /// such as formatting date objects or enum values to a good display representation.
    /// </summary>
    public class TripModel : Trip
    {
        //public Location DepartureLocation { get; set; }
        //public Location ArrivalLocation { get; set; }
        //public Person Driver { get; set; }
    }
}