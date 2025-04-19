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
    public partial class Frm_Calculadora : Form
    {
        public Frm_Calculadora()
        {
            InitializeComponent();
        }

        /*
        private void btn_Saludar_Click(object sender, EventArgs e)
        {
            txt_Saludo.Text = "Hola mundo";
        }

        //limpia//
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Saludo.Text = "";
        }*/
        //AQUI HUBO UN CAMBIO//
        //AQUI HUBO 2 CAMBIO EN OTRA CUENTA PRA VERIFICAR QUE TODO FUNCIONA//

        private void txt_Saludo_TextChanged(object sender, EventArgs e)
        {

        }

        //METODO PARA HACER LA SUMA//
        private void btn_Suma_Click(object sender, EventArgs e)
        {


            try
            {
                double suma = 0;

                suma = Convert.ToDouble(txt_Numero1.Text) + Convert.ToDouble(txt_Numero2.Text);

                txt_Resultado.Text = suma.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ingrese un numero corazon de melon", "Errorcito numerico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            //SEGUNDO METODO PARA SUMA//
            /*
            double num1 = 0;
            double num2 = 0;
            double suma = 0;

            num1 = Convert.ToDouble(txt_Numero1.Text);
            num2 = Convert.ToDouble(txt_Numero2.Text);

            suma = num1 + num2;

            txt_Resultado.Text = suma.ToString();*/
        }

        private void btn_Dividir_Click(object sender, EventArgs e)
        {


            try
            {
                double Dividir = 0;

                Dividir = Convert.ToDouble(txt_Numero1.Text) / Convert.ToDouble(txt_Numero2.Text);

                txt_Resultado.Text = Dividir.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un numero corazon de melon", "Errorcito numerico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btn_Restar_Click(object sender, EventArgs e)
        {
            
            try
            {
                double Restar = 0;

                Restar = Convert.ToDouble(txt_Numero1.Text) - Convert.ToDouble(txt_Numero2.Text);

                txt_Resultado.Text = Restar.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un numero corazon de melon", "Errorcito numerico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btn_Multiplicar_Click(object sender, EventArgs e)
        {

            try
            {
                double Multiplicar = 0;

                Multiplicar = Convert.ToDouble(txt_Numero1.Text) * Convert.ToDouble(txt_Numero2.Text);

                txt_Resultado.Text = Multiplicar.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa un numero corazon de melon", "Errorcito numerico", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txt_Numero1.Text = string.Empty;
            txt_Numero2.Text = string.Empty;
            txt_Resultado.Text = string.Empty;
        }

        private void Frm_Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
