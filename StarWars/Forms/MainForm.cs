using StarWars.Classes;
using StarWars.Classes.Solders;
using StarWars.Pattern.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarWars.Forms
{
    public partial class MainForm : BaseForm
    {
        //private Singleton SingleClient = Singleton.GetSingleton();

        public MainForm()
        {
            InitializeComponent();
            Singleton.GetSingleton().Client = new Client();
            listSolders.DataSource = Singleton.GetSingleton().Client.SoldersList;
            listSolders.DisplayMember = "UnitСode";

        }

        private void buttonCreateAssault_Click(object sender, EventArgs e)
        {
            Singleton.GetSingleton().Client.CreateAssault();
            UpdateForm();
        }

        private void buttonCreateGunner_Click(object sender, EventArgs e)
        {
            Singleton.GetSingleton().Client.CreateGunner();
            UpdateForm();
        }

        private void buttonCreateRecon_Click(object sender, EventArgs e)
        {
            Singleton.GetSingleton().Client.CreateRecon();
            UpdateForm();
        }

        private void buttonCreateSniper_Click(object sender, EventArgs e)
        {
            Singleton.GetSingleton().Client.CreateSniper();
            UpdateForm();
        }

        private void UpdateForm()
        {
            listSolders.DataSource = null;
            listSolders.DataSource = Singleton.GetSingleton().Client.SoldersList;
            listSolders.DisplayMember = "UnitСode";
        }

        private void buttonShowSolderStats_Click(object sender, EventArgs e)
        {
            if (Singleton.GetSingleton().CurrentSolder != null)
                this.ShowNextForm(new SolderInfoForm());
            else
                MessageBox.Show("Для начала нужно выбрать солдата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void listSolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            Singleton.GetSingleton().CurrentSolder = listSolders.SelectedItem as AbstractSolder;
        }

        private void buttonShowSelectedSolderMessage_Click(object sender, EventArgs e)
        {
            if (Singleton.GetSingleton().CurrentSolder != null)
                MessageBox.Show(Singleton.GetSingleton().CurrentSolder.Message(), "Доклад по бойцу " + Singleton.GetSingleton().CurrentSolder.UnitСode);
            else
                MessageBox.Show("Для начала нужно выбрать солдата", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
