using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Media;
using System.Windows.Forms;
namespace Practica_3_Sensor_de_nivel_de_agua
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private bool isBlinking;
        private SoundPlayer soundPlayer;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort("COM5", 9600);
            serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceiverHandler);
            BotonComenzar.Click += BotonComenzar_Click;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            soundPlayer = new SoundPlayer();//preguntar sobre la descarga de los audios
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }
        void DataReceiverHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine();
            this.Invoke(new Action(() =>
            {
                label1.Text = "Estado del sensor: " + (data.Trim() == "0" ? " Contenedor sin agua" : "Agua detectada");
                if (data.Trim() == "0")
                {
                    if (!isBlinking)
                    {
                        timer1.Start();
                        soundPlayer.PlayLooping();
                        pictureBox1.BackColor = System.Drawing.Color.Red;
                        isBlinking = true;
                    }
                }
                else
                {
                    if (isBlinking)
                    {
                        soundPlayer.Stop();
                        pictureBox1.BackColor = System.Drawing.Color.Green;
                    }
                }
            }));
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.BackColor = pictureBox1.BackColor == System.Drawing.Color.Green ?
                System.Drawing.Color.Yellow : System.Drawing.Color.Green;
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Application.Exit();
        }

        private void BotonComenzar_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
            }
        }
    }
}
