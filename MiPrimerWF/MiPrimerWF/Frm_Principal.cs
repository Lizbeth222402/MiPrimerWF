using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerWF
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Frm_Calculadora AbrirVentanaCalculadora = new Frm_Calculadora();
            AbrirVentanaCalculadora.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Proveedores AbrirVentanaProveedores = new Frm_Proveedores();
            AbrirVentanaProveedores.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Productos AbrirVentanaProveedores = new Frm_Productos();
            AbrirVentanaProveedores.ShowDialog();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inventario AbrirVentanaInventario = new Frm_Inventario();
            AbrirVentanaInventario.ShowDialog();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
