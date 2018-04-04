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
    public partial class AddDestination : Form
    {
        public Destination destination { get; set; }
        public AddDestination()
        {
            InitializeComponent();
        }

        private void saveDest_Click(object sender, EventArgs e)
        {
            destination = new Destination();
            destination.Name = nameOfDest.Text;
            destination.Price =(int)priceDest.Value;
            destination.Distance = (int)distanceDest.Value;

            DialogResult = DialogResult.OK;
        }

        private void cancelAddingDest_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

        }
    }
}
