namespace Shoolese.Organisation.Fitness.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_show_config_Click(object sender, EventArgs e) => FormLauncher.Config();   
    }
}