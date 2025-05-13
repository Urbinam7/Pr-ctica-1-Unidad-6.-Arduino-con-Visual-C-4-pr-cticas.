using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Práctica_1_Comunicación_serial_Arduino
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        public Form1()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino = new SerialPort("COM5", 9600); // Asegúrate de que el puerto COM sea correcto
            Arduino.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arduino.Write("F"); // Enviar señal para apagar el LED
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("E"); // Enciende el LED
        }
    }
}
