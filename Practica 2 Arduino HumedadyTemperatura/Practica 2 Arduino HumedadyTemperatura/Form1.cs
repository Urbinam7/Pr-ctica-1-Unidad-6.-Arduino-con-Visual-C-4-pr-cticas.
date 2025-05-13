using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace Practica_2_Arduino_HumedadyTemperatura
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool puertoCerrado = false;

        public Form1()


        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.PortName = "COM5"; // Asegúrate que coincide con tu Arduino
            serialPort.BaudRate = 9600;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!puertoCerrado)
                conectar();
            else
                noConectado();
        }
        private void conectar()
        {
            try
            {
                serialPort.Open();
                puertoCerrado = true;
                button1.Text = "DESCONECTAR";
                button1.BackColor = Color.Blue;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message);
            }
        }

        private void noConectado()
        {
            try
            {
                serialPort.Close();
                puertoCerrado = false;
                button1.Text = "CONECTAR";
                button1.BackColor = Color.Blue;
                listBox1.Items.Clear();
                temperaturaLabel.Text = "TEMPERATURA °C";
                humedadLabel.Text = "HUMEDAD %";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al desconectar: " + ex.Message);
            }
        }

        // Evento de datos recibidos del puerto
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                this.Invoke(new MethodInvoker(delegate
                {
                    string[] values = data.Split('\t');
                    if (values.Length == 2)
                    {
                        humedadLabel.Text = values[0] ;
                        temperaturaLabel.Text = values[1] +"°C";
                        listBox1.Items.Add(values[1] + "°C  " + values[0]);
                    }
                }));
            }
            catch { /* Manejo silencioso en caso de error */ }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
