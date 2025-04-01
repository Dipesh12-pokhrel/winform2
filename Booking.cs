using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm2.Model;
using WinForm2.Repositories;

namespace WinForm2
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = fName.Text.Trim();
            string lname = lName.Text.Trim();
            string address = add.Text.Trim();
            //int age =int.Parse(textBoxAge.Text);
            int age = string.IsNullOrWhiteSpace(this.age.Text) ? 0 : int.Parse(this.age.Text);
            bool driveValid = Valid.Checked;
            int rentedDays = (int)dayCount.Value;
            int selectedIndexCT = carType.SelectedIndex;
            int selectedIndexFT = fuelType.SelectedIndex;
            string typeofCar = carType.Text.Trim();
            string typeofFuel = fuelType.Text.Trim();
            bool unlimitedMileage = uM.Checked;
           bool breakdownCover = bC.Checked;
            if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(address)
            || (age <= 18 || age >= 60) || (rentedDays <= 0 || rentedDays >= 29)
            || selectedIndexCT < 0 || selectedIndexFT < 0)
            {
                MessageBox.Show("Kindly ensure that all mandatory * sections in the form are completed.!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                int totalCost = 0, basicCostPerDay = 25, uMcostPerDay = 10, bDcCostPerDay = 2;
                totalCost = basicCostPerDay * rentedDays;

                //Car type
                if (selectedIndexCT == 1)
                {
                    totalCost = totalCost + 50; //fpr family car
                }
                else if (selectedIndexCT == 2)
                {

                    totalCost = totalCost + 75; // for Sports car
                }
                else if (selectedIndexCT == 3)
                {
                    totalCost = totalCost + 65; // for SUV
                }

                //Fuel Type
                if (selectedIndexFT == 2)
                {
                    totalCost += 30; // for hybrid
                }
                else
                {
                    totalCost += 50; //for full electric
                }

                //unlimeted mileage
                if (unlimitedMileage)
                {
                    totalCost = totalCost + (uMcostPerDay * rentedDays);   
                }
                if (breakdownCover)
                { 
                    totalCost = totalCost + (bDcCostPerDay * rentedDays);
                }
                if (totalCost > 0)
                {
                    string message = $"Customer Details:\n" +
                    $"------------------------\n" +
                    $"Name:{fname + " " + lname}\n" +
                    $"Address: {address}\n" +
                    $"Age: {age}\n" +
                    $"Car Type: {carType}\n" +
                    $"Fuel Type: {fuelType}\n" +
                    $"Number of Days: {rentedDays}\n" +
                    $"Unlimited Mileage: {(unlimitedMileage ? "Yes" : "No")}\n" +
                    $"Breakdown Cover: {(breakdownCover ? "Yes" : "No")}\n" +
                    $"Total Cost: ${totalCost}";
                    //show details in MessageBix
                    MessageBox.Show(message, "Booking Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    ModelBooking mb = new ModelBooking();
                    //insert into booking
                    mb.FirstName = fname;
                    mb.LastName = lname;
                    mb.Address = address;
                    mb.Age = age;
                    mb.ValidLicense = driveValid;
                    mb.TotalBookingDays = rentedDays;
                    mb.CarType = typeofCar;
                    mb.FuelType = typeofFuel;
                    mb.UnlimitedMileage = unlimitedMileage;
                    mb.BreakdownCover = breakdownCover;
                    mb.TotalCost = totalCost;

                    var repo = new BookingRepo();
                    repo.CreateBooking(mb);
                    MessageBox.Show("Successfully store", "Booking Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Dashboard().Show();



                }
            }
        }
    

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
