using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

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
            textBox1_1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1_1.Text != "")
            {
                float floatValue;
                if (float.TryParse(this.textBox1_1.Text, out floatValue))
                {
                    this.textBox1_1.Text = floatValue.ToString();
                    byte[] floatBytes = BitConverter.GetBytes(floatValue);
                    if(this.radioButton_Little.Checked)
                    {
                        Array.Reverse(floatBytes);
                    }
                    uint hexValue = BitConverter.ToUInt32(floatBytes, 0);
                    string hexString = hexValue.ToString("X");
                    if(this.radioButton_0x.Checked)
                    {
                        this.textBox1_2.Text = "0x" + hexString.ToUpper();
                    }
                    else
                    {
                        string[] tokens = Enumerable.Range(0, hexString.Length / 2).Select(x => hexString.Substring(x * 2, 2)).ToArray();
                        this.textBox1_2.Text = string.Join(" ", tokens);
                    }
                }
                else
                {
                    this.textBox1_2.Text = "ERROR";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2_1.Text != "")
            {
                string hexString = this.textBox2_1.Text;
                hexString = hexString.Replace("0x", "");
                hexString = hexString.Replace(" ", "");

                if (Regex.IsMatch(hexString, "^[0-9a-fA-F]{1,8}$"))
                {
                    byte[] floatBytes = Enumerable.Range(0, hexString.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(hexString.Substring(x, 2), 16)).ToArray();
                    if (this.radioButton_Big.Checked)
                    {
                        Array.Reverse(floatBytes);
                    }
                    float floatValue = BitConverter.ToSingle(floatBytes, 0);
                    this.textBox2_2.Text = floatValue.ToString();
                }
                else
                {
                    this.textBox2_2.Text = "ERROR";
                }
 
            }
        }
    }
}
