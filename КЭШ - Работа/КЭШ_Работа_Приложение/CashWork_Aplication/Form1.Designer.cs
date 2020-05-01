namespace CashWork_Aplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.Make = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Label();
            this.Segs = new System.Windows.Forms.TextBox();
            this.MM = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lines = new System.Windows.Forms.TextBox();
            this.Els = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Element = new System.Windows.Forms.TextBox();
            this.Line = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Segment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.labelEl = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.RichTextBox();
            this.Read = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.WriteValue = new System.Windows.Forms.TextBox();
            this.CMM = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Make
            // 
            this.Make.Location = new System.Drawing.Point(12, 51);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(264, 23);
            this.Make.TabIndex = 0;
            this.Make.Text = "Создать";
            this.Make.UseVisualStyleBackColor = true;
            this.Make.Click += new System.EventHandler(this.Make_Click);
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Location = new System.Drawing.Point(12, 9);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(57, 13);
            this.e.TabIndex = 1;
            this.e.Text = "Сегменов";
            // 
            // Segs
            // 
            this.Segs.Location = new System.Drawing.Point(12, 25);
            this.Segs.Name = "Segs";
            this.Segs.Size = new System.Drawing.Size(83, 20);
            this.Segs.TabIndex = 2;
            // 
            // MM
            // 
            this.MM.Enabled = false;
            this.MM.Location = new System.Drawing.Point(282, 25);
            this.MM.Name = "MM";
            this.MM.ReadOnly = true;
            this.MM.Size = new System.Drawing.Size(155, 541);
            this.MM.TabIndex = 3;
            this.MM.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Строк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Элементов";
            // 
            // Lines
            // 
            this.Lines.Location = new System.Drawing.Point(103, 25);
            this.Lines.Name = "Lines";
            this.Lines.Size = new System.Drawing.Size(83, 20);
            this.Lines.TabIndex = 6;
            // 
            // Els
            // 
            this.Els.Location = new System.Drawing.Point(193, 25);
            this.Els.Name = "Els";
            this.Els.Size = new System.Drawing.Size(83, 20);
            this.Els.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ОП";
            // 
            // Element
            // 
            this.Element.Enabled = false;
            this.Element.Location = new System.Drawing.Point(193, 123);
            this.Element.Name = "Element";
            this.Element.Size = new System.Drawing.Size(83, 20);
            this.Element.TabIndex = 14;
            // 
            // Line
            // 
            this.Line.Enabled = false;
            this.Line.Location = new System.Drawing.Point(103, 123);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(83, 20);
            this.Line.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Элемент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Строка";
            // 
            // Segment
            // 
            this.Segment.Enabled = false;
            this.Segment.Location = new System.Drawing.Point(12, 123);
            this.Segment.Name = "Segment";
            this.Segment.Size = new System.Drawing.Size(83, 20);
            this.Segment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Сегмент";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "АДРЕС";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Строка - ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Элемент - ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "КЭШ";
            // 
            // labelLine
            // 
            this.labelLine.AutoSize = true;
            this.labelLine.Location = new System.Drawing.Point(70, 198);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(16, 13);
            this.labelLine.TabIndex = 19;
            this.labelLine.Text = " - ";
            // 
            // labelEl
            // 
            this.labelEl.AutoSize = true;
            this.labelEl.Location = new System.Drawing.Point(70, 220);
            this.labelEl.Name = "labelEl";
            this.labelEl.Size = new System.Drawing.Size(16, 13);
            this.labelEl.TabIndex = 20;
            this.labelEl.Text = " - ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Теги";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(106, 298);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Строки";
            // 
            // C
            // 
            this.C.Enabled = false;
            this.C.Location = new System.Drawing.Point(8, 314);
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Size = new System.Drawing.Size(267, 252);
            this.C.TabIndex = 24;
            this.C.Text = "";
            // 
            // Read
            // 
            this.Read.Enabled = false;
            this.Read.Location = new System.Drawing.Point(12, 149);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(83, 23);
            this.Read.TabIndex = 25;
            this.Read.Text = "Считать";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Write
            // 
            this.Write.Enabled = false;
            this.Write.Location = new System.Drawing.Point(103, 149);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(83, 23);
            this.Write.TabIndex = 26;
            this.Write.Text = "Задать - ";
            this.Write.UseVisualStyleBackColor = true;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // WriteValue
            // 
            this.WriteValue.Enabled = false;
            this.WriteValue.Location = new System.Drawing.Point(192, 151);
            this.WriteValue.Name = "WriteValue";
            this.WriteValue.Size = new System.Drawing.Size(83, 20);
            this.WriteValue.TabIndex = 27;
            // 
            // CMM
            // 
            this.CMM.AutoSize = true;
            this.CMM.Location = new System.Drawing.Point(119, 185);
            this.CMM.Name = "CMM";
            this.CMM.Size = new System.Drawing.Size(30, 13);
            this.CMM.TabIndex = 28;
            this.CMM.Text = "Из - ";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(70, 243);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(16, 13);
            this.labelTime.TabIndex = 30;
            this.labelTime.Text = " - ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Время - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 578);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CMM);
            this.Controls.Add(this.WriteValue);
            this.Controls.Add(this.Write);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.C);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelEl);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Element);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Segment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Els);
            this.Controls.Add(this.Lines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.Segs);
            this.Controls.Add(this.e);
            this.Controls.Add(this.Make);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Make;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.TextBox Segs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Lines;
        private System.Windows.Forms.TextBox Els;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Element;
        private System.Windows.Forms.TextBox Line;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Segment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelLine;
        private System.Windows.Forms.Label labelEl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox C;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Write;
        private System.Windows.Forms.TextBox WriteValue;
        private System.Windows.Forms.RichTextBox MM;
        private System.Windows.Forms.Label CMM;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label label12;
    }
}

