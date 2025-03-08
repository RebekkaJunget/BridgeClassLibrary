using BridgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbroen
{
    internal class OresundMC : Vehicle
    {
        public OresundMC(string licensePlate, DateTime date, bool broBizz = false) : base(licensePlate, date, broBizz)
        {
        }

        public override double Price()
        {
            return BroBizz ? 92 : 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
    
    
}
