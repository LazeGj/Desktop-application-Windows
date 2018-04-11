using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picerija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void calculateTotal()
        {
            int price;
            if (smallPica.Checked)
            {
                Int32.TryParse(priceSmallPica.Text, out price);
            }
            else if (mediumPica.Checked)
            {
                Int32.TryParse(priceMediumlPica.Text, out price);
            }
            else
            {
                Int32.TryParse(priceLargePica.Text, out price);

            }

            int priceForAdd;
            if (checkBoxCheese.Checked)
            {
                if (Int32.TryParse(priceExtraCheese.Text, out priceForAdd))
                {
                    price += priceForAdd;
                    priceForAdd = 0;
                }

            }

            if (checkBoxFeferoni.Checked)
            {
                if (Int32.TryParse(priceFeferoni.Text, out priceForAdd))
                {
                    price += priceForAdd;
                    priceForAdd = 0;
                }

            }

            if (checkBoxKetchup.Checked)
            {
                if (Int32.TryParse(priceKetchup.Text, out priceForAdd))
                {
                    price += priceForAdd;
                    priceForAdd = 0;
                }

            }


            int q;
            int priceForDrink;
            if (Int32.TryParse(quantityBeer.Text, out q) && Int32.TryParse(priceBeer.Text, out priceForDrink))
            {
                price += q * priceForDrink;
            }

            if (Int32.TryParse(quantityCocaCola.Text, out q) && Int32.TryParse(priceCocaCola.Text, out priceForDrink))
            {
                price += q * priceForDrink;
            }

            if (Int32.TryParse(quantityJouce.Text, out q) && Int32.TryParse(priceJouce.Text, out priceForDrink))
            {
                price += q * priceForDrink;
            }

            if (DesertPrice.Text != "")
            {
                price += Convert.ToInt32(DesertPrice.Text);
            }

            Total.Text = price + "";
        }

        private void order_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (smallPica.Checked)
            {
                sb.Append(smallPica.Text + "\n");
            }
            else if (mediumPica.Checked)
            {
                sb.Append(mediumPica.Text + "\n");
            }
            else
                sb.Append(largePica.Text + "\n");

            if (checkBoxCheese.Checked)
                sb.Append(checkBoxCheese.Text + "\n");
            if (checkBoxFeferoni.Checked)
                sb.Append(checkBoxFeferoni.Text + "\n");
            if (checkBoxKetchup.Checked)
                sb.Append(checkBoxKetchup.Text+"\n");

            if(quantityBeer.Text!="0")
            {
                sb.Append(quantityBeer.Text + " " + "Пиво"+"\n");
            }

            if (quantityJouce.Text != "0")
            {
                sb.Append(quantityJouce.Text + " " + "Џус" + "\n");
            }
            if (quantityCocaCola.Text != "0")
            {
                sb.Append(quantityCocaCola.Text + " " + "Кока Кола/Фанта/Спрајт" + "\n");
            }

            if(DesertPrice.Text!="")
            {
                sb.Append(listBox1.SelectedItem.ToString()+ "\n");

            }

            MessageBox.Show(sb.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1)
            {
                String s = listBox1.SelectedItem as String;
                if (s == "Овошна пита")
                    DesertPrice.Text = 100 + "";
                else if(s== "Сладолед")
                    DesertPrice.Text = 50 + "";
                else
                    DesertPrice.Text = 80 + "";

                calculateTotal();                   
            }
        }

        private void smallPica_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void mediumPica_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void largePica_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
            
        }

        private void checkBoxFeferoni_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void checkBoxCheese_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void checkBoxKetchup_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void quantityCocaCola_TextChanged(object sender, EventArgs e)
        {
            if (quantityCocaCola.Text == "")
                return;
                calculateTotal();
           
            sumCocaCola.Text = Convert.ToInt32(quantityCocaCola.Text) * Convert.ToInt32(priceCocaCola.Text) + "";
        }

        private void quantityJouce_TextChanged(object sender, EventArgs e)
        {
            if (quantityJouce.Text == "")
                return;
            calculateTotal();
            sumJouce.Text = Convert.ToInt32(quantityJouce.Text) * Convert.ToInt32(priceJouce.Text) + "";
        }

        private void quantityBeer_TextChanged(object sender, EventArgs e)
        {
            if (quantityBeer.Text == "")
                return;
            calculateTotal();
            sumBeer.Text = Convert.ToInt32(quantityBeer.Text) * Convert.ToInt32(priceBeer.Text) + "";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сте сигурни", "Откажи ја нарачката", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void paid_TextChanged(object sender, EventArgs e)
        {
            if(paid.Text!="")
                toReturn.Text = Convert.ToInt32(paid.Text)-Convert.ToInt32(Total.Text)+"";
        }
    }
}
