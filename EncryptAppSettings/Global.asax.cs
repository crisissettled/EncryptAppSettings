using System;
using System.Configuration;
using System.Web.Configuration;

namespace EncryptAppSettings
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Configuration config = WebConfigurationManager.OpenWebConfiguration("~");

            ConfigurationSection sectionAppSettings = config.GetSection("appSettings");

            if (!sectionAppSettings.SectionInformation.IsProtected)
            {
                sectionAppSettings.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

                sectionAppSettings.SectionInformation.ForceSave = true;

                config.Save(ConfigurationSaveMode.Modified);
            }


            ConfigurationSection sectionConnectionString = config.GetSection("connectionStrings");

            if (!sectionConnectionString.SectionInformation.IsProtected)
            {
                sectionConnectionString.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");

                sectionConnectionString.SectionInformation.ForceSave = true;

                config.Save(ConfigurationSaveMode.Modified);
            }



        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}