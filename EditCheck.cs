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
    public partial class EditCheck : MetroFramework.Forms.MetroForm
    {
        int atmno;
        public EditCheck(int ano)
        {
            InitializeComponent();
            atmno = ano;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            if(metroTextBox1.Text == "Periodica v12.1")
            {
                EditData ee = new EditData(atmno);
                ee.Show();
                this.Hide();
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
