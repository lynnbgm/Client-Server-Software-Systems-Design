using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    
    public void update_db (string candidate)
    {
        const string connString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security = True";
        SqlConnection conn = new SqlConnection(connString);
        conn.Open();
        SqlCommand cmd = new SqlCommand("UPDATE Votes SET count=count+1 WHERE name='"+candidate+"'", conn);
        cmd.ExecuteNonQuery();
        conn.Close();
    }
        
   
    protected void go_Click(object sender, EventArgs e)
    {
        // If no candidates selected, stay on same page
        if (Candidatelist.SelectedValue == "")
        {
            error.Visible = true;
            return;
        }
        error.Visible = false;
        update_db(Candidatelist.SelectedValue);
        Response.Redirect("Votes.aspx");
    }
}