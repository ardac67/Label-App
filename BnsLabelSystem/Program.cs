using DevExpress.XtraReports.Security;

namespace BnsLabelSystem
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
            Application.Run(new MainForm());
            //DevExpress.Security.Resources.AccessSettings.ReportingSpecificResources.SetRules(SerializationFormatRule.Allow(DevExpress.XtraReports.UI.SerializationFormat.Code, DevExpress.XtraReports.UI.SerializationFormat.Xml));
        }
    }
}