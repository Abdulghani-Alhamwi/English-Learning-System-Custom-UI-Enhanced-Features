using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace English_Learning_Management_System.Screens
{

    public partial class frmExample : Form
    {
        short _NumberOfSelectedItems;
        List<ListViewItem> lstItems;
        frmMainScreen MainForm;
        public frmExample(frmMainScreen frmM, List<ListViewItem> lstSelectedItems)
        {
            if (lstSelectedItems.Count < 1 || lstSelectedItems.Count > 4)
            {
                MessageBox.Show("Please select between 1 and 4 Words.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
            InitializeComponent();

            _NumberOfSelectedItems = Convert.ToInt16(lstSelectedItems.Count);
            lstItems = lstSelectedItems;
            MainForm = frmM;
        }


        private bool _IstxtBoxEmpty(TextBox txtBox)
        {
            return txtBox.Text == "";
        }
        private string[] _GetEnglishExamples()
        {
            List<string> Lexamples = new List<string>();

            if (!_IstxtBoxEmpty(txtBoxEnglishExample1) && _NumberOfSelectedItems >= 1 && txtBoxEnglishExample1.Text != "Enter Example For English Word 1")
                Lexamples.Add(txtBoxEnglishExample1.Text);

            if (!_IstxtBoxEmpty(txtBoxEnglishExample2) && _NumberOfSelectedItems >= 2 && txtBoxEnglishExample2.Text != "Enter Example For English Word 2")
                Lexamples.Add(txtBoxEnglishExample2.Text);

            if (!_IstxtBoxEmpty(txtBoxEnglishExample3) && _NumberOfSelectedItems >= 3 && txtBoxEnglishExample3.Text != "Enter Example For English Word 3")
                Lexamples.Add(txtBoxEnglishExample3.Text);

            if (!_IstxtBoxEmpty(txtBoxEnglishExample4) && _NumberOfSelectedItems == 4 && txtBoxEnglishExample4.Text != "Enter Example For English Word 4")
                Lexamples.Add(txtBoxEnglishExample4.Text);

            return Lexamples.ToArray();

        }

        private string[] _GetArabicExamples()
        {
            List<string> LexamplesTranslations = new List<string>();

            if (!_IstxtBoxEmpty(txtArabicExample1) && _NumberOfSelectedItems >= 1 && txtArabicExample1.Text != "Enter Translation For Example 1")
                LexamplesTranslations.Add(txtArabicExample1.Text);

            if (!_IstxtBoxEmpty(txtArabicExample2) && _NumberOfSelectedItems >= 2 && txtArabicExample2.Text != "Enter Translation For Example 2")
                LexamplesTranslations.Add(txtArabicExample2.Text);

            if (!_IstxtBoxEmpty(txtArabicExample3) && _NumberOfSelectedItems >= 3 && txtArabicExample3.Text != "Enter Translation For Example 3")
                LexamplesTranslations.Add(txtArabicExample3.Text);

            if (!_IstxtBoxEmpty(txtArabicExample4) && _NumberOfSelectedItems == 4 && txtArabicExample4.Text != "Enter Translation For Example 4")
                LexamplesTranslations.Add(txtArabicExample4.Text);

            return LexamplesTranslations.ToArray();

        }
        private void txtBox_Enter(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Tag.ToString() == "A1") && ((TextBox)sender).Text != "Enter Example For English Word 1")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "A2") && ((TextBox)sender).Text != "Enter Example For English Word 2")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "A3") && ((TextBox)sender).Text != "Enter Example For English Word 3")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "A4") && ((TextBox)sender).Text != "Enter Example For English Word 4")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "E1") && ((TextBox)sender).Text != "Enter Translation For Example 1")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "E2") && ((TextBox)sender).Text != "Enter Translation For Example 2")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "E3") && ((TextBox)sender).Text != "Enter Translation For Example 3")
                return;

            else if ((((TextBox)sender).Tag.ToString() == "E4") && ((TextBox)sender).Text != "Enter Translation For Example 4")
                return;


            ((TextBox)sender).Clear();
            ((TextBox)sender).ForeColor = Color.FromArgb(255, 30, 30, 30);
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            if ((((TextBox)sender).Tag.ToString() == "A1") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Example For English Word 1";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

            else if ((((TextBox)sender).Tag.ToString() == "A2") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Example For English Word 2";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "A3") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Example For English Word 3";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "A4") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Example For English Word 4";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }

            else if ((((TextBox)sender).Tag.ToString() == "E1") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Translation For Example 1";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "E2") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Translation For Example 2";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "E3") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Translation For Example 3";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
            else if ((((TextBox)sender).Tag.ToString() == "E4") && ((TextBox)sender).Text == "")
            {
                ((TextBox)sender).Text = "Enter Translation For Example 4";
                ((TextBox)sender).ForeColor = Color.FromArgb(255, 60, 60, 60);
            }
        }

        private void btnAddTranslations_Click(object sender, EventArgs e)
        {
            string[] arrExamplesInputs = _GetEnglishExamples();
            string[] arrExamplesTranslations = _GetArabicExamples();

            if (arrExamplesInputs.Length < 1 || arrExamplesTranslations.Length < 1 || arrExamplesInputs.Length != _NumberOfSelectedItems || arrExamplesTranslations.Length != _NumberOfSelectedItems)
                MessageBox.Show("Please enter Example/s by the number of your choosed words from 1 to 4 .", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
            {
                Form frmspeakwords = new frmEnglishWordsPresentaion(this, MainForm, lstItems, arrExamplesInputs, arrExamplesTranslations);
                this.Hide();
                MainForm.Hide();
                frmspeakwords.Show();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmExample_Load(object sender, EventArgs e)
        {
            for (short i = 0; i < _NumberOfSelectedItems; i++)
            {
                if (i == 0)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtBoxEnglishExample1.Text = clsWord.WordExample.ExampleInEnglish;
                    txtArabicExample1.Text = clsWord.WordExample.ExampleInArabic;
                }

                if (i == 1)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtBoxEnglishExample2.Text = clsWord.WordExample.ExampleInEnglish;
                    txtArabicExample2.Text = clsWord.WordExample.ExampleInArabic;
                }

                if (i == 2)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtBoxEnglishExample3.Text = clsWord.WordExample.ExampleInEnglish;
                    txtArabicExample3.Text = clsWord.WordExample.ExampleInArabic;
                }
                if (i == 3)
                {
                    await clsWord.Run(lstItems[i].Text, lstItems[i]);
                    txtBoxEnglishExample4.Text = clsWord.WordExample.ExampleInEnglish;
                    txtArabicExample4.Text = clsWord.WordExample.ExampleInArabic;
                }
            }
        }
    }
}
