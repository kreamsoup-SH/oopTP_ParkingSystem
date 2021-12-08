//Form3.cs
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
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            string carnum = textBox1.Text;
            if (Form1.car_list.IsThereCar(carnum, Form1.now_parking)==false)
            {
                MessageBox.Show("차량이존재하지않음");
            }
            else //true
            {
                Form f4 = new Form4(Form1.car_list.GetPosition(carnum));
                f4.ShowDialog();
                this.Close();
            }
        }
    }
}
