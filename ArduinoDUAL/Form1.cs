using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoDUAL
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;
        public Form1()
        {
            InitializeComponent();

            //crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";  //sustituir por vuestro 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            //vincular eventos
            this.FormClosing += FrmMain_FormClosing;
            this.btn_configure.Click += btn_configure_Click;
            this.btn_connectar.Click += btn_connectar_Click;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void btn_connectar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }

        private void btn_configure_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }
    }
}
