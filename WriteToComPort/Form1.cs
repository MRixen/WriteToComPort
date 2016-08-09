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

        String standardPortName = "COM5";
        int standardBaudRate = 9600;
        bool isRunning = true;

    byte[] position, ids, msgStart, msgEnd, speed;
        byte[] sendData = new byte[64];
        int[] readData = new int[64];
        #region position- and speed-list
        int[] positionList0 = {311,
342,
373,
403,
432,
460,
486,
511,
533,
554,
572,
587,
600,
610,
617,
620,
621,
619,
613,
605,
593,
579,
562,
542,
520,
497,
471,
443,
415,
385,
355,
324,
293,
262,
232,
202,
174,
146,
121,
97,
76,
57,
40,
27,
16,
7,
2,
1,
2,
6,
13,
24,
37,
53,
71,
92,
115,
140,
167,
195,
224,
254,
285,
311};

        int[] speedList0 = {63,
128,
192,
256,
320,
384,
448,
512,
576,
640,
704,
768,
832,
896,
960,
1023,
1023,
960,
896,
832,
768,
704,
640,
576,
512,
448,
384,
320,
256,
192,
128,
64,
64,
128,
192,
256,
320,
384,
448,
512,
576,
640,
704,
768,
832,
896,
960,
1023,
1023,
960,
896,
832,
768,
704,
640,
576,
512,
448,
384,
320,
256,
192,
128,
64};
        #endregion

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

        private void button_OpenPort_Click(object sender, System.EventArgs e)
        {
            //_serialPort.PortName = textBox_PortName.Text;
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

        private void button_StartTest_Click(object sender, EventArgs e)
        {
            isRunning = true;

            int amount = Int32.Parse(textBox_repetitions.Text);
            for (int j = 0; j < amount; j++)
            {
                for (int i = 0; i < positionList0.Length; i++)
                {
                    if (isRunning)
                    {
                        setPosition(positionList0[i], speedList0[i]);
                        Task.Delay(-1).Wait(10);
                    }
                    else break;
                }
                //Task.Delay(-1).Wait(500);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isRunning = false;
        }

        private void button_TurnMotor_Click(object sender, EventArgs e)
        {
            int angle = Int32.Parse(textBox_motorAngle.Text);
            int speed = Int32.Parse(textBox_motorSpeed.Text);

            setPosition(angle, speed);
        }

        private void button_TurnRight_Click(object sender, System.EventArgs e)
        {
            setPosition(30, 100);
        }

        private void setPosition(int motorAngle, int motorSpeed)
        {
            textBox_information.Text = "Send next command";
            try
            {
                if ((_serialPort.IsOpen))
                {
                    // Set start of message
                    msgStart = BitConverter.GetBytes(9999);
                    for (int i = 0; i < msgStart.Length; i++) sendData[i] = msgStart[i];

                    // Set ids
                    // Binär (i.e. 0000 0011 for motor 1 and 2)
                    ids = BitConverter.GetBytes((short)3);
                    for (int i = 0; i < ids.Length; i++) sendData[i + 4] = ids[i];

                    // Set speed
                    speed = BitConverter.GetBytes(motorSpeed);
                    for (int i = 0; i < speed.Length; i++) sendData[i + 8] = speed[i];

                    // Set position from database for dxl 1
                    position = BitConverter.GetBytes((short)motorAngle);
                    for (int i = 0; i < position.Length; i++) sendData[i + 12] = position[i];

                    // Set position from database for dxl 2
                    position = BitConverter.GetBytes((short)motorAngle);
                    for (int i = 0; i < position.Length; i++) sendData[i + 16] = position[i];

                    // Set end of message
                    msgEnd = BitConverter.GetBytes((short)8888);
                    for (int i = 0; i < msgEnd.Length; i++) sendData[i + 20] = msgEnd[i];


                    Debug.Write("Write to port" + "\n");
                    _serialPort.Write(sendData, 0, 64);

                    readPosition();
                }
                else Debug.Write("Not open" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void readPosition()
        {
            int positionReached = 0;
            do {
                positionReached = _serialPort.ReadByte();
            } while (positionReached != 1);

            textBox_information.Text = "Position is reached";
        }

        private void button_TurnLeft_Click(object sender, System.EventArgs e)
        {
            setPosition(650, 100);
        }

        private void button_TurnMiddle_Click(object sender, System.EventArgs e)
        {
            setPosition(330, 100);
        }

    }
}
