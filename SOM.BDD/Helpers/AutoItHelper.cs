using System.Threading;

namespace SOM.BDD.Helpers
{
    public class AutoItHelper
    {
        public static void LoginWindows()
        {
            //Populate data in collection
            //ExcelUtil.PopulateInCollection(GetPath.GetResourcePath("login.xlsx"), "Planilha1");

            //AutoIt.AutoItX.WinActivate("Authentication Required");
            //Thread.Sleep(2000);
            //AutoIt.AutoItX.Send($"{ExcelUtil.ReadData(1, "UserName")}");
            //AutoIt.AutoItX.Send("{TAB}");
            //AutoIt.AutoItX.Send($"{ExcelUtil.ReadData(1, "Password")}");
            //AutoIt.AutoItX.Send("{ENTER}");
            //Thread.Sleep(4000);

            AutoIt.AutoItX.WinActivate("Authentication Required");
            Thread.Sleep(2000);
            AutoIt.AutoItX.Send("rmagno");
            AutoIt.AutoItX.Send("{TAB}");
            AutoIt.AutoItX.Send("Glob0{!}{!}2018");
            AutoIt.AutoItX.Send("{ENTER}");
            Thread.Sleep(4000);
        }
    }
}