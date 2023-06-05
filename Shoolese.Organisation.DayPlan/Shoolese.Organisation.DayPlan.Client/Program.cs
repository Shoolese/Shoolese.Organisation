using Microsoft.Extensions.DependencyInjection;
using Shoolese.Organisation.DayPlan.Core.DataServices;
using Shoolese.Organisation.DayPlan.Domain.DataServices;
using System.Globalization;

namespace Shoolese.Organisation.DayPlan.Client
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());


            var culture = new CultureInfo("en-GB");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;


            using ServiceProvider serviceProvider = IoC.Base.IoC.SetUpServices(SetupServices);
            Application.Run(
                new Home()
            );
        }

        private static Action<IServiceCollection> SetupServices = (svc) =>
        {
            svc.AddSingleton<IManageHighLevelTasksService, ManageHighLevelTasksService>();
        };
    }
}