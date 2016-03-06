using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RegularExpressions
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.textBox1 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox5 = new TextBox();
            this.label4 = new Label();
            this.label5 = new Label();
            this.textBox4 = new TextBox();
            this.textBox2 = new TextBox();
            this.label6 = new Label();
            this.label7 = new Label();
            this.textBox8 = new TextBox();
            this.textBox6 = new TextBox();
            this.label8 = new Label();
            this.label9 = new Label();
            this.textBox11 = new TextBox();
            this.textBox9 = new TextBox();
            this.label10 = new Label();
            this.label11 = new Label();
            this.textBox12 = new TextBox();
            this.textBox10 = new TextBox();
            this.label12 = new Label();
            this.label13 = new Label();
            this.textBox16 = new TextBox();
            this.textBox14 = new TextBox();
            this.label14 = new Label();
            this.label15 = new Label();
            this.textBox15 = new TextBox();
            this.textBox13 = new TextBox();
            this.label16 = new Label();
            this.label17 = new Label();
            this.bRestore = new Button();
            this.button16 = new Button();
            this.button14 = new Button();
            this.button12 = new Button();
            this.button10 = new Button();
            this.button8 = new Button();
            this.button6 = new Button();
            this.button4 = new Button();
            this.button2 = new Button();
            this.button15 = new Button();
            this.button13 = new Button();
            this.button11 = new Button();
            this.button9 = new Button();
            this.button7 = new Button();
            this.button5 = new Button();
            this.button3 = new Button();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Валидация данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = SystemColors.Control;
            this.label2.ForeColor = SystemColors.HotTrack;
            this.label2.Location = new Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Натуральное число";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = SystemColors.HotTrack;
            this.label3.Location = new Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вещественное число(*,!!)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(13, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(176, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new EventHandler(this.Check);
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(12, 101);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(176, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new EventHandler(this.Check);
            // 
            // textBox7
            // 
            this.textBox7.Location = new Point(12, 193);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Size(176, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextChanged += new EventHandler(this.Check);
            // 
            // textBox5
            // 
            this.textBox5.Location = new Point(13, 149);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Size(176, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new EventHandler(this.Check);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = SystemColors.HotTrack;
            this.label4.Location = new Point(12, 177);
            this.label4.Name = "label4";
            this.label4.Size = new Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HTML - контейнер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = SystemColors.Control;
            this.label5.ForeColor = SystemColors.HotTrack;
            this.label5.Location = new Point(13, 133);
            this.label5.Name = "label5";
            this.label5.Size = new Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Почтовый индекс";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Point(249, 101);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(164, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.TextChanged += new EventHandler(this.Check);
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(250, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(164, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.TextChanged += new EventHandler(this.Check);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = SystemColors.HotTrack;
            this.label6.Location = new Point(250, 85);
            this.label6.Name = "label6";
            this.label6.Size = new Size(71, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Целое число";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = SystemColors.Control;
            this.label7.ForeColor = SystemColors.HotTrack;
            this.label7.Location = new Point(250, 41);
            this.label7.Name = "label7";
            this.label7.Size = new Size(108, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Комплексное число";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Point(249, 193);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Size(164, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new EventHandler(this.Check);
            // 
            // textBox6
            // 
            this.textBox6.Location = new Point(250, 149);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Size(164, 20);
            this.textBox6.TabIndex = 21;
            this.textBox6.TextChanged += new EventHandler(this.Check);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = SystemColors.HotTrack;
            this.label8.Location = new Point(250, 177);
            this.label8.Name = "label8";
            this.label8.Size = new Size(29, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "URL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = SystemColors.Control;
            this.label9.ForeColor = SystemColors.HotTrack;
            this.label9.Location = new Point(250, 133);
            this.label9.Name = "label9";
            this.label9.Size = new Size(90, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Почтовый адрес";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Point(11, 282);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Size(176, 20);
            this.textBox11.TabIndex = 28;
            this.textBox11.TextChanged += new EventHandler(this.Check);
            // 
            // textBox9
            // 
            this.textBox9.Location = new Point(12, 238);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Size(176, 20);
            this.textBox9.TabIndex = 27;
            this.textBox9.TextChanged += new EventHandler(this.Check);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = SystemColors.HotTrack;
            this.label10.Location = new Point(11, 266);
            this.label10.Name = "label10";
            this.label10.Size = new Size(35, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "E-mail";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = SystemColors.Control;
            this.label11.ForeColor = SystemColors.HotTrack;
            this.label11.Location = new Point(12, 222);
            this.label11.Name = "label11";
            this.label11.Size = new Size(43, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ф.И.О.";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Point(248, 282);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Size(164, 20);
            this.textBox12.TabIndex = 34;
            this.textBox12.TextChanged += new EventHandler(this.Check);
            // 
            // textBox10
            // 
            this.textBox10.Location = new Point(249, 238);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Size(164, 20);
            this.textBox10.TabIndex = 33;
            this.textBox10.TextChanged += new EventHandler(this.Check);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = SystemColors.HotTrack;
            this.label12.Location = new Point(247, 266);
            this.label12.Name = "label12";
            this.label12.Size = new Size(50, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "E-mail(ru)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = SystemColors.Control;
            this.label13.ForeColor = SystemColors.HotTrack;
            this.label13.Location = new Point(249, 222);
            this.label13.Name = "label13";
            this.label13.Size = new Size(164, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Телефонный номер(11 знаков)";
            // 
            // textBox16
            // 
            this.textBox16.Location = new Point(249, 375);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Size(164, 20);
            this.textBox16.TabIndex = 46;
            this.textBox16.TextChanged += new EventHandler(this.Check);
            // 
            // textBox14
            // 
            this.textBox14.Location = new Point(250, 331);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Size(164, 20);
            this.textBox14.TabIndex = 45;
            this.textBox14.TextChanged += new EventHandler(this.Check);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = SystemColors.HotTrack;
            this.label14.Location = new Point(249, 359);
            this.label14.Name = "label14";
            this.label14.Size = new Size(113, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Фраза без повторов";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = SystemColors.Control;
            this.label15.ForeColor = SystemColors.HotTrack;
            this.label15.Location = new Point(250, 315);
            this.label15.Name = "label15";
            this.label15.Size = new Size(135, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Правильная орфография";
            // 
            // textBox15
            // 
            this.textBox15.Location = new Point(12, 375);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Size(176, 20);
            this.textBox15.TabIndex = 40;
            this.textBox15.TextChanged += new EventHandler(this.Check);
            // 
            // textBox13
            // 
            this.textBox13.Location = new Point(13, 331);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Size(176, 20);
            this.textBox13.TabIndex = 39;
            this.textBox13.TextChanged += new EventHandler(this.Check);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = SystemColors.HotTrack;
            this.label16.Location = new Point(12, 359);
            this.label16.Name = "label16";
            this.label16.Size = new Size(110, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Целое число(+ !!!_!!!)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = SystemColors.Control;
            this.label17.ForeColor = SystemColors.HotTrack;
            this.label17.Location = new Point(13, 315);
            this.label17.Name = "label17";
            this.label17.Size = new Size(100, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Календарная дата";
            // 
            // bRestore
            // 
            this.bRestore.Location = new Point(153, 13);
            this.bRestore.Name = "bRestore";
            this.bRestore.Size = new Size(205, 23);
            this.bRestore.TabIndex = 47;
            this.bRestore.Text = "Восстановить все выражения";
            this.bRestore.UseVisualStyleBackColor = true;
            this.bRestore.Click += new EventHandler(this.RestoreAll);
            // 
            // button16
            // 
            this.button16.BackgroundImage = Resource1.Image;
            this.button16.Location = new Point(420, 365);
            this.button16.Name = "button16";
            this.button16.Size = new Size(32, 36);
            this.button16.TabIndex = 63;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new EventHandler(this.button16_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = Resource1.Image;
            this.button14.Location = new Point(420, 323);
            this.button14.Name = "button14";
            this.button14.Size = new Size(32, 36);
            this.button14.TabIndex = 62;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new EventHandler(this.button14_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = Resource1.Image;
            this.button12.Location = new Point(420, 273);
            this.button12.Name = "button12";
            this.button12.Size = new Size(32, 36);
            this.button12.TabIndex = 61;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = Resource1.Image;
            this.button10.Location = new Point(420, 231);
            this.button10.Name = "button10";
            this.button10.Size = new Size(32, 36);
            this.button10.TabIndex = 60;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new EventHandler(this.button10_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = Resource1.Image;
            this.button8.Location = new Point(420, 182);
            this.button8.Name = "button8";
            this.button8.Size = new Size(32, 36);
            this.button8.TabIndex = 59;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = Resource1.Image;
            this.button6.Location = new Point(420, 140);
            this.button6.Name = "button6";
            this.button6.Size = new Size(32, 36);
            this.button6.TabIndex = 58;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = Resource1.Image;
            this.button4.Location = new Point(420, 90);
            this.button4.Name = "button4";
            this.button4.Size = new Size(32, 36);
            this.button4.TabIndex = 57;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = Resource1.Image;
            this.button2.Location = new Point(420, 48);
            this.button2.Name = "button2";
            this.button2.Size = new Size(32, 36);
            this.button2.TabIndex = 56;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // button15
            // 
            this.button15.BackgroundImage = Resource1.Image;
            this.button15.Location = new Point(195, 365);
            this.button15.Name = "button15";
            this.button15.Size = new Size(32, 36);
            this.button15.TabIndex = 55;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new EventHandler(this.button15_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = Resource1.Image;
            this.button13.Location = new Point(195, 323);
            this.button13.Name = "button13";
            this.button13.Size = new Size(32, 36);
            this.button13.TabIndex = 54;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new EventHandler(this.button13_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = Resource1.Image;
            this.button11.Location = new Point(195, 273);
            this.button11.Name = "button11";
            this.button11.Size = new Size(32, 36);
            this.button11.TabIndex = 53;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = Resource1.Image;
            this.button9.Location = new Point(195, 231);
            this.button9.Name = "button9";
            this.button9.Size = new Size(32, 36);
            this.button9.TabIndex = 52;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackgroundImage = Resource1.Image;
            this.button7.Location = new Point(195, 182);
            this.button7.Name = "button7";
            this.button7.Size = new Size(32, 36);
            this.button7.TabIndex = 51;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = Resource1.Image;
            this.button5.Location = new Point(195, 140);
            this.button5.Name = "button5";
            this.button5.Size = new Size(32, 36);
            this.button5.TabIndex = 50;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = Resource1.Image;
            this.button3.Location = new Point(195, 90);
            this.button3.Name = "button3";
            this.button3.Size = new Size(32, 36);
            this.button3.TabIndex = 49;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = Resource1.Image;
            this.button1.Location = new Point(195, 48);
            this.button1.Name = "button1";
            this.button1.Size = new Size(32, 36);
            this.button1.TabIndex = 48;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(456, 409);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bRestore);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Регулярные выражения";
            this.Load += new EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private TextBox textBox8;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private TextBox textBox11;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private TextBox textBox12;
        private TextBox textBox10;
        private Label label12;
        private Label label13;
        private TextBox textBox16;
        private TextBox textBox14;
        private Label label14;
        private Label label15;
        private TextBox textBox15;
        private TextBox textBox13;
        private Label label16;
        private Label label17;
        private Button bRestore;
        private Button button1;
        private Button button3;
        private Button button7;
        private Button button5;
        private Button button15;
        private Button button13;
        private Button button11;
        private Button button9;
        private Button button16;
        private Button button14;
        private Button button12;
        private Button button10;
        private Button button8;
        private Button button6;
        private Button button4;
        private Button button2;
    }
}

