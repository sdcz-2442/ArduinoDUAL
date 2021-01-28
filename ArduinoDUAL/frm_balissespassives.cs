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
    public partial class frm_balissespassives : Form
    {
        System.IO.Ports.SerialPort ArduinoPort;
        //El combobox mostrarà els ports series disponibles 
        //i permetrà seleccionar amb quin port establirem la
        //comunicació amb el dispositiu IoT.

        public frm_balissespassives()
        {
            InitializeComponent();

            //crear Serial Port
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";  //sustituir por vuestro 
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar puerto
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }
        private void btn_connectar_Click(object sender, EventArgs e)
        {
            //obrirà el port seleccionat i per verificar que la comunicació ha estat reeixida, encendra els
            //3 LEDs durant 5 segons.
        }

        private void btn_configure_Click(object sender, EventArgs e)
        {

        }

        private void tbx_iteracions_Leave(object sender, EventArgs e)
        {
            int i;
            if (!int.TryParse(tbx_iteracions.Text, out i))
            {
                //Label.Text = "This is a number only field";
                //return;
            }
        }
    }
}
