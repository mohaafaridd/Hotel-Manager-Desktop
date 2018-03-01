using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    class Expenses
    {

        public static decimal SingleBed { get; private set; } = 10M; // 10$

        public static decimal DoubleBed { get; private set; } = 17.5M;

        public static decimal Meals     { get; private set; } = 5M;

        public static decimal Cleaning  { get; private set; } = 2.5M;

        public static decimal SwimmingPool  { get; private set; } = 10M;

        public static decimal PrivateBeach  { get; private set; } = 10M;

        public static decimal Bar  { get; private set; } = 10M;

        public static decimal Internet  { get; private set; } = 5M;

    }
}
