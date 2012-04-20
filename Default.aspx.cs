using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hr_redirector
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string page = "";
            bool paramAdded = false;
            
            string classId = Request.QueryString["class"];
            string month = Request.QueryString["month"];
            string year = Request.QueryString["year"];

            string url = Global.RedirectSiteRoot + page;
            if (!string.IsNullOrWhiteSpace(classId))
            {
                if (paramAdded)
                {
                    url += "&";
                }
                else
                {
                    url += "?";
                }
                paramAdded = true;
                url += "class=" + classId.ToString();
            }
            if (!string.IsNullOrWhiteSpace(month))
            {
                if (paramAdded)
                {
                    url += "&";
                }
                else
                {
                    url += "?";
                }
                paramAdded = true;
                url += "month=" + month.ToString();
            }
            if (!string.IsNullOrWhiteSpace(year))
            {
                if (paramAdded)
                {
                    url += "&";
                }
                else
                {
                    url += "?";
                }
                paramAdded = true;
                url += "year=" + year.ToString();
            }
            Response.Redirect(url);
        }
    }
}