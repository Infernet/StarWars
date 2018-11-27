using StarWars.Classes.Solders;
using StarWars.Pattern.Singleton;
using System;
using System.Windows.Forms;

namespace StarWars.Forms
{
    public partial class MainForm : BaseForm
    {

        public MainForm()
        {
            InitializeComponent();
            listSolders.DataSource = Client.GetInstance().SoldersList;
            listSolders.DisplayMember = "UnitСode";

        }

        private void buttonCreateAssault_Click(object sender, EventArgs e)
        {
            Client.GetInstance().CreateAssault();
            UpdateForm();
        }

        private void buttonCreateGunner_Click(object sender, EventArgs e)
        {
            Client.GetInstance().CreateGunner();
            UpdateForm();
        }

        private void buttonCreateRecon_Click(object sender, EventArgs e)
        {
            Client.GetInstance().CreateRecon();
            UpdateForm();
        }

        private void buttonCreateSniper_Click(object sender, EventArgs e)
        {
            Client.GetInstance().CreateSniper();
            UpdateForm();
        }

        private void UpdateForm()
        {
            listSolders.DataSource = null;
            listSolders.DataSource = Client.GetInstance().SoldersList;
            listSolders.DisplayMember = "UnitСode";
        }

        private void buttonShowSolderStats_Click(object sender, EventArgs e)
        {
            if (Client.GetInstance().CurrentSolder != null)
                this.ShowNextForm(new SolderInfoForm());
            else
                MessageBox.Show("Для начала нужно выбрать солдата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listSolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client.GetInstance().CurrentSolder = listSolders.SelectedItem as AbstractSolder;
        }

        private void buttonShowSelectedSolderMessage_Click(object sender, EventArgs e)
        {
            if (Client.GetInstance().CurrentSolder != null)
                MessageBox.Show(Client.GetInstance().CurrentSolder.Message(), "Доклад по бойцу " + Client.GetInstance().CurrentSolder.UnitСode);
            else
                MessageBox.Show("Для начала нужно выбрать солдата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonDeleteSolder_Click(object sender, EventArgs e)
        {
            if (Client.GetInstance().CurrentSolder != null)
            {
                Client.GetInstance().SoldersList.Remove(Client.GetInstance().CurrentSolder);
                Client.GetInstance().CurrentSolder = null;
                UpdateForm();
            }
            else
                MessageBox.Show("Для начала нужно выбрать солдата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
