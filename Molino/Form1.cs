using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace Molino
{
    public partial class Form1 : Form
    {
        int marcha=0, paro=0;
        private SerialPort arduinoPort;

        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            comboBoxPuerto.Items.AddRange(ports);

            estadoPanel.BackColor = Color.Red;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.BackColor = Color.FromArgb(77, 123, 137);

        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string data = arduinoPort.ReadLine();
            Invoke(new Action(() => ProcessData(data)));
        }

        private void ProcessData(string data)
        {
            // Parse the data received from Arduino
            string[] parts = data.Split(',');
            foreach (var part in parts)
            {
                string[] keyValue = part.Split(':');
                if (keyValue.Length == 2)
                {
                    string key = keyValue[0];
                    string value = keyValue[1];

                    switch (key)
                    {
                        case "C":
                            corriente.Text = $"Corriente: {value} A";
                            break;
                        case "R":
                            rpm.Text = $"RPM: {value}";
                            break;
                        case "T":
                            temperatura.Text = $"Temperatura: {value} C";
                            break;
                        case "N":
                            altura.Text = $"Altura: {value}";
                            break;
                        case "M":
                            marcha = Int32.Parse(value);
                            break;
                        case "P":
                            paro = Int32.Parse(value);
                            break;
                    }

                    if (paro == 1)
                    {
                        labelParo.Enabled = false;
                        labelParo.BackColor = Color.Red;
                        labelMarcha.Enabled = true;
                        deshabilitar();
                    }
                    else labelParo.BackColor = Color.Maroon;

                    if (marcha == 1)
                    {
                        labelMarcha.Enabled = false;
                        labelMarcha.BackColor = Color.Lime;
                        labelParo.Enabled = true; ;
                        habilitar();
                    }
                    else
                    {
                        Color nuevoColor = Color.FromArgb(0, 64, 0);
                        labelMarcha.BackColor = nuevoColor;
                    }
                }
            }

        }
        private void habilitar()
        {
            fino.Enabled = true;
            medio.Enabled = true;
            grueso.Enabled = true;
        }
        private void deshabilitar()
        {
            fino.Enabled = false;
            medio.Enabled = false;
            grueso.Enabled = false;

            pnl_fino.BackColor = Color.Transparent;
            pnl_medio.BackColor = Color.Transparent;
            pnl_grueso.BackColor = Color.Transparent;
        }
        private void SendCommand(string command)
        {
            if (arduinoPort.IsOpen)
            {
                arduinoPort.WriteLine(command);
            }
        }

        private void fino_Click_1(object sender, EventArgs e)
        {
            SendCommand("FINO");
            pnl_fino.BackColor = Color.Orange;
            pnl_medio.BackColor = Color.Transparent;
            pnl_grueso.BackColor = Color.Transparent;
        }

        private void medio_Click_1(object sender, EventArgs e)
        {
            SendCommand("MEDIO");
            pnl_fino.BackColor = Color.Transparent;
            pnl_medio.BackColor = Color.Orange;
            pnl_grueso.BackColor = Color.Transparent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoPort.IsOpen)
            {
                arduinoPort.Close();
            }

        }
        private void buttonDesconectar_Click(object sender, EventArgs e)
        {
            if (arduinoPort.IsOpen)      //Si el puerto esta habierto
            {
                arduinoPort.Close();      //Desconecta el Puerto
                buttonConectar.Enabled = true;
                estadoPanel.BackColor = Color.Red;
                Color nuevoColor = Color.FromArgb(0, 64, 0);
                labelMarcha.BackColor = nuevoColor;
                labelParo.BackColor = Color.Maroon;
                labelParo.Enabled = false;
                labelMarcha.Enabled = false;
                deshabilitar();
            }
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (comboBoxPuerto.SelectedItem != null)
            {
                string selectedPort = comboBoxPuerto.SelectedItem.ToString();

                try
                {
                    labelParo.Enabled = true;
                    labelMarcha.Enabled = true;
                    arduinoPort = new SerialPort(selectedPort, 9600); // Crear la instancia de SerialPort
                    arduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    arduinoPort.Open();
                    buttonConectar.Enabled = false;
                    // Estado de la conexion panel
                    estadoPanel.BackColor = Color.Green;
                    //Comunicación con Arduino a través de Arduino
                    // Por ejemplo, enviar datos a Arduino: Arduino.WriteLine("Hola, Arduino!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el puerto COM: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un puerto COM antes de conectar.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void labelMarcha_Click(object sender, EventArgs e)
        {
            SendCommand("MARCHA");
            marcha = 1;
            paro = 0;
            habilitar();
        }

        private void labelParo_Click(object sender, EventArgs e)
        {
            SendCommand("PARO");
            marcha = 0;
            paro = 1;
            deshabilitar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grueso_Click_1(object sender, EventArgs e)
        {
            SendCommand("GRUESO");
            pnl_fino.BackColor = Color.Transparent;
            pnl_medio.BackColor = Color.Transparent;
            pnl_grueso.BackColor = Color.Orange;
        }
    }
}
