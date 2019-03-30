using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {
    class Car : Vehicle {
        private int nbOfDoors;
        public int nbOfSeats;
        public string bodyTypy;

        public void setNbOfDoors(int A) { nbOfDoors = A; }
        public void setNbOfSeats(int mod) { nbOfSeats = mod; }
        public void setBodyTypy(string body) { bodyTypy = body; }



        public int getNbOfDoors() { return nbOfDoors; }
        public int getNbOfSeats() { return nbOfSeats; }
        public string getBodyTypy() { return bodyTypy; }


        public override void printVehicleDetails() {

            }

        }
    }
