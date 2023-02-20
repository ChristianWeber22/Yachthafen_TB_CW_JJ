using Microsoft.Toolkit.Uwp.Notifications;
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
    public partial class Liegeplatzverwaltung : Form
    {
        Controller controller = new Controller();



        private string besitzer;
        private string bezeichnung;
        private string laenge;
        private string breite;
        private string tiefe;
        private string verfuegbarkeit;

        public Liegeplatzverwaltung()
        {
            

            InitializeComponent();
            DataTable dataTable = controller.showAllLiegeplatz();
            liegeplatzTable.DataSource = dataTable;
            liegeplatzTable.Columns["id"].Visible = false;

        }

        private void addNewRow_Click(object sender, EventArgs e)
        {
            this.liegeplatzTable.Rows.Add(besitzer, bezeichnung, laenge, breite, tiefe, verfuegbarkeit);
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (this.liegeplatzTable.SelectedRows.Count > 0 && this.liegeplatzTable.SelectedRows[0].Index != this.liegeplatzTable.Rows.Count - 1)
            {
                this.liegeplatzTable.Rows.RemoveAt(this.liegeplatzTable.SelectedRows[0].Index);
            }
        }


        private void PopulateDataGridView()
        {

            string[] row = { besitzer, bezeichnung, laenge, breite, tiefe, verfuegbarkeit};


            liegeplatzTable.Columns.Add("column1", "Besitzer");
            liegeplatzTable.Columns.Add("column2", "Yachtbezeichnung");
            liegeplatzTable.Columns.Add("column3", "Länge");
            liegeplatzTable.Columns.Add("column4", "Breite");
            liegeplatzTable.Columns.Add("column5", "Wassertiefe");
            liegeplatzTable.Columns.Add("column6", "Verfügbarkeit");

            liegeplatzTable.Rows.Add(row);

            liegeplatzTable.Columns[0].DisplayIndex = 0; // Besitzer
            liegeplatzTable.Columns[1].DisplayIndex = 1; // Yachtbezeichnung
            liegeplatzTable.Columns[2].DisplayIndex = 2; // Länge
            liegeplatzTable.Columns[3].DisplayIndex = 3; // Breite
            liegeplatzTable.Columns[4].DisplayIndex = 4; // Wassertiefe
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }

        




        private void form2_Resize(object sender, EventArgs e)
        {
            liegeplatzTable.Size = ClientSize;            
        }


        


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(liegeplatzTable.DataSource);

            controller.UpdateAllLiegeplatz(data);
            liegeplatzTable.Columns["id"].Visible = false;

            new ToastContentBuilder()
             .AddArgument("action", "viewConversation")
             .AddArgument("conversationId", 9813)
             .AddText("Mitteilung")
             .AddText("Der Liegeplatz wurde erfolgreich angelegt!")
             .Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.showAllLiegeplatzWhereFrei();

            liegeplatzTable.DataSource = dataTable;
            liegeplatzTable.Columns["id"].Visible = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dataTable = controller.showAllLiegeplatz();
            liegeplatzTable.DataSource = dataTable;
            liegeplatzTable.Columns["id"].Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (liegeplatzTable.SelectedRows.Count > 0 && !liegeplatzTable.SelectedRows[0].IsNewRow)
    {
                liegeplatzTable.Rows.Remove(liegeplatzTable.SelectedRows[0]);

              
            } else
            {
                MessageBox.Show("Kein Liegeplatz ausgewählt!");

            }

        }

        private void liegeplatzTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void liegeplatzTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
       
        }
    }
}
