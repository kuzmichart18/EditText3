using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EditText
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываемв файл содержимое textBox с кодировкой 1251
}
            richTextBox.Clear();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void buttonCut_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void поЛевомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Left; //выравнивание по левому краю
        }

        private void поЦентруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Center; //выравнивание по центру
        }

        private void поПравомуКраюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Select();
            richTextBox.SelectionAlignment = HorizontalAlignment.Right; //выравнивание по правому краю
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myFont = new Font("Tahoma", 12, FontStyle.Regular, GraphicsUnit.Pixel);
            string Hello = "Hello World!";
            e.Graphics.DrawString(Hello, myFont, Brushes.Black, 20, 20);
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK) printDocument1.Print();
        }

        private void настройкаПринтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void предварительныйПросмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {Color selectedColor = colorDialog.Color;
                richTextBox.SelectionColor = selectedColor;
                richTextBox.SelectionLength = 0;
            }
        }

        private void buttonSrift_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                richTextBox.SelectionFont = selectedFont;
                richTextBox.SelectionLength = 0;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;
                richTextBox.SelectionColor = selectedColor;
                richTextBox.SelectionLength = 0;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font selectedFont = fontDialog.Font;
                richTextBox.SelectionFont = selectedFont;
                richTextBox.SelectionLength = 0;
            }
        }

        private void копироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void вставитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void вырезатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем был ли выбран файл
            {
                richTextBox.Clear(); //Очищаем richTextBox
                openFileDialog1.Filter = "Text Files (*.txt)|*.txt"; //Указываем что нас интересуют только текстовые файлы
                string fileName = openFileDialog1.FileName; //получаем наименование файл и путь к нему.
                richTextBox.Text = File.ReadAllText(fileName, Encoding.GetEncoding(1251)); //Передаем содержимое файла в richTextBox
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files|*.txt";//Задаем доступные расширения
            saveFileDialog1.DefaultExt = ".txt"; //Задаем расширение по умолчанию
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) //Проверяем подтверждение сохранения информации.
            {
                var name = saveFileDialog1.FileName; //Задаем имя файлу
                File.WriteAllText(name, richTextBox.Text, Encoding.GetEncoding(1251)); //Записываемв файл содержимое textBox с кодировкой 1251
            }
            richTextBox.Clear();
        }

        private void выделитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.Focus();
        }

        private void выделитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;
            richTextBox.Focus();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 Form = new AboutBox1();
            Form.Show();
        }
    }
}
