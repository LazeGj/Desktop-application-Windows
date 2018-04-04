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
    public partial class AddingAirport : Form
    {
        public Aerodrom aerodrom { get; set; }
        public AddingAirport()
        {
            InitializeComponent();
        }

        private void saveAirport_Click(object sender, EventArgs e)
        {
            aerodrom = new Aerodrom();
            aerodrom.City = cityOfAirport.Text;
            aerodrom.Name = nameOfAirport.Text;
            aerodrom.ShortName = shortNameOfAirport.Text;

            DialogResult = DialogResult.OK;
            
        }

        private void cancelAddinAirport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void nameOfAirport_Validating(Object sender, CancelEventArgs e)
        {
            if(nameOfAirport.Text=="")
            {
                nameOfAirportErrorP.SetError(nameOfAirport,"Внесете име на аеродромот");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void cityOfAirport_Validating(object sender, CancelEventArgs e)
        {
            if(cityOfAirport.Text=="")
            {
                nameOfAirportErrorP.SetError(cityOfAirport, "Внесете име на аеродром");
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
            }
        }

        private void shortNameOfAirport_Validating(object sender, CancelEventArgs e)
        {
            if (shortNameOfAirport.Text.Length!=3)
            {
                nameOfAirportErrorP.SetError(shortNameOfAirport, "Кратенката на аеродромот треба да биде 3 букви");
                e.Cancel = true;

            }
            else
            {
                e.Cancel = false;
            }
        }

    }
}
