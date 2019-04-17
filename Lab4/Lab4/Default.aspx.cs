using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Helper function for character swapping
    string Swap_char(string str, int length, int indexf, int indexe)
    {
        string newstr = "";
        char tmp_indexf = str[indexf];
        char tmp_indexe = str[indexe];
        //Copies the entire string and swap at the designated index
        for (int i =0; i<length; i++)
        {
            if (i == indexf)
                newstr += tmp_indexe;
            else if (i == indexe)
                newstr += tmp_indexf;
            else
                newstr += str[i];
        }
        return newstr;
    }

    // Recursive function for string permutations
    void Permute_string(string in_str, int findex, int eindex, ref int numAnagrams, bool no_dup)
    {
        int length = in_str.Length;
        if (findex == eindex)
        {
            //Checks the listbox for existing items
            if (no_dup == true)
            {
                ListItem item = anagram_display.Items.FindByText(in_str);
                if (item != null)
                    return;
            }
            // Adds permutation to listbox and increase count
            anagram_display.Items.Add(in_str);
            numAnagrams++;
            return;
        }

        //Swaps and permutes with a new fixed value and a new string
        for(int i = findex; i <= eindex; i++)
        {
            in_str = Swap_char(in_str, length, findex, i);
            Permute_string(in_str, findex + 1, eindex, ref numAnagrams, no_dup);
            in_str = Swap_char(in_str, length, findex, i);
        }
        
        
    }

    public void Calc_anagrams(object sender, EventArgs e)
    {
        // Resets all components
        anagram_display.Items.Clear();
        int numAnagrams = 0;
        bool no_dup = false;

        // Retreives input from user & checks for validity
        string input = in_str.Text;
        int in_length = input.Length;
        if (in_length > 8 || in_length < 1)
        {
            comment.Text = "Please enter a string from 1 to 8 characters.";
            in_str.Text = "";
            return;
        }

        //Check whether if duplicates are wanted or not
        if (remove_dup.Checked)
            no_dup = true;
        Permute_string(input, 0, in_length-1, ref numAnagrams, no_dup);
        if (numAnagrams > 1)
            comment.Text = numAnagrams + " anagrams found.";
        else
            comment.Text = numAnagrams + " anagram found.";
        
        //Clears the textbox
        in_str.Text = "";
    }




}