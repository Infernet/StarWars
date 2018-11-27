using System.Windows.Forms;

namespace StarWars.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ShowNextForm(BaseForm nextForm)
        {
            nextForm.StartPosition = FormStartPosition.Manual;
            nextForm.Location = this.Location;

            this.Hide();
            nextForm.ShowDialog();
            this.Show();
        }
    }
}
