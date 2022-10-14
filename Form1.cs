using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Shop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void openchild(Panel pen, Form empryF)
        {
            empryF.TopLevel = false;
            empryF.FormBorderStyle = FormBorderStyle.None;
            empryF.Dock = DockStyle.Fill;
            pen.Controls.Add(empryF);
            empryF.BringToFront();
            empryF.Show();
        }

        private void button_Clothing_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormClothing());
        }

        private void button_Workers_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormWorkers());
        }

        private void button_Positions_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormPositions());
        }

        private void button_Orders_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormOrders());
        }

        private void button_Cort_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormCort());
        }

        private void button_Types_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormTypes());
        }

        private void button_Seasons_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormSeasons());
        }

        private void button_Sex_Click(object sender, EventArgs e)
        {
            openchild(panel2, new FormSex());
        }
    }
}
