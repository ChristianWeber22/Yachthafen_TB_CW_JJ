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
    public partial class Buchung : Form
    {



        Controller controller = new Controller();

        List<Kunde> kundenListe = new List<Kunde>();
        List<LiegeplatzData> liegeplatzListe = new List<LiegeplatzData>();
        List<LiegeplatzData> liegeplatzListeForKunde = new List<LiegeplatzData>();
        List<LiegeplatzData> liegeplatzListeForKundeNotFree = new List<LiegeplatzData>();

        List<BuchungData> buchungsListe = new List<BuchungData>();

        DataTable kundenDaten;
        Kunde selectedKunde;

        bool checkIfTextReset = false;
        public Buchung()
        {
            InitializeComponent();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            DataTable dataTable = controller.showAllBuchungen();
            buchungTable.ReadOnly = true;
            buchungTable.DataSource = dataTable;

            buchungTable.Columns["id"].Visible = false;

            loadKundeDaten();
            loadBuchungenDaten();
            loadLiegeplatzDaten();

            comboBox2.Enabled = false;
            addNewRow.Enabled = false;
        }

        private void loadBuchungenDaten()
        {
            buchungsListe.Clear();

            DataTable buchungDaten = controller.getAllBuchungenForList();
            foreach (DataRow item in buchungDaten.Rows)
            {
                BuchungData buchung = new BuchungData((int)item[0], (int)item[1], (int)item[2], (DateTime)item[3], (DateTime)item[4], (double)item[5]);
                buchungsListe.Add(buchung);
            }
        }

        private void loadLiegeplatzDaten()
        {

            liegeplatzListe.Clear();

            //Liegeplätze laden 
            DataTable liegeplatzDaten = controller.showAllLiegeplatz();
            foreach (DataRow item in liegeplatzDaten.Rows)
            {
                LiegeplatzData liegeplatz = new LiegeplatzData(
                       (int)item[0],
                      item[1].ToString(),
                       (double)item[2],
                       (double)item[3],
                       (double)item[4],
                       (double)item[5]);

                liegeplatzListe.Add(liegeplatz);
            }

            comboBox1.DataSource = kundenDaten;

            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            comboBox1.Text = "";
        }

        private void loadKundeDaten()
        {
            kundenListe.Clear();
            kundenDaten = controller.showAllKunden();
            foreach (DataRow item in kundenDaten.Rows)
            {
                Kunde kunde = new Kunde(
                       (int)item[0],
                      item[1].ToString(),
                      item[2].ToString(),
                       item[3].ToString(),
                       (double)item[4],
                       (double)item[5],
                       (double)item[6]);
                kundenListe.Add(kunde);
            }
        }

        private void addNewRow_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            double tagespreis = 0;
            double endpreis;

            TimeSpan ts = endDate - startDate;
            int timespan = ts.Days + 1;
            if (ts.Days < 0)
            {
                MessageBox.Show("Das Startdatum darf nicht später als das Enddatum sein!");
                return;
            }

            string startDateString = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string endDateString = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            int selectedKunde = (int)comboBox1.SelectedValue;
            int selectedLiegeplatz = (int)comboBox2.SelectedValue;


            //Berechne Endpreis
            foreach (LiegeplatzData item in liegeplatzListe)
            {
                if (item.Id == (int)comboBox2.SelectedValue)
                {
                    tagespreis = item.Tagespreis;

                }
            }

            endpreis = tagespreis * timespan;

            bool check = controller.addNewBuchung(selectedKunde, selectedLiegeplatz, startDateString, endDateString, endpreis);

            if (check)
            {
                DataTable dataTable = controller.showAllBuchungen();
                loadKundeDaten();
                loadLiegeplatzDaten();
                comboBox2.DataSource = null;

                buchungTable.ReadOnly = true;
                buchungTable.DataSource = dataTable;

                new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Mitteilung")
                        .AddText("Die Buchung wurde erfolgreich angelegt!")
                        .Show();
            }

        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (this.buchungTable.SelectedRows.Count > 0 && this.buchungTable.SelectedRows[0].Index != this.buchungTable.Rows.Count - 1)
            {
                try
                {
                    DataGridViewRow row = this.buchungTable.SelectedRows[0];
                    controller.deleteSelectedBuchung((int)row.Cells["id"].Value);
                    string bezeichung = row.Cells["bezeichnung"].Value.ToString();
                    this.buchungTable.Rows.RemoveAt(this.buchungTable.SelectedRows[0].Index);
                    new ToastContentBuilder()
                        .AddArgument("action", "viewConversation")
                        .AddArgument("conversationId", 9813)
                        .AddText("Mitteilung")
                        .AddText("Die Buchung wurde erfolgreich entfernt!")
                        .Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }


        }




        private void form2_Resize(object sender, EventArgs e)
        {
            buchungTable.Size = ClientSize;
        }






  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addNewRow.Enabled = false;
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;



            if (comboBox1.Text != "" && comboBox1.SelectedValue.ToString().All(char.IsDigit))
            {
                comboBox2.Enabled = true;
                liegeplatzListeForKunde.Clear();
                liegeplatzListeForKundeNotFree.Clear();


                selectedKunde = new Kunde();


                string selectedKundeId = comboBox1.SelectedValue.ToString();

                foreach (Kunde item in kundenListe)
                {
                    if (item.Id == Int32.Parse(selectedKundeId))
                    {
                        selectedKunde = item;
                        break;
                    }
                }






                foreach (LiegeplatzData item in liegeplatzListe)
                {
                    if (item.Laenge > selectedKunde.Yachtlaenge && item.Breite > selectedKunde.Yachtbreite && item.Tiefe > selectedKunde.Yachttiefe)
                    {
                        liegeplatzListeForKunde.Add(item);
                    }

                }




                foreach (LiegeplatzData liegeplatz in liegeplatzListeForKunde)
                {
                    foreach (BuchungData item in buchungsListe)
                    {
                        if (liegeplatz.Id == item.IdLiegeplatz)
                        {
                            if (CheckOverlap(startDate, endDate, item.Startdatum, item.Enddatum))
                            {
                                liegeplatzListeForKundeNotFree.Add(liegeplatz);

                            }
                        }

                    }

                }

                liegeplatzListeForKunde.RemoveAll(x => liegeplatzListeForKundeNotFree.Contains(x));


                comboBox2.Text = "";
                comboBox2.DataSource = null;
                comboBox2.DataSource = liegeplatzListeForKunde;
                comboBox2.DisplayMember = "bezeichnung";
                comboBox2.ValueMember = "id";

                resetTagspreisText();
                resetGesamtPreis();

            }
        }



        private bool CheckOverlap(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            if (end1 < start2 || end2 < start1)
            {
                return false;
            }

            if (start1 == start2 || end1 == end2 || start1 == end2 || end1 == start2)
            {
                return true;
            }

            return true;
        }


        private void setTagespreisText(double tagespreis)
        {

            tagespreisText.Text = tagespreis.ToString() + "€";


        }

        private void resetTagspreisText()
        {
            tagespreisText.Text = "";
        }

        private void resetGesamtPreis()
        {
            gesamtpreisText.Text = "";
            checkIfTextReset = true;

        }

        private void setGesamtPreis(double tagespreis)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            TimeSpan ts = endDate - startDate;
            int timespan = ts.Days + 1;
            double gesamtpreis = timespan * tagespreis;

            if (gesamtpreis > 0)
            {
                gesamtpreisText.Text = gesamtpreis.ToString() + "€";
            }
            else
            {
                gesamtpreisText.Text = "Ungültiges Datum!";
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox2.SelectedValue.ToString().All(char.IsDigit) && checkIfTextReset)
            {
                double tagespreis = 0;

                foreach (LiegeplatzData item in liegeplatzListe)
                {
                    if (item.Id == (int)comboBox2.SelectedValue)
                    {
                        tagespreis = item.Tagespreis;

                    }
                }

                setTagespreisText(tagespreis);
                setGesamtPreis(tagespreis);
                checkIfTextReset = false;
                addNewRow.Enabled = true;
                return;
            }



        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            resetTagspreisText();
            resetGesamtPreis();
            comboBox2.DataSource = null;
            addNewRow.Enabled = false;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            resetTagspreisText();
            resetGesamtPreis();
            comboBox2.DataSource = null;
            addNewRow.Enabled = false;

        }


    }


}

