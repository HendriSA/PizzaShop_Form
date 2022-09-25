using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;

namespace HendricksonSamuel_PizzaForm
{
    public partial class Form1 : Form
    {
        public Form1()//Default built-in constructor must be BEFORE other methods!
        {
            InitializeComponent(); //Leave this alone!
        }
        private const double BASE_PRICE = 12.00; //Base price of pizza
        private const double TOPPING_PRICE = 1.25; //Price per topping
        private double price = BASE_PRICE; //default price of a standard pizza
        private const double DELIV_FEE = 3.00;
        private const double DINE_IN_FEE = 2.00;

        private void chkbxOnions_CheckedChanged(object sender, EventArgs e) //Never change header
        {
            if (chkbxOnions.Checked)
            {
                price += TOPPING_PRICE;
                lstBxToppingsHolder.Items.Add(chkbxOnions.Text);
            }
            else
            {
                price -= TOPPING_PRICE;
                lstBxToppingsHolder.Items.Remove(chkbxOnions.Text);
            }
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void chkbxPep_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPep.Checked)
            {
                price += TOPPING_PRICE;
                lstBxToppingsHolder.Items.Add(chkbxPep.Text);
            }
            else
            {
                price -= TOPPING_PRICE;
                lstBxToppingsHolder.Items.Remove(chkbxPep.Text);
            }
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void chkbxPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPeppers.Checked)
            {
                price += TOPPING_PRICE;
                lstBxToppingsHolder.Items.Add(chkbxPeppers.Text);
            }
            else
            {
                price -= TOPPING_PRICE;
                lstBxToppingsHolder.Items.Remove(chkbxPeppers.Text);
            }
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void chkbxSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxSausage.Checked)
            {
                price += TOPPING_PRICE;
                lstBxToppingsHolder.Items.Add(chkbxSausage.Text);
            }
            else
            {
                price -= TOPPING_PRICE;
                lstBxToppingsHolder.Items.Remove(chkbxSausage.Text);
            }
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void rbtnPickUp_CheckedChanged(object sender, EventArgs e)//Do not add delivery fee if pickup
        {
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void rbtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDelivery.Checked)
                price += DELIV_FEE;
            else
                price -= DELIV_FEE;
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void rbtnDineIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDineIn.Checked)
                price += DINE_IN_FEE;
            else
                price -= DINE_IN_FEE;
            lblOutput.Text = "Total is " + price.ToString("C");
        }

        private void button1_Click(object sender, EventArgs e) //Write
        {
            lstBxToppingsVisible.Items.Clear();

            //A file stream is a special obj that holds the datta to be sent out or into the program
            // you must instantiate an inst of it like any other obj
            // The stuff in Paranthesis () are the data for the feilds in the File Stream obj
            //name of file that is created and written to
            FileStream file = new FileStream("Toppings.txt", FileMode.Create, FileAccess.Write);

            //This is the obj that does the writing or reading of data. 
            //It controls the flow one byte at a time in a stream
            StreamWriter writer = new StreamWriter(file);

            lstBxToppingsVisible.Items.Add("Text file has been created:");
            lstBxToppingsVisible.Items.Add(file.Name);
            lstBxToppingsVisible.Items.Add("    ");
            lstBxToppingsVisible.Items.Add("Press Read button to view contents.");

            //string of names
            string[] toppings = new string [4];
            int x;

            for (x = 0; x < lstBxToppingsHolder.Items.Count; ++x)
            {
                toppings[x] = lstBxToppingsHolder.Items[x].ToString();
            }

            
            //for loop to write out array to txt file, note we still use WriteLine
            for (x = 0; x < toppings.Length; ++x)
            {
                writer.WriteLine(toppings[x]); //callin the writer write the array to the file
                //writesout to the file instead
            }
            //These are a must: always in order
            //First close Writer
            //Second close File
            writer.Close();
            file.Close();

        }

        private void button2_Click(object sender, EventArgs e)//Read
        {
            lstBxToppingsVisible.Items.Clear();
            lstBxToppingsVisible.ForeColor = Color.Black;
            //could add path using @C:... instead of just name of file
            FileStream file = new FileStream("Toppings.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            

            string topping;//variable to hold ALL the names from the reader

            topping = reader.ReadLine(); //reader reads a line from the file

            while (topping != null) //Needs to not be null in order to designate end of file (end of file marker)
            {
                lstBxToppingsVisible.Items.Add(topping);
                topping = reader.ReadLine(); //reads next line from file
                
            }
            reader.Close();
            file.Close();
        }
    }
}
