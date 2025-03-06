using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul3_103022300106
{
    public partial class Form1 : Form
    {
        ArrayList angka = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (OutputLbl.Text.Length > 0)
            {
                int x = Int32.Parse(OutputLbl.Text);
                angka.Add(x);
                OutputLbl.Text = "";
            }   
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "1";
            }
            else
            {
                OutputLbl.Text += "1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "3";
            }
            else
            {
                OutputLbl.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
        
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "4";
            }
            else
            {
                OutputLbl.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
           
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "5";
            }
            else
            {
                OutputLbl.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "6";
            }
            else
            {
                OutputLbl.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "7";
            }
            else
            {
                OutputLbl.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "8";
            }
            else
            {
                OutputLbl.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "9";
            }
            else
            {
                OutputLbl.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           
            if (OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "0";
            }
            else
            {
                OutputLbl.Text += "0";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            angka.Add(OutputLbl.Text);
            int hasil = 0;
            foreach (var item in angka) {
                hasil += Convert.ToInt32(item);
            }
            OutputLbl.Text = "Output : " +  hasil.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
         
            if(OutputLbl.Text.Length == 0)
            {
                OutputLbl.Text = "2";
            }else
            {
                OutputLbl.Text += "2";
            }
        }
    }
}
