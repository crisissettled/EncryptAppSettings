using System;
using System.Configuration;

namespace EncryptAppSettings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings["ApiUser"];

            string password = ConfigurationManager.AppSettings["ApiPassword"];

            lblAppSettingValue.Text = $"{username} - {password}";


            string connectionString = ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString;

            Label11.Text = connectionString;

        }
    }
}