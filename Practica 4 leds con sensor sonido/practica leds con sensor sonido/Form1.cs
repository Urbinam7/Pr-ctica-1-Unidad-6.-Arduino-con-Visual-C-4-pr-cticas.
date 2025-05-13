using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace practica_leds_con_sensor_sonido
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        PictureBox[] leds;

        public Form1()
        {

            InitializeComponent();

            serialPort = new SerialPort("COM5", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            leds = new PictureBox[]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10,
                pictureBox11
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() => UpdateLEDs(data)));
        }

        private void UpdateLEDs(string data)
        {
            for (int i = 0; i < leds.Length; i++)
            {
                leds[i].BackColor = data[i] == '1' ? Color.Green : Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
