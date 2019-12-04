using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Final_Project
{
    public partial class listpages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            pages_result.InnerHtml = "";

            string searchkey = "";
            if (Page.IsPostBack)
            {
                searchkey = pages_search_textbox.Text.ToString();
            }


            string query = "select * from mypages";

            if (searchkey != "")
            {
                query += " WHERE mypagetitle like '%" + searchkey + "%' ";
                query += " or mypagebody like '%" + searchkey + "%' ";
            }
            sql_debugger.InnerHtml = query;


            var db = new MYPAGES();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                pages_result.InnerHtml += "<div class=\"listitem\">";

                string pageid = row["mypageid"];

                string pagetitle = row["mypagetitle"];
                pages_result.InnerHtml += "<div class=\"col4\"><a href=\"ShowPages.aspx?mypageid=" + pageid + "\">" + pagetitle + "</a></div>";

                string pagebody = row["mypagebody"];
                pages_result.InnerHtml += "<div class=\"col4\">" + pagebody + "</div>";

                pages_result.InnerHtml += "<div class=\"col4last\"><a href=\"ShowPages.aspx?studentid=" + pageid + "\">View Details</a></div>";

                pages_result.InnerHtml += "</div>";
            }
        }
    }
}