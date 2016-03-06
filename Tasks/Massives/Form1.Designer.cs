using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Massives
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
            ChartArea chartArea3 = new ChartArea();
            this.textBox1 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.button1 = new Button();
            this.menuStrip1 = new MenuStrip();
            this.основноеToolStripMenuItem = new ToolStripMenuItem();
            this.настрокиToolStripMenuItem = new ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            this.выходToolStripMenuItem = new ToolStripMenuItem();
            this.функцииToolStripMenuItem = new ToolStripMenuItem();
            this.сгенерироватьНовыйМассивToolStripMenuItem = new ToolStripMenuItem();
            this.richTextBox1 = new RichTextBox();
            this.chart1 = new Chart();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new Point(4, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(256, 353);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1. Количество элементов массива, больших своих соседей",
            "2. Номер первого элемента, большего 25",
            "3. Сумма элементов больших, чем  второй элемент массива",
            "4. Определить, превосходит ли первый элемент среднее значение всех элементов",
            "5. Сколько раз меняется знак у элементов",
            "6. Сколько элементов больше, чем четвёртый",
            "7. Сумма элементов, больших 21",
            "8. Увеличить на единицу всех элементов, кратных 5",
            "9. Сумма элементов, не кратных 3",
            "10. Сколько чисел меньше первого и больше последнего элемента",
            "11. Количество не отрицательных элементов",
            "12. Элемент, меньше всего отличающийся от второго",
            "13. Количество ненулевых элементов",
            "14.  Количество элементов, кратных 3",
            "15. Сумма элементов,меньших чем пятый",
            "16. Гистограмма"});
            this.comboBox1.Location = new Point(266, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(480, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new Point(390, 54);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.основноеToolStripMenuItem,
            this.функцииToolStripMenuItem,
            this.настрокиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(757, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // основноеToolStripMenuItem
            // 
            this.основноеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.основноеToolStripMenuItem.Name = "основноеToolStripMenuItem";
            this.основноеToolStripMenuItem.Size = new Size(74, 20);
            this.основноеToolStripMenuItem.Text = "Основное";
            // 
            // настрокиToolStripMenuItem
            // 
            this.настрокиToolStripMenuItem.Name = "настрокиToolStripMenuItem";
            this.настрокиToolStripMenuItem.Size = new Size(72, 20);
            this.настрокиToolStripMenuItem.Text = "Настроки";
            this.настрокиToolStripMenuItem.Click += new EventHandler(this.настрокиToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.сгенерироватьНовыйМассивToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // сгенерироватьНовыйМассивToolStripMenuItem
            // 
            this.сгенерироватьНовыйМассивToolStripMenuItem.Name = "сгенерироватьНовыйМассивToolStripMenuItem";
            this.сгенерироватьНовыйМассивToolStripMenuItem.Size = new Size(239, 22);
            this.сгенерироватьНовыйМассивToolStripMenuItem.Text = "Сгенерировать новый массив";
            this.сгенерироватьНовыйМассивToolStripMenuItem.Click += new EventHandler(this.сгенерироватьНовыйМассивToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new Point(266, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(480, 272);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new Point(266, 108);
            this.chart1.Name = "chart1";
            this.chart1.Size = new Size(480, 272);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(757, 392);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.chart1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Массивы";
            this.Load += new EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem основноеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem функцииToolStripMenuItem;
        private ToolStripMenuItem сгенерироватьНовыйМассивToolStripMenuItem;
        private ToolStripMenuItem настрокиToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Chart chart1;
    }
}

