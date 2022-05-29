using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_oyun_2

{
    public partial class SIAV : Form
    {
        bool x_sira;
        bool o_sira;
        public SIAV()
        {
            InitializeComponent();
        }
       
        private void btn_all(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if (x_sira)
            {
                x_sira = false;
                o_sira = true;
                B.Text = "X";
                B.Enabled = false;
            }
            else
            {
                x_sira = true;
                o_sira = false;
                B.Text = "O";
                B.Enabled = false;
            }
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X" ||
                button4.Text == "X" && button5.Text == "X" && button6.Text == "X" ||
                 button7.Text == "X" && button8.Text == "X" && button9.Text == "X" ||
                  button1.Text == "X" && button5.Text == "X" && button9.Text == "X" ||
                   button3.Text == "X" && button5.Text == "X" && button7.Text == "X" ||
                    button1.Text == "X" && button4.Text == "X" && button7.Text == "X" ||
                     button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label1.Text = "Tebrikler Qazanan X-dir:";
                
            }
            else
            {
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O" ||
               button4.Text == "O" && button5.Text == "O" && button6.Text == "O" ||
                button7.Text == "O" && button8.Text == "O" && button9.Text == "O" ||
                 button1.Text == "O" && button5.Text == "O" && button9.Text == "O" ||
                  button3.Text == "O" && button5.Text == "O" && button7.Text == "O" ||
                   button1.Text == "O" && button4.Text == "O" && button7.Text == "O" ||
                    button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    label1.Text = "Tebrikler Qazanan O-dur:";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x_sira = true;


        }

        private void button10_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
