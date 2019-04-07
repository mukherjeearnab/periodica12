using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Periodica_v12o1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool OnlineMode;
        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (metroToggle1.Checked == true)
                OnlineMode = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Table t = new Table(OnlineMode);
            t.Show();
            this.Hide();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
