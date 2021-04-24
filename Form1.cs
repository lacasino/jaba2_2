using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jaba2_task2
{
    public partial class Form1 : Form
    {
        public delegate void deleg();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            deleg[] arrayOfdelegat = new deleg[3]
         {
                () => this.Opacity = 0.2,
                () => this.BackColor = Color.Blue,
                () => MessageBox.Show("Hello World")
         };



            if (checkBox1.Checked)
            {
                arrayOfdelegat[0]();


            }
            if (checkBox2.Checked)
            {
                arrayOfdelegat[1]();

            }
            if (checkBox3.Checked)
            {
                arrayOfdelegat[2]();

            }

        }
    }
}
