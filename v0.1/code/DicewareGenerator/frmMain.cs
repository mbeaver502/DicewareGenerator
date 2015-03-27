// ----------------------------------------------------------------------------------
// Diceware Passphrase Generator
// ----------------------------------------------------------------------------------
// Version: 0.1
//  Author: J. Michael Beaver
// ----------------------------------------------------------------------------------
// This software is meant to be used to "randomly" generate passphrases based on the
// Diceware system. This software was created in response to the following article:
// https://firstlook.org/theintercept/2015/03/26/passphrases-can-memorize-attackers-cant-guess/.
// Anyone may use and edit this software as permitted by the license below. This 
// initial version is not particularly extensible due to much of the "variable" parts
// being hardcoded (e.g., how many dice to roll). This will (likely) change with
// future versions. Comments are sparse and functional decomposition is nonexistent.
// Also, the wordlist file must be in the same directory as the executable. What you 
// see is what you get.
// ----------------------------------------------------------------------------------
// Change Log:
//      27 March 2015
//          Initial version.
// ----------------------------------------------------------------------------------
// License: Attribution-NonCommercial-ShareAlike 4.0 International (CC BY-NC-SA 4.0)
// Wordlist: Arnold G. Reinold (http://world.std.com/~reinhold/) (CC BY 3.0 US)
// Icon: FatCow (https://www.iconfinder.com/icons/64067/dice_icon) (CC BY 3.0 US)
// ----------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicewareGenerator
{
    public partial class frmMain : Form
    {

        const int DICE_ROLLS = 5;
        bool isUpperCase = true;
        Dictionary<string, string> words = new Dictionary<string,string>();


        public frmMain()
        {
            InitializeComponent();
        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Diceware Passphrase Generator v0.1\n\n" + 
                            "Author: J. Michael Beaver\n" + 
                            "Wordlist: Arnold G. Reinhold\n" +
                            "License: CC BY-NC-SA 4.0\n\n" + 
                            "27 March 2015", 
                            "About", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
        }


        private void rbUpper_CheckedChanged(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text.ToUpper();
            isUpperCase = true;
        }


        private void rbLower_CheckedChanged(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text.ToLower();
            isUpperCase = false;
        }


        // Most of the important action happens here.
        private void btnGo_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int num;
            int numWords = (int)nudNumWords.Value;
            string key = "";
            string pWord = "";
            string result = "";

            // Build the passphrase.
            for (int loopCount = 0; loopCount < numWords; loopCount++)
            {
                key = "";

                // Build the 5-digit key that matches the password.
                for (int i = 0; i < DICE_ROLLS; i++)
                {
                    num = r.Next(0, 6);
                    num++;
                    key += num.ToString();
                }

                // Get the password based on the key and add delimiters.
                try
                {
                    pWord = words[key];

                    if (isUpperCase)
                        pWord = pWord.ToUpper();

                    result += pWord;

                    if (loopCount < numWords - 1)
                    {
                        if (cbDelimiters.SelectedItem.Equals("Space"))
                            result += " ";

                        else
                            result += cbDelimiters.SelectedItem;
                    }
                }

                catch (KeyNotFoundException)
                {
                    MessageBox.Show("Invalid key: " + key.ToString(), "Error!", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loopCount--;
                }
            }
                
            txtOutput.Text = result;
        }


        // On the form load we will attempt to load the wordlist.
        private void frmMain_Load(object sender, EventArgs e)
        {
            cbDelimiters.SelectedIndex = 0;
            
            try
            {
                StreamReader file = new StreamReader("wordlist.txt");
                string line;
                string [] parts;

                // Build the internal wordlist.
                while ((line = file.ReadLine()) != null)
                {
                    parts = line.Split(new Char[] { ' ', '\t' });

                    try
                    {
                        words.Add(parts[0], parts[1]);
                    }
                    
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Duplicate key: " + line, "Error!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                file.Close();
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("\"wordlist.txt\" was not found!", "Error!", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGo.Enabled = false;
            }
        }


        // Here we can update the delimiters on the fly.
        private void cbDelimiters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string find = "";
            string replace = "";

            if (txtOutput.Text == String.Empty)
                return;

            // (Badly) Determine which delimiter was being used previously.
            foreach (string item in cbDelimiters.Items)
            {
                if (item == "Space")
                    find = " ";
                else
                    find = item;

                if (txtOutput.Text.IndexOf(find) >= 0)
                    break;
            }

            // Update the delimiters.
            replace = cbDelimiters.SelectedItem.ToString();
            if (replace == "Space")
                replace = " ";

            txtOutput.Text = txtOutput.Text.Replace(find, replace);
        }


        private void nudNumWords_ValueChanged(object sender, EventArgs e)
        {
            btnGo_Click(sender, e);
        }
    }
}
