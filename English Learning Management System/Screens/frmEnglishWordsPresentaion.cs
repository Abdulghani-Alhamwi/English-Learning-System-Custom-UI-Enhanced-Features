using English_Learning_Management_System.Lib;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace English_Learning_Management_System.Screens
{
    public partial class frmEnglishWordsPresentaion : Form
    {
        clsSpeakWordsInView View;
        frmExample _frmE;
        frmMainScreen _frmMain;
        public frmEnglishWordsPresentaion(frmExample frmE, frmMainScreen frmMain, List<ListViewItem> SelectedWords, string[] Examples, string[] ExamplesTranslations)
        {
            InitializeComponent();
            View = new clsSpeakWordsInView(this, frmE, frmMain, SelectedWords, Examples, ExamplesTranslations, btnEnglishWord, lblExample, lblTranslation, lblReady, lblTE, btnArabicTranslation1, btnArabicTranslation2, btnArabicTranslation3, btnArabicTranslation4, panel1, smoothProgressIndicator1, timer1);
            _frmMain = frmMain;
            _frmE = frmE;
        }

        private void frmEnglishWordsPresentaion_Load(object sender, EventArgs e)
        {
            View.EnableTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            View.StartSession();
        }

        void CloseForm()
        {
            _frmE.Close();
            _frmMain.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CloseForm();
        }
    }
}
