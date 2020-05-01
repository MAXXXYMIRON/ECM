using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using CashWorking;

namespace CashWork_Aplication
{
    public partial class Form1 : Form
    {
        Controller Data;
        int CountSegments,
            CountLines,
            CountElements;
        char[] LineData;

        int AdresI, AdresJ, AdresK;
        char WriteVal;

        Stopwatch Time = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Make_Click(object sender, EventArgs e)
        {
            try
            {
                CountSegments = Convert.ToInt32(Segs.Text);
                CountLines = Convert.ToInt32(Lines.Text);
                CountElements = Convert.ToInt32(Els.Text);

                LineData = new char[CountElements];
                Data = new Controller(CountSegments, CountLines, CountElements);

                Make.Enabled = false;
                Segs.Enabled = false;
                Lines.Enabled = false;
                Els.Enabled = false;
                MM.Enabled = true;
                C.Enabled = true;
                Read.Enabled = true;
                Write.Enabled = true;
                WriteValue.Enabled = true;
                Segment.Enabled = true;
                Element.Enabled = true;
                Line.Enabled = true;

                Write_MM_To_RichTextBox();
                Write_C_To_RichTextBox();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                AdresI = Convert.ToInt32(Segment.Text);
                AdresJ = Convert.ToInt32(Line.Text);
                AdresK = Convert.ToInt32(Element.Text);

                Time.Start();
                WriteVal = Data[AdresI, AdresJ, AdresK];
                Time.Stop();

                Upload_data(WriteVal);

                Write_MM_To_RichTextBox();
                Write_C_To_RichTextBox();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
                MessageBox.Show("Некорректные данные");
                MessageBox.Show("Некорректные данные");
            }
        }

        private void Write_Click(object sender, EventArgs e)
        {
            try
            {
                AdresI = Convert.ToInt32(Segment.Text);
                AdresJ = Convert.ToInt32(Line.Text);
                AdresK = Convert.ToInt32(Element.Text);
                WriteVal = Convert.ToChar(WriteValue.Text);

                Time.Start();
                Data[AdresI, AdresJ, AdresK] = WriteVal;
                Time.Stop();


                Upload_data(WriteVal);

                Write_MM_To_RichTextBox();
                Write_C_To_RichTextBox();
            }
            catch
            {
                MessageBox.Show("Некорректные данные");
            }
        }

        void Write_C_To_RichTextBox()
        {
            C.Text = "";
            for (int i = 1; i <= CountLines; i++)
            {
                LineData = Controller.L[i];
                C.Text += Controller.L.GetTag(i);
                C.Text += "\t\t";
                for (int k = 0; k < CountElements; k++)
                {
                    C.Text += LineData[k];
                }
                C.Text += '\n';
            }
        }
        void Write_MM_To_RichTextBox()
        {
            MM.Text = "";
            for (int i = 1; i <= CountSegments; i++)
            {
                for (int j = 1; j <= CountLines; j++)
                {
                    LineData = Controller.MainMemo.GetLine(i, j);
                    for (int k = 0; k < CountElements; k++)
                    {
                        MM.Text += LineData[k];
                    }
                    MM.Text += '\n';
                }
                MM.Text += '\n';
            }
        }
        void Upload_data(char el)
        {
            if (Data.FromCash)
            {
                CMM.Text = "Из - КЭШа";
                C.BackColor = Color.FromArgb(255, 70, 74);
                MM.BackColor = Color.White;
            }
            else
            {
                CMM.Text = "Из - ОП";
                C.BackColor = Color.White;
                MM.BackColor = Color.FromArgb(255, 70, 74);
            }

            labelEl.Text = el.ToString();
            labelTime.Text = Time.Elapsed.ToString();
            Time.Reset();

            labelLine.Text = "";
            for (int i = 1; i <= CountElements; i++)
            {
                labelLine.Text += Controller.L[AdresJ, i];
            }
        }
    }
}
