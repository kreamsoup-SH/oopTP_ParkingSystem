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
    public partial class Form4 : Form
    {
        int index;
        string intime;

        public Form4(int _index)
        {
            InitializeComponent();
            timer1.Start();
            index = _index;
            intime = Form1.car_list.in_time[index];

            label7.Text = Form1.car_list.in_time[index];    //화면에표시
        }

        private void button2_Click(object sender, EventArgs e)  //출차버튼누를때
        {

            DateTime datetime = DateTime.Now;
            out_time.Text = datetime.ToString("HH:mm:ss"); //출차시간 라벨에 표시

            
            //////////<시간계산>///////////////
            char sp = ':'; //분리할 문자 설정
            string[] spintime = intime.Split(sp); //분리된 문자 배열 저장
            int intime_h = Int32.Parse(spintime[0]); //intime_h 입차 시
            int intime_m = Int32.Parse(spintime[1]); //intime_m 입차 분

            string[] spouttime =out_time.Text.Split(sp);
            int outime_h = Int32.Parse(spouttime[0]); //outtime_h 입차 시
            int outime_m = Int32.Parse(spouttime[1]); //outtime_m 입차 분

            int intime_t = intime_h * 60 + intime_m;
            int outime_t = outime_h * 60 + outime_m;

            int ParkingTime = outime_t - intime_t;
            label6.Text = ParkingTime.ToString();
            
            //////////</시간계산>////////////
            
            int cost = ((ParkingTime / 30) + 1) * 2000;
            label4.Text = cost.ToString();
            MessageBox.Show("출차되었습니다.\n요금은" + cost.ToString() + "입니다.");

            //<출차>//
            Form1.car_list.SubCar(index, Form1.now_parking);
            Form1.now_parking--;
            //</출차>//
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)  //종료
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cur_time.Text = DateTime.Now.ToLongTimeString();
        }
    }
}