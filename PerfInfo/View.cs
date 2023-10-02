using System.Windows.Forms;
using PresenterSpace;

namespace ViewSpace
{
    public partial class ViewForm : Form
    {
        public Presenter presenter;

        public ViewForm() { InitializeComponent(); }

        private void Update_Click(object sender, System.EventArgs e) { presenter.Load(); }

        private void PingButton_Click(object sender, System.EventArgs e) { presenter.Ping(); }
    }
}