using Framework.Core.PageObjects;
using System.Threading;
using Framework.Core.Interfaces;
using System;
using SOM.BDD.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SOM.BDD.Pages
{
    public class LoginPage : PageBase
    {
        //private string Url { get; }
        private string HomeUrl { get; }

        public LoginPage(IBrowser browser, string homeUrl) : base(browser)
        {
            //Url = url;
            HomeUrl = homeUrl;
        }

        private string PageTitle => "SOM | Obras";

        public void Login()
        {
            Thread.Sleep(1500);
            AutoItHelper.LoginWindows();
        }

        public void ValidarLogin()
        {
            try
            {
                Thread.Sleep(1500);
                Assert.IsTrue(Browser.PageSource(PageTitle));
            }
            catch
            {
                Thread.Sleep(1500);
                Assert.IsTrue(Browser.PageSource(PageTitle));
            }
        }

        public void LogarNoSistema()
        {
            try
            {
                Navegar();
                Assert.IsTrue(Browser.PageSource(PageTitle));
            }
            catch
            {
                Login();
                ValidarLogin();
            }
        }

        public override void Navegar()
        {
            Browser.Abrir(HomeUrl);
        }
    }
}
