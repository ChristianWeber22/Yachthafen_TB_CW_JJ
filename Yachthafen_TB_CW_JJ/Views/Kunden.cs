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
    public partial class Kunden : Form
    {

        Controller controller = new Controller();

    

        public Kunden()
        {
            InitializeComponent();
            DataTable dataTable = controller.showAllKunden();
            kundenTable.DataSource = dataTable;
            kundenTable.Columns["id"].Visible = false;
        }

        private void form4_Load(object sender, EventArgs e)
        {

        }        

        private void addNewRow_Click(object sender, EventArgs e)
        {
            this.kundenTable.Rows.Add();
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (this.kundenTable.SelectedRows.Count > 0 && this.kundenTable.SelectedRows[0].Index != this.kundenTable.Rows.Count - 1)
            {
                this.kundenTable.Rows.RemoveAt(this.kundenTable.SelectedRows[0].Index);
            }
        }

        private void PopulateDataGridView()
        {

  

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void form2_Resize(object sender, EventArgs e)
        {
            kundenTable.Size = ClientSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = (DataTable)(kundenTable.DataSource);

                controller.UpdateAllKunden(data);
                kundenTable.Columns["id"].Visible = false;
                new ToastContentBuilder()
    .AddArgument("action", "viewConversation")
    .AddArgument("conversationId", 9813)
    .AddText("Mitteilung")
    .AddText("Der Kunde wurde erfolgreich gespeichert!")
    .Show(); 

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                
            }
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kundenTable.SelectedRows.Count > 0 && !kundenTable.SelectedRows[0].IsNewRow)
            {
                kundenTable.Rows.Remove(kundenTable.SelectedRows[0]);


            }
            else
            {
                MessageBox.Show("Kein Kunden ausgewählt!");

            }
        }

      


    }
}
