using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class Votes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Shows the table and stuff
        DataView dv = (DataView)CandidateData.Select(DataSourceSelectArguments.Empty);
        //Adding the header row
        TableHeaderRow header = new TableHeaderRow();
        TableCell h1 = new TableCell();
        h1.Text = "Candidate";
        TableCell h2 = new TableCell();
        h2.Text = "Votes";
        TableCell h3 = new TableCell();
        h3.Text = "Percentage";
        header.Cells.Add(h1);
        header.Cells.Add(h2);
        header.Cells.Add(h3);
        result_display.Rows.Add(header);

        decimal total_votes = 0;
        foreach (DataRow dr in dv.Table.Rows)
        {
            string num_votes = dr["count"].ToString();
            total_votes += Convert.ToDecimal(num_votes);
        }
        //Calculates percentages
        foreach (DataRow dr in dv.Table.Rows)
        {
            TableRow new_schema = new TableRow();
            TableCell name = new TableCell();
            TableCell numvote = new TableCell();
            TableCell percentage = new TableCell();

            name.BorderWidth = 2;
            name.BorderColor = Color.Black;
            name.Width = 100;
            name.Height = 50;

            numvote.BorderWidth = 2;
            numvote.BorderColor = Color.Black;
            numvote.Width = 50;
            numvote.Height = 50;

            percentage.BorderWidth = 2;
            percentage.BorderColor = Color.Black;
            percentage.Width = 100;
            percentage.Height = 50;

            
            int votes = Convert.ToInt16(dr["count"].ToString());
            decimal percent;
            try
            {
                percent = (votes / total_votes) * 100;
            }
            catch (System.DivideByZeroException)
            {
                percent = 0;
            }
            percentage.Text = percent.ToString("0.00")+" %";
            name.Text = dr["name"].ToString();
            numvote.Text = votes.ToString();

            new_schema.Cells.Add(name);
            new_schema.Cells.Add(numvote);
            new_schema.Cells.Add(percentage);
            result_display.Rows.Add(new_schema);

        }
    }
}