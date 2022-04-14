using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RegularExpressions
{
    public partial class Form1 : Form
    {
        public string Pattern { get; set; }
        public string SourceText { get; set; }
        public bool CaseInsensitive { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            RegexOptions options = RegexOptions.None;

            if(chkBoxCaseInsensitive.Checked)
            {
                options = RegexOptions.IgnoreCase;
            }


            Regex regex = new Regex(Pattern,options);
            if (regex.IsMatch(SourceText))
            {
                MatchCollection matches = regex.Matches(SourceText);
                foreach(var item in matches)
                {
                    listBoxMatches.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("No matches found!", "ERROR");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPattern_TextChanged(object sender, EventArgs e)
        {
            this.Pattern = textBoxPattern.Text;        

        }

        private void textBoxText_TextChanged(object sender, EventArgs e)
        {
            this.SourceText = textBoxText.Text;
        }

        private void listBoxMatches_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpBoxText_Enter(object sender, EventArgs e)
        {

        }

        private void chkBoxCaseInsensitive_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBoxMatches.Items.Clear();
        }
    }
}