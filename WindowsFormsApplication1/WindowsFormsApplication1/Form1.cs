using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Class1 Operacion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operacion = new Class1();
            string resultado;

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Ingrese valores", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Operacion.D1 = double.Parse(textBox1.Text);
                Operacion.D2 = double.Parse(textBox2.Text);

            }
            
            if (this.radioButton1.Checked == true)
            {
                resultado = Operacion.CalcularSuma().ToString();
                MessageBox.Show("El resultado es: "+resultado);
            }
            if (this.radioButton2.Checked == true)
            {
                resultado = Operacion.CalcularResta().ToString();
                MessageBox.Show("El resultado es: " + resultado);
            }
            if (this.radioButton3.Checked == true)
            {
                resultado = Operacion.CalcularMulti().ToString();
                MessageBox.Show("El resultado es: " + resultado);
            }
            if (this.radioButton4.Checked == true)
            {
                if (Operacion.D2 == 0)
                {
                    MessageBox.Show("No puedes dividir entre 0", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = Operacion.CalcularDiv().ToString();
                    MessageBox.Show("El resultado es: " + resultado);
                }
            }
            if ((this.radioButton1.Checked == false) && (this.radioButton2.Checked == false) && (this.radioButton3.Checked == false) && (this.radioButton4.Checked == false))
            {
                MessageBox.Show("Ninguna opcion seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }


        }
    }
}
