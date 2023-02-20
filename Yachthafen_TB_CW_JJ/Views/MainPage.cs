using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yachthafen_TB_CW_JJ
{
    public partial class MainPage : Form
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void liegeplatzButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            Liegeplatzverwaltung form2 = new Liegeplatzverwaltung() { TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
           
            panel1.Controls.Add(form2);

           
            form2.Show();            
        }

        private void buchungButton_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
            Buchung form3 = new Buchung() { TopLevel = false, TopMost = true };
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;

            panel1.Controls.Add(form3);

            form3.Show();
        }

        private void kundenButton_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();

            Kunden form4 = new Kunden() { TopLevel = false, TopMost = true };
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;

            panel1.Controls.Add(form4);

            form4.Show();
        }


    }
}
