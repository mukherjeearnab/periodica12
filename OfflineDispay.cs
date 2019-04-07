using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodica_v12o1
{
    public partial class OfflineDispay : MetroFramework.Forms.MetroForm
    {
        int atmno;
        Size rtb;
        int m1x;
        int m2x;
        int m3x;
        int m4x;
        int m5x;
        int m6x;
        int m1y;
        int m2y;
        int m3y;
        int m4y;
        int m5y;
        int m6y;
        bool appMode;
        public OfflineDispay(int atn, bool app)
        {
            InitializeComponent();
            atmno = atn;
            appMode = app;
            if (appMode)
                richTextBox1.BackColor = Color.PaleTurquoise;
            initialiseData(atmno, appMode);
            rtb = new System.Drawing.Size(429, 317);
            m1x = 460;
            m2x = 514;
            m3x = 460;
            m4x = 460;
            m5x = 460;
            m6x = 460;
            m1y = 381;
            m2y = 381;
            m3y = 315;
            m4y = 163;
            m5y = 110;
            m6y = 263;
            this.Size = new System.Drawing.Size(588, 450);
            this.Refresh();
            OnResize(EventArgs.Empty);
        }

        public string getElement(int atmno)
        {
            string s = "Error!";
            string[] elements;
            try
            {
                elements = File.ReadAllLines("Periodica Files\\ElementList.PeriodicaFiles");
                elements[atmno] = StrCipV1.Decrypt(elements[atmno], "Periodica");
                s = elements[atmno];
            }
            catch
            {
                Console.Write(" ");
            }
            return s;
        }
        Stream stream;
        public string getElementOnline(int atmno)
        {
            
            String content;
            try
            {
                WebClient client = new WebClient();
                stream = client.OpenRead("https://binarytek.000webhostapp.com/ApplicationData/Periodica/ElementList.txt");
            }
            catch
            { content = "Error"; }
            StreamReader reader = new StreamReader(stream);
            content = reader.ReadToEnd();
            string[] elements = content.Split( new[] { Environment.NewLine },
                                                    StringSplitOptions.None);
            return elements[atmno];
        }

        public void initialiseData(int atn, bool appM)
        {
            string elementContent = "Error!";
            
            string elementPath = "Periodica Files\\Elements\\" + atn.ToString() + ".PeriodicaElements";
            if (appM)
            {
                String content;
                this.Text = getElementOnline(atn - 1);
                try
                {
                    WebClient client = new WebClient();
                    string URL = "https://binarytek.000webhostapp.com/ApplicationData/Periodica/Elements/" + atmno + ".txt";
                    stream = client.OpenRead(URL);
                }
                catch { content = "Error!"; }
                StreamReader reader = new StreamReader(stream);
                content = reader.ReadToEnd();
                elementContent = content;
            }
            else
            {
                this.Text = getElement(atn - 1);
                try
                {
                    elementContent = File.ReadAllText(elementPath);
                    elementContent = StrCipV1.Decrypt(elementContent, "Periodica");
                }
                catch { Console.Write(" "); }
            }
            metroLabel2.Text = atn.ToString();
            richTextBox1.Text = elementContent;
            this.Refresh();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            atmno--;
            if (atmno >= 1)
                try
                {
                    initialiseData(atmno, appMode);
                }

                catch
                {
                    Console.Write("");
                }
            else
                atmno = 1;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            atmno++;
            if (atmno < 119)
                try
                {
                    initialiseData(atmno, appMode);
                }

                catch
                {
                    Console.Write("");
                }
            else
                atmno = 118;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            size -= 1;
            try
            {
                richTextBox1.Font = new System.Drawing.Font("Consolas", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            float size = richTextBox1.Font.Size;
            size += 1;
            try
            {
                richTextBox1.Font = new System.Drawing.Font("Consolas", size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void formResize(object sender, EventArgs e)
        {
            Size s = this.ClientSize;
            int Xchanged, Ychanged;
            Xchanged = 1*( s.Width - 588);
            Ychanged = 1*(s.Height - 450);
            
            richTextBox1.Size = new System.Drawing.Size(rtb.Width + Xchanged, rtb.Height + Ychanged);
            metroTile5.Location = new System.Drawing.Point(m5x + Xchanged, 110);
            metroTile4.Location = new System.Drawing.Point(m4x + Xchanged, 163);
            metroTile3.Location = new System.Drawing.Point(m3x + Xchanged, m3y + Ychanged);
            metroTile2.Location = new System.Drawing.Point(m2x + Xchanged, m2y + Ychanged);
            metroTile1.Location = new System.Drawing.Point(m1x + Xchanged, m1y + Ychanged);
            metroTile6.Location = new System.Drawing.Point(m6x + Xchanged, m6y + Ychanged);
           // label1.Text = Xchanged.ToString() + "|" + Convert.ToString(metroTile3.Location.X);// + Xchanged);
            //label2.Text = Ychanged.ToString() + "|" + Convert.ToString(metroTile3.Location.Y + Ychanged);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            if (!appMode)
            {
                EditCheck ee = new EditCheck(atmno);
                ee.Show();
                this.Hide();
            }
        }
    }
}
