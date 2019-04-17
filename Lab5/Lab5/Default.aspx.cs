using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Converting to USD
    protected void ToUSD_Click(object sender, EventArgs e)
    {
        errorcode.Visible = false;
        errorcode.Text = "Invalid Input: ";
        //Checks for invalid input values
        decimal input;
        try
        {
            input = Convert.ToDecimal(Userinput.Text);
        }
        catch (System.FormatException)
        {
            errorcode.Text += "Input must be a number.";
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }

        catch (System.OverflowException)
        {
            errorcode.Text += "The number is too large.";
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }
        //Checks if a currency exchange value is selected
        decimal curr_rate;
        string curr_name;
        try
        {
            curr_rate = Convert.ToDecimal(ExchangeDisplay.SelectedValue);
            curr_name = Convert.ToString(ExchangeDisplay.SelectedItem);
        }
        catch (System.FormatException)
        {
            errorcode.Text += "A currency must be selected.";
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }
        
        curr_rate = 1 / curr_rate;
        decimal USDval = curr_rate * input;
        Output.Text = USDval.ToString();
        OutputMsg.Text = curr_name + " -> USD";
        Userinput.Text = "";
    }
    //Converting from USD
    protected void FromUSD_Click(object sender, EventArgs e)
    {
        errorcode.Visible = false;
        errorcode.Text = "Invalid Input: ";
        decimal input;
        //Checks for invalid input values
        try
        {
            input = Convert.ToDecimal(Userinput.Text);
        }

        catch (System.FormatException)
        {
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }

        catch (System.OverflowException)
        {
            errorcode.Text += "The number is too large.";
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }
        //Checks if a currency exchange value is selected
        decimal curr_rate;
        string curr_name;
        try
        {
            curr_rate = Convert.ToDecimal(ExchangeDisplay.SelectedValue);
            curr_name = Convert.ToString(ExchangeDisplay.SelectedItem);
        }
        catch (System.FormatException)
        {
            errorcode.Text += "A currency must be selected.";
            errorcode.Visible = true;
            Userinput.Text = "";
            Output.Text = "Not available.";
            return;
        }
        decimal USDval = curr_rate * input;
        Output.Text = USDval.ToString();
        OutputMsg.Text = "USD ->" + curr_name;
        Userinput.Text = "";
    }
}