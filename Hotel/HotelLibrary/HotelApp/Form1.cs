using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelLibrary;
namespace HotelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreHotel obj = new CoreHotel();
            label1.Text = obj.getHotel(textBox1.Text);
            label2.Text = obj.getRoomType(textBox1.Text);
            label3.Text = obj.getPrice(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CoreHotel obj = new CoreHotel();
            label10.Text = obj.getAllotment(textBox1.Text, textBox2.Text);
        }
    }
}
