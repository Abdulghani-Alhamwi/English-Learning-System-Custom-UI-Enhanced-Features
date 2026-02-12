using English_Learning_Management_System.Lib;
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
    public partial class frmEnglishWordsPresentaion : Form
    {
        clsSpeakWordsInView View;
        public frmEnglishWordsPresentaion(frmExample frmE, frmMainScreen frm, List<ListViewItem> SelectedWords, string[] Examples, string[] ExamplesTranslations)
        {
            InitializeComponent();
            View = new clsSpeakWordsInView(this, frmE, frm, SelectedWords, Examples, ExamplesTranslations, btnEnglishWord, lblExample, lblTranslation, lblReady, lblTE, btnArabicTranslation1, btnArabicTranslation2, btnArabicTranslation3, btnArabicTranslation4, panel1, smoothProgressIndicator1, timer1);
        }

        private void frmEnglishWordsPresentaion_Load(object sender, EventArgs e)
        {
            View.EnableTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            View.StartSession();

        }
    }
}
