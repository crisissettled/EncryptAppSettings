using System;
using System.Configuration;

namespace EncryptAppSettings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           lblAppSettingValue.Text =  ConfigurationManager.AppSettings["clientSecret"];

        }
    }
}