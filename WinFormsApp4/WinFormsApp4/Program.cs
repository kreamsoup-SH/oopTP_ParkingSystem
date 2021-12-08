//Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public class CarList
    {
        public string[] car_num;
        public string[] in_time;

        public CarList(int maxparking)
        {
            car_num = new string[maxparking];
            in_time = new string[maxparking];
            for (int i = 0; i < maxparking; i++)
            {
                car_num[i] = "";
                in_time[i] = "";
            }
        }
        public void AddCar(int position, string carnum, string intime)
        {
            car_num[position] = carnum;
            in_time[position] = intime;
        }
        public void SubCar(int index, int nowparking)
        {
            for(int i=index; i < nowparking-1; i++)
            {
                car_num[i] = car_num[i + 1];
                in_time[i] = in_time[i + 1];
            }
            car_num[nowparking-1] = "";
            in_time[nowparking-1] = "";
        }
        public bool IsThereSpace(int position)
        {
            if (position >= car_num.Length)
            { return false; }
            else return true;
        }
        public bool IsThereCar(string now_carnum, int now_parking)
        {
            bool flag = false;
            for (int i = 0; i <= now_parking; i++)
            {
                if (car_num[i] == now_carnum)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public int GetPosition(string now_carnum)
        {
            int position = -1;
            for (int i = 0; i <=car_num.Length; i++)
            {
                if (car_num[i] == now_carnum)
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
