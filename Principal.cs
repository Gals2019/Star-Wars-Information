using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonajeNmspc;

namespace AppInfoStarWars
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            frmEspecies fe = new frmEspecies();
            fe.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
         
        }

        private void BtnMundos_Click(object sender, EventArgs e)
        {
            frmMundos fmundo = new frmMundos();
            fmundo.Show();
                
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmNaves fnave = new frmNaves();
            fnave.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            frmVehiculos fv = new frmVehiculos();
            fv.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            frmPeliculas fp = new frmPeliculas();
            fp.ShowDialog();
        }

        private void Button1_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
