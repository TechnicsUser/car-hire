using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Class_FileOperation : Vehicle
    {
        public override void printVehicleDetails() {
            throw new NotImplementedException();
            }

       // List<Van> listOfVans = new List<Van>();
        public static List<Van> ReadinVans(String FilePath) {
            List<Van> listOfVans = new List<Van>();
            String[] AllVanDetails = File.ReadAllLines(@"F:\PC\Dropbox\vans.txt");
            for(int i = 0; i < AllVanDetails.Length; i++) {
                Van tempVan = new Van();// create object

                String[] VanParameter = AllVanDetails[i].Split('|');
                tempVan.setRegistration(VanParameter[0]);

                tempVan.setMake(VanParameter[1]);
                tempVan.setModel(VanParameter[2]);
                tempVan.setDaysHired(int.Parse(VanParameter[3]));
                tempVan.setFuelType(VanParameter[4]);
                tempVan.setPrice(double.Parse(VanParameter[5]));
                tempVan.setEngeineSize(double.Parse(VanParameter[6]));
                tempVan.setCargoSpace(double.Parse(VanParameter[7]));
                tempVan.setWheeleBase(char.Parse(VanParameter[8]));
                tempVan.setSlideDoor(bool.Parse(VanParameter[9]));
                tempVan.setTailLift(bool.Parse(VanParameter[10]));
                //tempVan.setHiredDate(DateTime.Parse(VanParameter[11]));
                //tempVan.setHiredDate(DateTime.Parse(VanParameter[12]));
                //tempVan.setHiredDate(DateTime.Parse(VanParameter[13]));
                //   tempVan.setHiredDate(DateTime.Parse(VanParameter[14]));

                listOfVans.Add(tempVan);
                //for(int k = 11; k < AllVanDetails.Length; k++) {
                //   String[] VanParameter2 = AllVanDetails[i].Split('|');

                //    Business_Layer.Worker.listOfDates.Add(DateTime.Parse(VanParameter[11]));
                //Business_Layer.Worker.listOfDates.Add(DateTime.Parse(VanParameter[12]));
                //Business_Layer.Worker.listOfDates.Add(DateTime.Parse(VanParameter[13]));
                //Business_Layer.Worker.listOfDates.Add(DateTime.Parse(VanParameter[14]));




          



            }
            return listOfVans;

            }
        public static List<Car> ReadinCars(String FilePath)
        {
            List<Car> listOfCars = new List<Car>();
            String[] AllCarDetails = File.ReadAllLines(@"F:\PC\Dropbox\cars.txt");
         
            for (int i = 0; i < AllCarDetails.Length; i++)
            {
                Car tempCar = new Car();// create object

                String[]CarParameter=AllCarDetails[i].Split('|');
                tempCar.setRegistration(CarParameter[0]);

                tempCar.setMake(   CarParameter[1] );
                tempCar.setModel( CarParameter[2]);
                tempCar.setDaysHired (int.Parse(CarParameter[3]));
                tempCar.setFuelType ( CarParameter[4]);
                tempCar.setPrice (double.Parse(CarParameter[5]));
                tempCar.setEngeineSize   (double.Parse(CarParameter[6]));
                tempCar.setNbOfDoors   (int.Parse(CarParameter[7]));
                tempCar.setNbOfSeats   (int.Parse(CarParameter[8]));
                tempCar.bodyTypy =  CarParameter[9] ;
                //tempCar.setHiredDate(DateTime.Parse(CarParameter[10]));

                //tempCar.setHiredDate(DateTime.Parse(CarParameter[11]));
                //tempCar.setHiredDate(DateTime.Parse(CarParameter[12]));
                //tempCar.setHiredDate(DateTime.Parse(CarParameter[13]));
                listOfCars.Add(tempCar);




        }
            return listOfCars;

        }
        public static void WriteVansToFile(string filePath, List<Van> listOfVans) {// Create method to read from text file.

        //    try {

                //Pass the filepath and filename to the StreamWriter Constructor. 
                StreamWriter sw = new StreamWriter(filePath);// No need to create file C# does it for you. 
                string line;
                for(int i = 0; i < listOfVans.Count; i++) {

                line = "s";
                sw.Write(line + "|");

                line = listOfVans[i].getMake();
                    sw.Write(line + "|");

                    line = listOfVans[i].getModel();
                    sw.Write(line + "|");

                    line = listOfVans[i].getDaysHired().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getFuelType();
                    sw.Write(line + "|");

                    line = listOfVans[i].getPrice().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getEngeineSize().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getCargoSpace().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getWheeleBase().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getSlideDoor().ToString();
                    sw.Write(line + "|");

                    line = listOfVans[i].getTailLift().ToString();
                    sw.Write(line + "|");

                foreach(var item in listOfVans[i].getHiredDate()) {
                    sw.Write(item + "|");
                    }
              //  List<string> strList = listOfVans[i].getHiredDate().ToArray().ToString();
                //for(int j = 0; j < listOfDates.Count; j++) {
                //    //line = listOfDates[j].ToString();
                //    line = listOfVans[i].getHiredDate().ToArray().ToString();
                //    sw.Write(line + "|");

                  //  }


                sw.WriteLine(line);
                  //  sw.WriteLine("");

                    }// comma and true after file path allows for multiple entires of text.

                sw.Close();
            //    }
            //catch(Exception e) {
            //    Console.WriteLine("Exception: " + e.Message);
            //    }
            //finally {
            //    Console.WriteLine("Executing finally block.");
            //    }



            }
        public static void WriteCarsToFile(string filePath, List<Car> listOfCars  ) {// Create method to read from text file.

            //    try {

            //Pass the filepath and filename to the StreamWriter Constructor. 
            StreamWriter sw = new StreamWriter(filePath);// No need to create file C# does it for you. 
            string line;
            for(int i = 0; i < listOfCars.Count; i++) {

                line = listOfCars[i].getRegistration();
                sw.Write(line + "|");

                line = listOfCars[i].getMake();
                sw.Write(line + "|");

                line = listOfCars[i].getModel();
                sw.Write(line + "|");

                line = listOfCars[i].getDaysHired().ToString();
                sw.Write(line + "|");

                line = listOfCars[i].getFuelType();
                sw.Write(line + "|");

                line = listOfCars[i].getPrice().ToString();
                sw.Write(line + "|");

                line = listOfCars[i].getEngeineSize().ToString();
                sw.Write(line + "|");

                line = listOfCars[i].getNbOfDoors().ToString();
                sw.Write(line + "|");

                line = listOfCars[i].getNbOfDoors().ToString();
                sw.Write(line + "|");

                line = listOfCars[i].getBodyTypy().ToString();
                sw.Write(line + "|");

              

                foreach(var item in listOfCars[i].getHiredDate()) {
                    sw.Write(item + "|");
                    }

           
                //  List<string> strList = listOfVans[i].getHiredDate().ToArray().ToString();
                //for(int j = 0; j < listOfDates.Count; j++) {
                //    //line = listOfDates[j].ToString();
                //    line = listOfVans[i].getHiredDate().ToArray().ToString();
                //    sw.Write(line + "|");

                //  }


                sw.WriteLine(line);
                //  sw.WriteLine("");

                }// comma and true after file path allows for multiple entires of text.

            sw.Close();
            //    }
            //catch(Exception e) {
            //    Console.WriteLine("Exception: " + e.Message);
            //    }
            //finally {
            //    Console.WriteLine("Executing finally block.");
            //    }



            }


        }
    }
