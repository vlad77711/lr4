using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?", "Припинити роботу", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnAddPlane_Click_1(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            fPlane fp = new fPlane(plane);
            if (fp.ShowDialog() == DialogResult.OK)
            {
                tbPlaineInfo.Text += string.Format(" Назва літака {0},\r\n Місто відправлення {1},\r\n Місто прибуття {2}.\r\n Номер рейсу {3}.\r\n Кількість місць класу Clasic: {4}.\r\n Кількість місць класу Lux : {5}.\r\n {6}\r\n Вся Кількість місць: {7} \r\n ___________________________________________\r\n",
                plane.Name_plane, plane.Country_departure, plane.Country_arrival,
                plane.Flight_number, plane.pepolnumber_of_seats, plane.lux_seats,
                plane.eat ? "Є Обід" : "Немає Обіду",
                plane.Getseats());

            }
        }
    }
}
