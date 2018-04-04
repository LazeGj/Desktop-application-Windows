using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addAirport_Click(object sender, EventArgs e)
        {
            AddingAirport addingAirport = new AddingAirport();
            if(addingAirport.ShowDialog()==DialogResult.OK)
            {
                listAirports.Items.Add(addingAirport.aerodrom);
            }
            
        }

        private void addDestination_Click(object sender, EventArgs e)
        {
            AddDestination addDestination = new AddDestination();
            if(addDestination.ShowDialog()==DialogResult.OK)
            {
                
                Aerodrom a = (Aerodrom)listAirports.SelectedItem;
                a.Destinations.Add(addDestination.destination);
                listDest.Items.Add(addDestination.destination);
            }
           
        }

        private void deleteAirport_Click(object sender, EventArgs e)
        {
            AreYouSure areYouSure = new AreYouSure();
            if (areYouSure.ShowDialog() == DialogResult.OK)
            {
                listAirports.Items.Remove(listAirports.SelectedItem);
            }
        }

        private void listAirports_SelectedIndexChanged(object sender, EventArgs e)
        {
            listDest.Items.Clear();
           Aerodrom a= (Aerodrom)listAirports.SelectedItem;
            Destination max = new Destination();
            max.Distance = Int32.MinValue;
            float avg=0;
            foreach (var item in a.Destinations)
            {
                if (max.Distance < item.Distance)
                    max = item;
                avg += item.Distance;
                listDest.Items.Add(item);
            }
            if(max.Distance!=Int32.MinValue)
            longestDest.Text = max.ToString();
            averageDest.Text = avg / listDest.Items.Count + "";
        }
    }
}
