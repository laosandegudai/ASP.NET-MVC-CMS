/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Easy.Data;
using Easy.Extend;
using Easy.Web.CMS.Widget;
using System.Web.Routing;

namespace Easy.Web.CMS
{
    public static class RouteDataExtend
    {
        public static string GetPath(this RouteData roteData)
        {
            if (roteData.Values.ContainsKey(StringKeys.RouteValue_Path))
            {
                return "/" + roteData.Values[StringKeys.RouteValue_Path].ToString();
            }
            return "/";
        }
        public static int GetPost(this RouteData roteData)
        {
            int post = 0;
            if (roteData.Values.ContainsKey(StringKeys.RouteValue_Post))
            {
                int.TryParse(roteData.Values[StringKeys.RouteValue_Post].ToString(), out post);
            }
            return post;
        }
        public static int GetCategory(this RouteData roteData)
        {
            int post = 0;
            if (roteData.Values.ContainsKey(StringKeys.RouteValue_Category))
            {
                int.TryParse(roteData.Values[StringKeys.RouteValue_Category].ToString(), out post);
            }
            return post;
        }
        public static int GetPage(this RouteData roteData)
        {
            int page = 0;
            if (roteData.Values.ContainsKey(StringKeys.RouteValue_Page))
            {
                int.TryParse(roteData.Values[StringKeys.RouteValue_Page].ToString(), out page);
            }
            return page;
        }
    }
}
