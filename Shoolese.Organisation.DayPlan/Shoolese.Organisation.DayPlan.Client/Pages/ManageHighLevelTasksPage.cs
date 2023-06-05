using Shoolese.Organisation.DayPlan.Domain.DataServices;

namespace Shoolese.Organisation.DayPlan.Client.Pages
{
    public partial class ManageHighLevelTasksPage : UserControl
    {
        private IManageHighLevelTasksService _manageHighLevelTasksService;

        public ManageHighLevelTasksPage()
        {
            InitializeComponent();
            _manageHighLevelTasksService = IoC.Base.IoC.Resolve<IManageHighLevelTasksService>();
        }
    }
}
