using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    public class Plane
{
    public string Name_plane;
    public string Country_departure;
    public string Country_arrival;
    public int Flight_number;
    public int pepolnumber_of_seats;
    public int lux_seats;
    public bool eat;
    public int Getseats()
    {
        return pepolnumber_of_seats + lux_seats;
    }
    }
}
