using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodica_v12o1
{
    public partial class EditData : Form
    {
        int atmno;
        string content;
        string[] elements;
        string elementPath;
        public EditData(int ano)
        {
            InitializeComponent();
            atmno = ano;
            initialiseData(atmno);
        }

        public string getElement(int atmno)
        {
            elements = File.ReadAllLines("Periodica Files\\ElementList.PeriodicaFiles");
            return StrCipV1.Decrypt(elements[atmno], "Periodica");
        }

        public void initialiseData(int atn)
        {
            textBox1.Text = getElement(atn - 1);
            elementPath = "Periodica Files\\Elements\\" + atn.ToString() + ".PeriodicaElements";
            string elementContent = File.ReadAllText(elementPath);
            elementContent = StrCipV1.Decrypt(elementContent, "Periodica");
            label4.Text = atn.ToString();
            richTextBox1.Text = elementContent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atmno--;
            if (atmno >= 1)
                try
                {
                    initialiseData(atmno);
                }

                catch
                {
                    Console.Write("");
                }
            else
                atmno = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atmno++;
            if (atmno < 119)
                try
                {
                    initialiseData(atmno);
                }

                catch
                {
                    Console.Write("");
                }
            else
                atmno = 118;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            elements[atmno - 1] = StrCipV1.Encrypt(textBox1.Text, "Periodica");
            File.WriteAllLines("Periodica Files\\ElementList.PeriodicaFiles", elements);
            button1.ForeColor = Color.Lime;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string editedContent = richTextBox1.Text;
            editedContent = StrCipV1.Encrypt(editedContent, "Periodica");
            File.WriteAllText(elementPath, editedContent);
            button2.ForeColor = Color.Lime;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
