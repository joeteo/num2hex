using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num2hex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "")
            {
                float floatValue;
                if (float.TryParse(this.textBox1.Text, out floatValue))
                {
                    this.textBox1.Text = floatValue.ToString();
                    byte[] floatBytes = BitConverter.GetBytes(floatValue);
                    uint hexValue = BitConverter.ToUInt32(floatBytes, 0);
                    string hexString = hexValue.ToString("X");
                    this.textBox2.Text = "0x"+hexString.ToUpper();
                }
                else
                {
                    this.textBox1.Text = "ERROR";
                }
            }
        }

    }
}
