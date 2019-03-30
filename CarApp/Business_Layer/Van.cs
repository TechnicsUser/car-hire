using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {
    class Van : Vehicle {
        public double cargoSpace;
        public char wheeleBase;
        public bool slideDoor;
        public bool tailLift;

        public void setCargoSpace(double A) { cargoSpace = A; }
        public void setWheeleBase(char mod) { wheeleBase = mod; }
        public void setSlideDoor(bool door) { slideDoor = door; }
        public void setTailLift(bool lift) { tailLift = lift; }




        public double getCargoSpace() { return cargoSpace; }
        public char getWheeleBase() { return wheeleBase; }
        public bool getSlideDoor() { return slideDoor; }
        public bool getTailLift() { return tailLift; }


        public override void printVehicleDetails() {

            }

        }
    }
