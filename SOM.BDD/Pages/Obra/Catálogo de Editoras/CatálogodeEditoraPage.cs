using Framework.Core.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.Interfaces;
using Framework.Core.FrameworkActions;

namespace SOM.BDD.Pages.Obra.Catálogo_de_Editoras
{
    public class CatálogodeEditoraPage : PageBase
    {
        public CatálogodeEditoraPage(IBrowser browser, string catalogoEditorasUrl) : base(browser)
        {
            CatalogoEditorasUrl = catalogoEditorasUrl;

            InpBibliteca = Element.Css("input[id='arquivo']");
        }

        public string CatalogoEditorasUrl { get; private set; }
        public Element InpBibliteca { get; private set; }
        public CatálogodeEditoraPage TelaCatálogodeEditoraPage { get; private set; }

        public override void Navegar()
        {
            Browser.Abrir(CatalogoEditorasUrl);
        }

        public void SelecionarArquivo()
        {
            MouseActions.ClickATM(Browser, InpBibliteca);
        }


    }
}
