using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD19._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string encuesta_radio = "";
            string encuesta_check = "";
            int horas_pc;
            if (radioButton1.Checked)
            {
                encuesta_radio = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                encuesta_radio = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                encuesta_radio = radioButton3.Text;
            }

            if (checkBox1.Checked)
            {
                encuesta_check += checkBox1.Text + ", ";
            }

            if (checkBox2.Checked)
            {
                encuesta_check += checkBox2.Text + ", ";
            }

            if (checkBox3.Checked)
            {
                encuesta_check += checkBox3.Text + ", ";
            }

            horas_pc = trackBar1.Value;

            MessageBox.Show("El sistema operativo seleccionado es " + encuesta_radio + " su especialidad es " + encuesta_check + "y pasa " + horas_pc + " en el ordenador");
        }
    }
}
