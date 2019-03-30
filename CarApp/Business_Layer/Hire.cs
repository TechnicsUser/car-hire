using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Business_Layer {
    class Hire : Vehicle {

        class customer {

            
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public DateTime[] datesRented { get; set; }
        public int daysRented { get; set; }
        public double hirePrice { get; set; }
            }

        public override void printVehicleDetails() {
            throw new NotImplementedException();
            }
        }
    }
