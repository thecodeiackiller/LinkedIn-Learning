using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Factory
    {
        public abstract class Car() { };

        public class Jeep : Car { };
        public class Ram : Car { };
        public class Suburu : Car { };
        public class Volkswagon : Car { };
    }
}
