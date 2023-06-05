namespace Shoolese.Organisation.Fitness.Client.Pages.Sub_Form_Pages
{
    public partial class ConfigControl : UserControl
    {
        public ConfigControl()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var dateOfBirth = dob_set.Value;
        }
    }
}
