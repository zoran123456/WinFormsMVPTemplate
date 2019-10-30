using System.Windows.Forms;
using WinFormsMVPTemplate.Infrastructure;
using WinFormsMVPTemplate.Presenters;
using WinFormsMVPTemplate.Views;

namespace WinFormsMVPTemplate
{

    public partial class MainForm : FormPresenter<MainFormPresenter>, IMainFormView
    {
        private MainFormPresenter presenter;

        public MainForm()
        {
            InitializeComponent();

            presenter = this.Presenter;
        }


        #region Interface Implementation

        public string SomeTextValue
        {
            get
            {
                return tbName.Text;
            }
            set
            {
                tbName.Text = value;
            }
        }

        public void SaveChangesComplete()
        {
            MessageBox.Show("Changes saved!");
        }


        #endregion


        private void btnChangeCase_Click(object sender, System.EventArgs e)
        {
            presenter.ChangeCase();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            presenter.SaveChanges();
        }

    }
}
