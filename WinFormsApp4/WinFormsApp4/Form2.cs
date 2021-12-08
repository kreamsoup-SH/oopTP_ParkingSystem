//Form2.cs
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            Intime.Text = datetime.ToString("HH:mm:ss");

            string this_carnum = textBox1.Text;
            //<우선 만차인지 확인>//

            if (Form1.car_list.IsThereSpace(Form1.now_parking) == false) //자리가 없으면
            {
                MessageBox.Show("만차입니다.");
            }
            else //자리가 있으면
            {
                bool already_park = Form1.car_list.IsThereCar(this_carnum, Form1.now_parking);

                if (already_park == true)   //중복일경우
                {
                    MessageBox.Show("이미 입차한 차량입니다.", "오류");
                }
                else if (already_park == false) //새로운차량일경우 추가
                {
                    Form1.car_list.AddCar(Form1.now_parking, this_carnum, datetime.ToString("HH:mm:ss"));
                    MessageBox.Show("입차되었습니다.");
                    Form1.now_parking++;
                    this.Close();
                }
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label_time.Text = DateTime.Now.ToLongTimeString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}