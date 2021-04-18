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
    public partial class fPlane : Form
    {
        //додавання публічного поля, та зміна конструктора
        public Plane ThePlane;
        public fPlane(Plane t)
        {
            ThePlane = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ThePlane.Name_plane = tbNamePlane.Text.Trim();
            ThePlane.Country_departure = tbMistoVid.Text.Trim();
            ThePlane.Country_arrival = tbMistoPr.Text.Trim();
            ThePlane.Flight_number = int.Parse(tbNomPlane.Text.Trim());
            ThePlane.pepolnumber_of_seats = int.Parse(tbKilkMisKlasClasic.Text.Trim());
            ThePlane.lux_seats = int.Parse(tbKilkMisKlasLux.Text.Trim());
            ThePlane.eat = chbObid.Checked;
          
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    
    }
}
