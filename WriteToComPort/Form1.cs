using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System; 
using System.IO.Ports; 
using System.Text;
using System.Diagnostics; 

namespace WriteToComPort
{
    public partial class Form1 : Form
    {

        String standardPortName = "COM16";
        int standardBaudRate = 9600;

        SerialPort _serialPort;

        public Form1()
        {
            InitializeComponent();
            button4.Enabled = false;
            button1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            _serialPort = new SerialPort(standardPortName, standardBaudRate, Parity.None, 8, StopBits.One);       
            _serialPort.Handshake = Handshake.None;
        }

        private void button_TurnMotor_Click(object sender, EventArgs e)
        {
            String angle = textBox_motorAngle.Text;

            if (angle.Length > 0) rotateMotor(angle);
        }

        private void button_OpenPort_Click(object sender, System.EventArgs e)
        {
            _serialPort.PortName = textBox_PortName.Text;
            _serialPort.Open();
            button3.Enabled = false;
            button4.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            if ((_serialPort.IsOpen)) button1.Enabled = true;
        }

        private void button_ClosePort_Click(object sender, System.EventArgs e)
        {
            _serialPort.Close();
            button3.Enabled = true;
            button4.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void button_TurnRight_Click(object sender, System.EventArgs e)
        {
            rotateMotor("30");
        }

        private void rotateMotor(String motorAngle)
        {
            try
            {
                if ((_serialPort.IsOpen))
                {                  
                        Debug.Write("Write to port" + "\n");
                        _serialPort.Write("1;30;" + motorAngle + ";\n");
                }
                else Debug.Write("Not open" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void button_TurnLeft_Click(object sender, System.EventArgs e)
        {
            rotateMotor("650");
        }

        private void button_TurnMiddle_Click(object sender, System.EventArgs e)
        {
            rotateMotor("330");
        }

    }
}
