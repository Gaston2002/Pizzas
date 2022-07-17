using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploclase
{
    public partial class Pizzas : Form
    {
        public Pizzas()
        {
            InitializeComponent();
        }

       
        private void btCalcula_Click(object sender, EventArgs e)
        {
            int total = 0;
            int cantidad;    

            if (radioButton1.Checked ==  true)
            {
                total = + 500; //familiar
            }

            if (radioButton2.Checked == true)
            {
                total = + 450; //grande
            }

            if (radioButton3.Checked == true)
            {
                total = + 300; //mediana
            }

            if (radioButton4.Checked == true)
            {
                total = + 250; //chica
            }

            //ingredientes 
            //pizza + sus extras

            if (checkBox1.Checked == true)
            {
                total = total + 70;
                
            }

            if (checkBox2.Checked == true)
            {
                total = total + 100;
            }

            if (checkBox3.Checked == true)
            {
                total = total + 120;
            }

            if (checkBox4.Checked == true)
            {
                total = total + 190;
            }


            cantidad = Convert.ToInt32(nmrCantidad.Value); //preguntar por el Value.
            total = Convert.ToInt32(total) * cantidad;
            lblTotal1.Text= Convert.ToString(total);



            

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            lblTotal1.Text = "$";
            nmrCantidad.Value = 1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;


        }


    }
}
