//From1.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        static public int max_parking = 5;
        static public int now_parking = 0;
        static public CarList car_list;

        public Form1()
        {
            InitializeComponent();
            car_list = new CarList(max_parking);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }
    }
}