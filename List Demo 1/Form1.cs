using System;
using System.Windows.Forms;

namespace List_Demo_1 {
    public partial class Time_Zones : Form {

        public Time_Zones() { InitializeComponent(); }

        private void lblCities_SelectedIndexChanged(object sender, EventArgs e) {
            string city;
            city = lbxCities.SelectedItem.ToString();
            switch (city) {
                case "San Francisco":
                    lblTimeZone.Text = "1:00 PM";
                    break;
                case "New York City":
                    case "Dover":
                    case "Pittsburgh":
                    lblTimeZone.Text = "2:00 PM";
                    break;
                case "Paris":
                    lblTimeZone.Text = "3:00 PM";
                    break;
                case "Hyrule":
                    lblTimeZone.Text = "4:00 PM";
                    break;
                case "Jimmy Johns City":
                    lblTimeZone.Text = "5:00 PM";
                    break;
                case "Hankville":
                    lblTimeZone.Text = "6:00 PM";
                    break;
                case "North Korea":
                    lblTimeZone.Text = "7:00 PM";
                    break;
                case "Obamanation":
                    lblTimeZone.Text = "8:00 PM";
                    break;
                default:
                    MessageBox.Show("City Not Found" , "Error");
                    break;
            }
        }
        private void lblTimeZone_Click(object sender, EventArgs e) { }
    } 
}