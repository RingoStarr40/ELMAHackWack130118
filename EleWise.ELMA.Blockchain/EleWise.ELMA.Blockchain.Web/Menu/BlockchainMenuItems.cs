using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Content.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Blockchain.Web.Menu
{
    [Component]
    public class BlockchainMenuItems : IMenuItemsProvider
    {
        public const string Blockchain = "Blockchain";

        public void Items(MenuItemFactory factory)
        {
            factory.Action(new ActionRoute("Index", "Home", new { area = RouteProvider.AreaName }))
                .Image32(RouteProvider.ImagesFolder + "x32/leftmenu.png")
                .Order(150)
                .Code("Blockchain_Menu")
                .OnTop(true)
                .Stretch(true)
                .Container("left")
                .Copy(b => b.Container("top"));
        }
        
        public List<string> LocalizedItemsNames
        {
            get
            {
                return new List<string> {
                    SR.T("Блокчейн")
                };
            }
        }

        public List<string> LocalizedItemsDescriptions
        {
            get { return null; }
        }

    }
}
