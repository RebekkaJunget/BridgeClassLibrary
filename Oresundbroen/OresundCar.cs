﻿using BridgeClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oresundbroen
{
    public class OresundCar : Vehicle
    {
        public OresundCar(string licensePlate, DateTime date, bool broBizz = false) : base(licensePlate, date, broBizz)
        {
        }

        public override double Price()
        {
            return BroBizz ? 178 : 460;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
