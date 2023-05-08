namespace num2hex
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_1 = new System.Windows.Forms.Label();
            this.label1_2 = new System.Windows.Forms.Label();
            this.textBox1_1 = new System.Windows.Forms.TextBox();
            this.textBox1_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton_Little = new System.Windows.Forms.RadioButton();
            this.radioButton_Big = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_0x = new System.Windows.Forms.RadioButton();
            this.radioButton_space = new System.Windows.Forms.RadioButton();
            this.textBox2_2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2_1 = new System.Windows.Forms.Label();
            this.textBox2_1 = new System.Windows.Forms.TextBox();
            this.label2_2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox4_2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3_4 = new System.Windows.Forms.Label();
            this.label3_3 = new System.Windows.Forms.Label();
            this.textBox4_1 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3_2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3_2 = new System.Windows.Forms.Label();
            this.label3_1 = new System.Windows.Forms.Label();
            this.textBox3_1 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_decimal_range = new System.Windows.Forms.Label();
            this.comboBox_decimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_1
            // 
            this.label1_1.AutoSize = true;
            this.label1_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_1.Location = new System.Drawing.Point(14, 22);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(42, 19);
            this.label1_1.TabIndex = 0;
            this.label1_1.Text = "float";
            // 
            // label1_2
            // 
            this.label1_2.AutoSize = true;
            this.label1_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_2.Location = new System.Drawing.Point(176, 22);
            this.label1_2.Name = "label1_2";
            this.label1_2.Size = new System.Drawing.Size(37, 19);
            this.label1_2.TabIndex = 0;
            this.label1_2.Text = "hex";
            // 
            // textBox1_1
            // 
            this.textBox1_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_1.Location = new System.Drawing.Point(17, 49);
            this.textBox1_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_1.Name = "textBox1_1";
            this.textBox1_1.Size = new System.Drawing.Size(100, 22);
            this.textBox1_1.TabIndex = 1;
            // 
            // textBox1_2
            // 
            this.textBox1_2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_2.Location = new System.Drawing.Point(179, 49);
            this.textBox1_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1_2.Name = "textBox1_2";
            this.textBox1_2.ReadOnly = true;
            this.textBox1_2.Size = new System.Drawing.Size(100, 22);
            this.textBox1_2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(337, 33);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton_Little
            // 
            this.radioButton_Little.AutoSize = true;
            this.radioButton_Little.Checked = true;
            this.radioButton_Little.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Little.Location = new System.Drawing.Point(121, 4);
            this.radioButton_Little.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Little.Name = "radioButton_Little";
            this.radioButton_Little.Size = new System.Drawing.Size(97, 20);
            this.radioButton_Little.TabIndex = 4;
            this.radioButton_Little.TabStop = true;
            this.radioButton_Little.Text = "Little Endian";
            this.radioButton_Little.UseVisualStyleBackColor = true;
            // 
            // radioButton_Big
            // 
            this.radioButton_Big.AutoSize = true;
            this.radioButton_Big.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Big.Location = new System.Drawing.Point(261, 4);
            this.radioButton_Big.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_Big.Name = "radioButton_Big";
            this.radioButton_Big.Size = new System.Drawing.Size(88, 20);
            this.radioButton_Big.TabIndex = 4;
            this.radioButton_Big.Text = "Big Endian";
            this.radioButton_Big.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radioButton_Little);
            this.panel2.Controls.Add(this.radioButton_Big);
            this.panel2.Location = new System.Drawing.Point(17, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 30);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endian :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton_0x);
            this.panel1.Controls.Add(this.radioButton_space);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 32);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "View Hex as :";
            // 
            // radioButton_0x
            // 
            this.radioButton_0x.AutoSize = true;
            this.radioButton_0x.Checked = true;
            this.radioButton_0x.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_0x.Location = new System.Drawing.Point(121, 6);
            this.radioButton_0x.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_0x.Name = "radioButton_0x";
            this.radioButton_0x.Size = new System.Drawing.Size(76, 20);
            this.radioButton_0x.TabIndex = 4;
            this.radioButton_0x.TabStop = true;
            this.radioButton_0x.Text = "0x Prefix";
            this.radioButton_0x.UseVisualStyleBackColor = true;
            // 
            // radioButton_space
            // 
            this.radioButton_space.AutoSize = true;
            this.radioButton_space.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_space.Location = new System.Drawing.Point(261, 6);
            this.radioButton_space.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_space.Name = "radioButton_space";
            this.radioButton_space.Size = new System.Drawing.Size(123, 20);
            this.radioButton_space.TabIndex = 4;
            this.radioButton_space.Text = "Space-separated";
            this.radioButton_space.UseVisualStyleBackColor = true;
            // 
            // textBox2_2
            // 
            this.textBox2_2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_2.Location = new System.Drawing.Point(179, 48);
            this.textBox2_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_2.Name = "textBox2_2";
            this.textBox2_2.ReadOnly = true;
            this.textBox2_2.Size = new System.Drawing.Size(100, 22);
            this.textBox2_2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(337, 32);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Convert";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2_1
            // 
            this.label2_1.AutoSize = true;
            this.label2_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_1.Location = new System.Drawing.Point(14, 21);
            this.label2_1.Name = "label2_1";
            this.label2_1.Size = new System.Drawing.Size(37, 19);
            this.label2_1.TabIndex = 0;
            this.label2_1.Text = "hex";
            // 
            // textBox2_1
            // 
            this.textBox2_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_1.Location = new System.Drawing.Point(17, 48);
            this.textBox2_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2_1.Name = "textBox2_1";
            this.textBox2_1.Size = new System.Drawing.Size(100, 22);
            this.textBox2_1.TabIndex = 1;
            // 
            // label2_2
            // 
            this.label2_2.AutoSize = true;
            this.label2_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_2.Location = new System.Drawing.Point(176, 21);
            this.label2_2.Name = "label2_2";
            this.label2_2.Size = new System.Drawing.Size(42, 19);
            this.label2_2.TabIndex = 0;
            this.label2_2.Text = "float";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1_2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1_2);
            this.panel3.Controls.Add(this.label1_1);
            this.panel3.Controls.Add(this.textBox1_1);
            this.panel3.Location = new System.Drawing.Point(17, 105);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 100);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox2_2);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.label2_2);
            this.panel4.Controls.Add(this.label2_1);
            this.panel4.Controls.Add(this.textBox2_1);
            this.panel4.Location = new System.Drawing.Point(17, 213);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 100);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox4_2);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.label3_4);
            this.panel5.Controls.Add(this.label3_3);
            this.panel5.Controls.Add(this.textBox4_1);
            this.panel5.Location = new System.Drawing.Point(17, 496);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(423, 100);
            this.panel5.TabIndex = 11;
            // 
            // textBox4_2
            // 
            this.textBox4_2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_2.Location = new System.Drawing.Point(179, 48);
            this.textBox4_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4_2.Name = "textBox4_2";
            this.textBox4_2.ReadOnly = true;
            this.textBox4_2.Size = new System.Drawing.Size(100, 22);
            this.textBox4_2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(337, 32);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 2;
            this.button4.Text = "Convert";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3_4
            // 
            this.label3_4.AutoSize = true;
            this.label3_4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_4.Location = new System.Drawing.Point(176, 21);
            this.label3_4.Name = "label3_4";
            this.label3_4.Size = new System.Drawing.Size(62, 19);
            this.label3_4.TabIndex = 0;
            this.label3_4.Text = "Integer";
            // 
            // label3_3
            // 
            this.label3_3.AutoSize = true;
            this.label3_3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_3.Location = new System.Drawing.Point(14, 21);
            this.label3_3.Name = "label3_3";
            this.label3_3.Size = new System.Drawing.Size(37, 19);
            this.label3_3.TabIndex = 0;
            this.label3_3.Text = "hex";
            // 
            // textBox4_1
            // 
            this.textBox4_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4_1.Location = new System.Drawing.Point(17, 48);
            this.textBox4_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox4_1.Name = "textBox4_1";
            this.textBox4_1.Size = new System.Drawing.Size(100, 22);
            this.textBox4_1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.textBox3_2);
            this.panel6.Controls.Add(this.button3);
            this.panel6.Controls.Add(this.label3_2);
            this.panel6.Controls.Add(this.label3_1);
            this.panel6.Controls.Add(this.textBox3_1);
            this.panel6.Location = new System.Drawing.Point(17, 388);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(423, 100);
            this.panel6.TabIndex = 10;
            // 
            // textBox3_2
            // 
            this.textBox3_2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3_2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_2.Location = new System.Drawing.Point(179, 49);
            this.textBox3_2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3_2.Name = "textBox3_2";
            this.textBox3_2.ReadOnly = true;
            this.textBox3_2.Size = new System.Drawing.Size(100, 22);
            this.textBox3_2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(337, 33);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3_2
            // 
            this.label3_2.AutoSize = true;
            this.label3_2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_2.Location = new System.Drawing.Point(176, 22);
            this.label3_2.Name = "label3_2";
            this.label3_2.Size = new System.Drawing.Size(37, 19);
            this.label3_2.TabIndex = 0;
            this.label3_2.Text = "hex";
            // 
            // label3_1
            // 
            this.label3_1.AutoSize = true;
            this.label3_1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_1.Location = new System.Drawing.Point(14, 22);
            this.label3_1.Name = "label3_1";
            this.label3_1.Size = new System.Drawing.Size(62, 19);
            this.label3_1.TabIndex = 0;
            this.label3_1.Text = "Integer";
            // 
            // textBox3_1
            // 
            this.textBox3_1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3_1.Location = new System.Drawing.Point(17, 49);
            this.textBox3_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3_1.Name = "textBox3_1";
            this.textBox3_1.Size = new System.Drawing.Size(100, 22);
            this.textBox3_1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_decimal_range);
            this.panel7.Controls.Add(this.comboBox_decimal);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(17, 333);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(423, 39);
            this.panel7.TabIndex = 13;
            // 
            // label_decimal_range
            // 
            this.label_decimal_range.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decimal_range.Location = new System.Drawing.Point(204, 9);
            this.label_decimal_range.Name = "label_decimal_range";
            this.label_decimal_range.Size = new System.Drawing.Size(216, 24);
            this.label_decimal_range.TabIndex = 13;
            this.label_decimal_range.Text = "-128 ~ 127";
            this.label_decimal_range.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_decimal
            // 
            this.comboBox_decimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_decimal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_decimal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox_decimal.FormattingEnabled = true;
            this.comboBox_decimal.Items.AddRange(new object[] {
            "int8_t",
            "uint8_t",
            "int16_t",
            "uint16_t",
            "int32_t",
            "uint32_t"});
            this.comboBox_decimal.Location = new System.Drawing.Point(99, 9);
            this.comboBox_decimal.Name = "comboBox_decimal";
            this.comboBox_decimal.Size = new System.Drawing.Size(99, 24);
            this.comboBox_decimal.TabIndex = 12;
            this.comboBox_decimal.SelectedIndexChanged += new System.EventHandler(this.comboBox_decimal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Type :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 606);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Hex Converter v1.0 by SH Jo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label1_2;
        private System.Windows.Forms.TextBox textBox1_1;
        private System.Windows.Forms.TextBox textBox1_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton_Little;
        private System.Windows.Forms.RadioButton radioButton_Big;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_0x;
        private System.Windows.Forms.RadioButton radioButton_space;
        private System.Windows.Forms.TextBox textBox2_2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2_1;
        private System.Windows.Forms.TextBox textBox2_1;
        private System.Windows.Forms.Label label2_2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBox4_2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3_4;
        private System.Windows.Forms.Label label3_3;
        private System.Windows.Forms.TextBox textBox4_1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3_2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3_2;
        private System.Windows.Forms.Label label3_1;
        private System.Windows.Forms.TextBox textBox3_1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_decimal_range;
        private System.Windows.Forms.ComboBox comboBox_decimal;
        private System.Windows.Forms.Label label1;
    }
}

