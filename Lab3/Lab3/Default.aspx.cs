using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public static double sum;
    public static bool sum_valid = true;
    public static string invalid_output;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void enter_Click(object sender, EventArgs e)
    {
        double input;
        error.Visible = false;
        try
        {
            input = double.Parse(in_text.Text);
        }
        catch (System.FormatException)
        {
            error.Text = "Invalid or missing value!";
            error.Visible = true;
            return;
        }
        catch (System.OverflowException)
        {
            error.Text = "Invalid or missing value!";
            error.Visible = true;
            return;
        }
        sum_valid = true;
        in_text.Text = "";
        sum = input;
        out_text.Text = Convert.ToString(sum);  
    }

    protected void add_Click(object sender, EventArgs e)
    {
        //Cannot add an input to nothing
        if (out_text.Text == "")
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
            
        double add_input;
        error.Visible = false;
        //Check for input validity
        try
        {
            add_input = double.Parse(in_text.Text);
        }
        catch (System.FormatException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        catch (System.OverflowException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        //Cannot operate on an invalid value
        if (sum_valid == false)
        {
            in_text.Text = "";
            out_text.Text = invalid_output;
            return;
        }
        //Check for calculation validity
        sum += add_input;
        if(double.IsPositiveInfinity(sum))
        {
            in_text.Text = "";
            invalid_output = "Infinity";
            out_text.Text = invalid_output;
            sum_valid = false;
            return;
        }
        in_text.Text = "";
        out_text.Text = Convert.ToString(sum);
    }

    protected void sub_Click(object sender, EventArgs e)
    {
        //Cannot add an input to nothing
        if (out_text.Text == "")
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }

        double sub_input;
        error.Visible = false;
        //Check for input validity
        try
        {
            sub_input = double.Parse(in_text.Text);
        }
        catch (System.FormatException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        catch (System.OverflowException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        //Cannot operate on an invalid value
        if (sum_valid == false)
        {
            in_text.Text = "";
            out_text.Text = invalid_output;
            return;
        }
        //Check for calculation validity
        sum -= sub_input; 
        if (double.IsNegativeInfinity(sum))
        {
            in_text.Text = "";
            invalid_output = "-Infinity";
            out_text.Text = invalid_output;
            sum_valid = false;
            return;
        }
        in_text.Text = "";
        out_text.Text = Convert.ToString(sum);
    }

    protected void mult_Click(object sender, EventArgs e)
    {
        //Cannot add an input to nothing
        if (out_text.Text == "")
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }

        double mult_input;
        error.Visible = false;
        //Check for input validity
        try
        {
            mult_input = double.Parse(in_text.Text);
        }
        catch (System.FormatException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        catch (System.OverflowException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        //Cannot operate on an invalid value
        if (sum_valid == false)
        {
            if (mult_input == 0)
                invalid_output = "NaN";
            in_text.Text = "";
            out_text.Text = invalid_output;
            return;
        }
        //Check for calculation validity
        sum *= mult_input;
        if (double.IsPositiveInfinity(sum))
        {
            in_text.Text = "";
            invalid_output = "Infinity";
            out_text.Text = invalid_output;
            sum_valid = false;
            return;
        }
        if (double.IsNegativeInfinity(sum))
        {
            in_text.Text = "";
            invalid_output = "-Infinity";
            out_text.Text = invalid_output;
            sum_valid = false;
            return;
        }
        in_text.Text = "";
        out_text.Text = Convert.ToString(sum);
    }

    protected void div_Click(object sender, EventArgs e)
    {
        //Cannot add an input to nothing
        if (out_text.Text == "")
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        double div_input;
        error.Visible = false;
        //Check for input validity
        try
        {
            div_input = double.Parse(in_text.Text);
        }
        catch (System.FormatException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        catch (System.OverflowException)
        {
            error.Text = "Invalid or missing values!";
            error.Visible = true;
            return;
        }
        //Cannot operate on an invalid value
        if (sum_valid == false)
        {
            in_text.Text = "";
            out_text.Text = invalid_output;
            return;
        }
        if (div_input == 0)
        {
            sum_valid = false;
            if (sum > 0)
                invalid_output = "Infinity";
            else if (sum == 0)
                invalid_output = "NaN";
            else
                invalid_output = "-Infinity";
            in_text.Text = "";
            out_text.Text = invalid_output;
            return;
        }       
        //Divison cannot have overflow
        sum /= div_input;
        in_text.Text = "";
        out_text.Text = Convert.ToString(sum);
    }
}
