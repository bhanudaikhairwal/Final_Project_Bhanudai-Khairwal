using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Diagnostics;

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
                searchkey = pages_search_textbox.Text;
            }


            string query = "select * from pages";

            if (searchkey != "")
            {
                query += " WHERE pagetitle like '%" + searchkey + "%' ";
                query += " or pagebody like '%" + searchkey + "%' ";
            }
            sql_debugger.InnerHtml = query;


            var db = new MYPAGES();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                pages_result.InnerHtml += "<div class=\"listitem\">";

                string pageid = row["pageid"];

                string pagetitle = row["pagetitle"];
                pages_result.InnerHtml += "<div class=\"col4\">" + pagetitle + "</div>";

                string pagebody = row["pagebody"];
                pages_result.InnerHtml += "<div class=\"col4\">" + pagebody + "</div>";

                pages_result.InnerHtml += "<div class=\"col4last\"><a href=\"ShowPage.aspx?pageid=" + pageid + "\">View Details</a></div>";

                pages_result.InnerHtml += "</div>";
            }
        }
    }
}