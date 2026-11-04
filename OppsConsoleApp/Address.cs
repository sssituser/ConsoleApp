using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConsoleApp
{
    internal class Address
    {
        public string Street { get; set; }
        public string Area { get; set; }
        public string Pincode { get; set; }
        public string District { get; set; }
        public string State { get; set; }

        public override string ToString ()
        {
            return $"\nStreet\t\t: {Street}\nArea\t\t: {Area}\nPincode\t\t: {Pincode}\nDistrict\t: {District}\nState\t\t: {State}";
        }
    }
}
