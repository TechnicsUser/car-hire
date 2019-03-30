using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp {
    public partial class Form1 : Form {
        double NumberDays = 0;
        int SelectedIndex = 0;
        //  bool carSelected = true;
        DateTime[] mydt = new DateTime[20];
      
        public static List<DateTime> list = new List<DateTime>();
 
        public Form1() {
            InitializeComponent();
            monthCalendar1.SetDate(DateTime.Now);
       
            Business_Layer.Worker.readInVans( );
            Business_Layer.Worker.readInCars( );



            }

        private void label1_Click(object sender, EventArgs e) {

            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
          //  listBox1.Items.Clear();

            if(cbVehicleChooser.SelectedIndex == 0) {
                cbMake.Items.Clear();
                displayForCar();
                for(int i = 0; i < Business_Layer.Worker.listOfCars.Count; i++) {
                   if(cbMake.Items.Contains(Business_Layer.Worker.listOfCars[i].getMake()) != true)
                    cbMake.Items.Add(Business_Layer.Worker.listOfCars[i].getMake());

                    }
                }
            else {
                cbMake.Items.Clear();

                displayForVan();
                for(int i = 0; i < Business_Layer.Worker.listOfVans.Count; i++) {
                     if(cbMake.Items.Contains(Business_Layer.Worker.listOfVans[i].getMake()) != true)

                        cbMake.Items.Add(Business_Layer.Worker.listOfVans[i].getMake());

                    }
                //List<Van> makes =  Business_Layer.Worker.matchVanModels(Business_Layer.Worker.listOfVans, "VW");
                //for(int i = 0; i < makes.Count; i++) {
                //    cbMake.Items.Add(makes[i].getMake());
                //     }
                }

            }

        private void Form1_Load(object sender, EventArgs e) {

            }

        private void button1_Click(object sender, EventArgs e) {
           //  tbTotal.Text = mydt[0].ToString();
            //for(int i = 0; i < Business_Layer.Worker.listOfVans.Count; i++) {
            //    listBox1.Items.Add(Business_Layer.Worker.listOfVans[i].getModel());
            //    }
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

            if(cbVehicleChooser.SelectedIndex == 0) {

                SelectedIndex = 0;
            string text = listBox1.SelectedItem.ToString();
            //   if(selectedIndex == 0) {
            for(int i = 0; i < Business_Layer.Worker.listOfCars.Count; i++) {
                if(Business_Layer.Worker.listOfCars[i].getModel() == text) {
                    SelectedIndex = i;
                    }
                 }
           
            tbEngineSize.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getEngeineSize().ToString();
            tbDoors.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getNbOfDoors().ToString();
            tbSeats.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getNbOfSeats().ToString();
            tbFuel.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getFuelType();
            tbAuto.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getManual().ToString();
            tbBodyShape.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getBodyTypy().ToString();
            tbPrice.Text =   Business_Layer.Worker.listOfCars[SelectedIndex].getPrice().ToString();
            tbReg.Text = Business_Layer.Worker.listOfCars[SelectedIndex].getRegistration();
            monthCalendar1.BoldedDates = Business_Layer.Worker.listOfCars[SelectedIndex].getHiredDate().ToArray();

             }
            else {
                SelectedIndex = 0;
                string text = listBox1.SelectedItem.ToString();
                //   if(selectedIndex == 0) {
                for(int i = 0; i < Business_Layer.Worker.listOfVans.Count; i++) {
                    if(Business_Layer.Worker.listOfVans[i].getModel() == text) { // todo
                        SelectedIndex = i;
                        }
                    }

                tbEngineSize.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getEngeineSize().ToString();
                tbDoors.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getCargoSpace().ToString();
                tbSeats.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getSlideDoor().ToString();
                tbFuel.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getFuelType();
                tbAuto.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getManual().ToString();
                tbBodyShape.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getWheeleBase().ToString();
                tbPrice.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getPrice().ToString();
                tbReg.Text = Business_Layer.Worker.listOfVans[SelectedIndex].getRegistration();
                monthCalendar1.BoldedDates = Business_Layer.Worker.listOfVans[SelectedIndex].getHiredDate().ToArray();
                }

            }

        private void label1_Click_1(object sender, EventArgs e) {

            }
        public   void displayForVan( ) {
           List<Van> TheList = Business_Layer.Worker.listOfVans;
            lblShape.Text = "Wheele Base";
            lblDoors.Text = "Slide Door";
            lblSeats.Text = "Cargo Space";
            lblFuel.Text = "TailLift";
            }
        public   void displayForCar() {
            List<Car> TheList = Business_Layer.Worker.listOfCars;

            lblDoors.Text = "Doors";
            lblShape.Text = "Body shape";
            lblSeats.Text = "Seats";
            lblFuel.Text = "Fuel";



            }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e) {
            int selectedIndex = cbMake.SelectedIndex;
            if(cbVehicleChooser.SelectedIndex == 0 ) {
                List<Car> makes = Business_Layer.Worker.matchCarModels(Business_Layer.Worker.listOfCars, cbMake.Text);
                listBox1.Items.Clear();
                for(int i = 0; i < makes.Count; i++) {
                    listBox1.Items.Add(makes[i].getModel());
                    }
                }
            else {
                List<Van> makes = Business_Layer.Worker.matchVanModels(Business_Layer.Worker.listOfVans, cbMake.Text);
                listBox1.Items.Clear();
                for(int i = 0; i < makes.Count; i++) {
                    listBox1.Items.Add(makes[i].getModel());
                    }

                }
         
            //for(int i = 0; i < Business_Layer.Worker.listOfCars.Count; i++) {
            //    listBox1.Items.Add(Business_Layer.Worker.listOfCars[i].getModel());

            //    }

            }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
        
            //double NumberDays = (monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays;
            //tbTotal.Text = NumberDays.ToString();

            }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
              NumberDays = (monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays;
            tbTotal.Text = NumberDays.ToString();
  

            //DateTime[] absentDates = { myVacation1, myVacation2};
            //monthCalendar1.BoldedDates = absentDates;
            //   monthCalendar1.BoldedDates = Business_Layer.Worker.listOfDates.ToArray();

            }

        private void Quote(object sender, EventArgs e) {

            }

        private void button2_Click(object sender, EventArgs e) {
            tbQuote.Text = Business_Layer.Worker.calculateRental(double.Parse(tbPrice.Text), NumberDays).ToString();
            if(cbVehicleChooser.SelectedIndex == 0) {
                Business_Layer.Worker.listOfCars[SelectedIndex].setHiredDate(monthCalendar1.SelectionStart);
                Business_Layer.Worker.listOfCars[SelectedIndex].setHiredDate(monthCalendar1.SelectionEnd);
                }
            else {
                Business_Layer.Worker.listOfVans[SelectedIndex].setHiredDate(monthCalendar1.SelectionStart);
                Business_Layer.Worker.listOfVans[SelectedIndex].setHiredDate(monthCalendar1.SelectionEnd);
                }
            //  monthCalendar1.BoldedDates = Business_Layer.Worker.listOfDates.ToArray();
           // monthCalendar1.BoldedDates = Business_Layer.Worker.listOfVans[SelectedIndex].getHiredDate().ToArray();
            //Business_Layer.Worker.listOfCars[SelectedIndex].getDaysHired();
            //foreach(var item in Business_Layer.Worker.listOfDates) {
            //    listBox1.Items.Add(item);

            //    }
            }

        private void button3_Click(object sender, EventArgs e) {
            Business_Layer.Worker.writeOutVans(Business_Layer.Worker.listOfVans);
            Business_Layer.Worker.writeOutCars(Business_Layer.Worker.listOfCars);

            BookingForm b = new BookingForm();
            b.Show();
            }
        }
    }
