using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp {

    abstract class Vehicle  {
        //public Vehicle() {

        //    }
        //public Vehicle(string make, string model, int daysHired, string fuelType, double price, int engeineSize, bool manual) {

        //    }
        private string make;
        public string model;
        public int daysHired;
        public string fuelType;
        public double price;
        public double engeineSize;
        public bool manual;
        public List<DateTime> lsHireDates = new List<DateTime>();
        public string registration;

      public void setRegistration(string s) { registration = s; }

        public void setHiredDate(DateTime d) { lsHireDates.Add(d); }
        public void setMake(string A) { make = A; }
        public void setModel(string mod) { model = mod; }
        public void setDaysHired(int days) { daysHired = days; }
        public void setFuelType(string fuel ) { fuelType = fuel; }
        public void setPrice(double p ) { price = p; }
        public void setEngeineSize(double e) { engeineSize = e; }
        public void setManual(bool e) { manual = e; }

        public string getRegistration() { return registration; }
        public List<DateTime> getHiredDate() { return lsHireDates; }
        public string getMake() { return make; }
        public string getModel() { return model; }
        public int getDaysHired() { return daysHired; }
        public string getFuelType() { return fuelType; }
        public double getPrice() { return price; }
        public double getEngeineSize() { return engeineSize; }
        public bool getManual() { return manual; }

        public abstract void printVehicleDetails();

            
        public void printMakeModel() {

            }
        }
    }
