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
            this.textBox1_1.Focus();
            this.comboBox_decimal.SelectedIndex = 0;
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
                    string hexString = hexValue.ToString("X8");
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

        private void comboBox_decimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedText = this.comboBox_decimal.SelectedItem.ToString();

            if (selectedText == "int8_t")
            {
                this.label_decimal_range.Text = "-128 ~ 127";
            }
            else if (selectedText == "uint8_t")
            {
                this.label_decimal_range.Text = "0 ~ 255";
            }
            else if (selectedText == "int16_t")
            {
                this.label_decimal_range.Text = "-32,768 ~ 32,767";
            }
            else if (selectedText == "uint16_t")
            {
                this.label_decimal_range.Text = "0 ~ 65,535";
            }
            else if (selectedText == "int32_t")
            {
                this.label_decimal_range.Text = "-2,147,483,648 ~ 2,147,483,647";
            }
            else if (selectedText == "uint32_t")
            {
                this.label_decimal_range.Text = "0 ~ 4,294,967,295";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox3_1.Text != "")
            {
                string selectedText = this.comboBox_decimal.SelectedItem.ToString();
                string inputString = this.textBox3_1.Text;
                bool parseResult = false;
                string hexString = "";

                if (selectedText == "int8_t")
                {
                    if(parseResult = sbyte.TryParse(inputString, out sbyte val))
                    {
                        hexString = val.ToString("X2");
                    }
                }
                else if (selectedText == "uint8_t")
                {
                    if(parseResult = byte.TryParse(inputString, out byte val))
                    {
                        hexString = val.ToString("X2");
                    }
                }
                else if (selectedText == "int16_t")
                {
                    if(parseResult = short.TryParse(inputString, out short val))
                    {
                        hexString = val.ToString("X4");
                    }
                }
                else if (selectedText == "uint16_t")
                {
                    if(parseResult = ushort.TryParse(inputString, out ushort val))
                    {
                        hexString = val.ToString("X4");
                    }
                }
                else if (selectedText == "int32_t")
                {
                    if(parseResult = int.TryParse(inputString, out int val))
                    {
                        hexString = val.ToString("X8");
                    }
                }
                else if (selectedText == "uint32_t")
                {
                    if(parseResult = uint.TryParse(inputString, out uint val))
                    {
                        hexString = val.ToString("X8");
                    }
                }
                
                if(this.radioButton_Little.Checked && (selectedText == "int16_t" || selectedText == "uint16_t"))
                {
                    string tempString = hexString.Substring(2, 2) + hexString.Substring(0, 2);
                    hexString = tempString;
                }
                else if(this.radioButton_Little.Checked && (selectedText == "int32_t" || selectedText == "uint32_t"))
                {
                    string tempString = hexString.Substring(6, 2) + hexString.Substring(4, 2) + hexString.Substring(2, 2) + hexString.Substring(0, 2);
                    hexString = tempString;
                }

                if(parseResult)
                {
                    if (this.radioButton_0x.Checked)
                    {
                        this.textBox3_2.Text = "0x" + hexString.ToUpper();
                    }
                    else
                    {
                        string[] tokens = Enumerable.Range(0, hexString.Length / 2).Select(x => hexString.Substring(x * 2, 2)).ToArray();
                        this.textBox3_2.Text = string.Join(" ", tokens);
                    }
                }
                else
                {
                    this.textBox3_2.Text = "ERROR";
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox4_1.Text != "")
            {
                string selectedText = this.comboBox_decimal.SelectedItem.ToString();
                string hexString = this.textBox4_1.Text;
                hexString = hexString.Replace("0x", "");
                hexString = hexString.Replace(" ", "");

                if (Regex.IsMatch(hexString, "^[0-9a-fA-F]{1,8}$"))
                {
                    byte[] decimalBytes = Enumerable.Range(0, hexString.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(hexString.Substring(x, 2), 16)).ToArray();
                    if (this.radioButton_Big.Checked)
                    {
                        Array.Reverse(decimalBytes);
                    }

                    if (selectedText == "int8_t")
                    {
                        sbyte sbyteValue = (sbyte)decimalBytes[0];
                        this.textBox4_2.Text = sbyteValue.ToString();
                    }
                    else if (selectedText == "uint8_t")
                    {
                        this.textBox4_2.Text = decimalBytes[0].ToString();
                    }
                    else if (selectedText == "int16_t")
                    {
                        short shortValue = BitConverter.ToInt16(decimalBytes, 0);
                        this.textBox4_2.Text = shortValue.ToString();
                    }
                    else if (selectedText == "uint16_t")
                    {
                        ushort ushortValue = BitConverter.ToUInt16(decimalBytes, 0);
                        this.textBox4_2.Text = ushortValue.ToString();
                    }
                    else if (selectedText == "int32_t")
                    {
                        int intValue = BitConverter.ToInt32(decimalBytes, 0);
                        this.textBox4_2.Text = intValue.ToString();
                    }
                    else if (selectedText == "uint32_t")
                    {
                        uint uintValue = BitConverter.ToUInt32(decimalBytes, 0);
                        this.textBox4_2.Text = uintValue.ToString();
                    }
                }
                else
                {
                    this.textBox4_2.Text = "ERROR";
                }

            }
        }
    }
}
