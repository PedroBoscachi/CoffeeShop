using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = button1.Height;
            homeScreen1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            homeScreen1.BringToFront();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
            orderScreen1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button3.Height;
            sidePanel.Top = button3.Top;
            deliveryScreen1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button4.Height;
            sidePanel.Top = button4.Top;
            localizationScreen1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
