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


        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursor = Cursor.Position;
            lastForm = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int xDiff = lastCursor.X - Cursor.Position.X;
                int yDiff = lastCursor.Y - Cursor.Position.Y;
                this.Location = new Point(lastForm.X - xDiff, lastForm.Y - yDiff);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ControlBox = false;

            label1.MouseDown += new MouseEventHandler(panel1_MouseDown);
            label1.MouseMove += new MouseEventHandler(panel1_MouseMove);
            label1.MouseUp += new MouseEventHandler(panel1_MouseUp);
            label1.BringToFront();



        }

        private void liegeplatzButton_Click(object sender, EventArgs e)
        {
            liegeplatzButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#494c72");
            buchungButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");
            kundenButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");

            panel1.Controls.Clear();

            Liegeplatzverwaltung form2 = new Liegeplatzverwaltung() { TopLevel = false, TopMost = true };
            form2.FormBorderStyle = FormBorderStyle.None;
            form2.Dock = DockStyle.Fill;
           
            panel1.Controls.Add(form2);

           
            form2.Show();            
        }

        private void buchungButton_Click(object sender, EventArgs e)
        {
            liegeplatzButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");
            buchungButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#494c72");
            kundenButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");
            panel1.Controls.Clear();
            
            Buchung form3 = new Buchung() { TopLevel = false, TopMost = true };
            form3.FormBorderStyle = FormBorderStyle.None;
            form3.Dock = DockStyle.Fill;

            panel1.Controls.Add(form3);

            form3.Show();
        }

        private void kundenButton_Click(object sender, EventArgs e)
        {
            liegeplatzButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");
            buchungButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#001928");
            kundenButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#494c72");
            panel1.Controls.Clear();

            Kunden form4 = new Kunden() { TopLevel = false, TopMost = true };
            form4.FormBorderStyle = FormBorderStyle.None;
            form4.Dock = DockStyle.Fill;

            panel1.Controls.Add(form4);

            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
