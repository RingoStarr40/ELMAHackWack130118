using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Mvc.ExtensionPoints.ActionItems;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Toolbar;
using EleWise.ELMA.Web.Mvc.Models.ActionItems.Toolbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EleWise.ELMA.Blockchain.Web.Components
{
    [Component]
    public class BlockchainTransferToolbarButton : IActionItemProvider
    {
        public void InsertItems(IActionItem rootItem, HtmlHelper htmlHelper)
        {
            if (rootItem == null) return;
            if (rootItem.Uid != ToolbarBuilder.DefaultActionsToolbarUid) return;

            var group = rootItem.Items.FirstOrDefault(item => item != null && item.Uid == "HomePageToolbarGroup") as ActionToolbarGroup;

            if (group != null)
            {
               GetItems(rootItem, htmlHelper).ForEach(item => group.Items.Add(item));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootItem"></param>
        /// <param name="htmlHelper"></param>
        /// <returns></returns>
        public IEnumerable<IActionItem> GetItems(IActionItem rootItem, HtmlHelper htmlHelper)
        {
            if (rootItem == null) yield break;
            if (rootItem.Uid != ToolbarBuilder.DefaultActionsToolbarUid) yield break;
            if (!rootItem.Items.Any(item => item is ActionToolbarGroup && item.Uid == "HomePageToolbarGroup")) yield break;

            yield return new ActionToolbarItem
            {
                Url = htmlHelper.Url().Action("Index", "Home", new { area = RouteProvider.AreaName }),
                Text = SR.T("Перевод")
            };
        }        

    }
}
