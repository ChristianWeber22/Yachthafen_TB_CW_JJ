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

    }
}
