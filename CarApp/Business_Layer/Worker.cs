using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Business_Layer {
    class Worker : Vehicle {

        public static double calculateRental(double rate, double days) {

            double dDays = Math.Ceiling( days) ;
            int intDays = (int)dDays;
            double total = rate * intDays;
            return total;

            }

        public override void printVehicleDetails() {
            throw new NotImplementedException();
            }
        public static List<DateTime> listOfDates = new List<DateTime>();

        public static List<Van> listOfVans = new List<Van>();
        public static void readInVans( ) {
            listOfVans = Class_FileOperation.ReadinVans(@"C:\Users\SwDev07\Desktop\vans.txt");
            }
        public static void writeOutVans(List<Van> listOfVans) {
            Class_FileOperation.WriteVansToFile(@"C:\Users\SwDev07\Desktop\vans.txt",   listOfVans);
                }


        public static List<Car> listOfCars = new List<Car>();
        public static void readInCars( ) {
            listOfCars = Class_FileOperation.ReadinCars(@"C:\Users\SwDev07\Desktop\cars.txt");
            }
        public static void writeOutCars(List<Car> listOfCars) {
            Class_FileOperation.WriteCarsToFile(@"C:\Users\SwDev07\Desktop\cars.txt", listOfCars);
            }
        public static List<Van> matchVanModels(List<Van> models, string match) {
            List<Van> lsOfVanType = new List<Van>();
            for(int i = 0; i < models.Count; i++) {
                if(models[i].getMake() == match) {
                    lsOfVanType.Add(models[i]);
                    }
                }
                return lsOfVanType;
            }
        public static List<Car> matchCarModels(List<Car> models, string match) {
            List<Car> lsOfCarType = new List<Car>();
            for(int i = 0; i < models.Count; i++) {
                if(models[i].getMake() == match) {
                    lsOfCarType.Add(models[i]);
                    }
                }
            return lsOfCarType;
            }


        }
    }