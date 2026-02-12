namespace English_Learning_Management_System.Screens
{
    partial class frmExamplesInsertion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.borderlessFormAnimator1 = new EnhancedControls.BorderlessFormAnimator();
            this.btnAddExamples = new EnhancedControls.EnhancedButton();
            this.txtArabicExample1 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample1 = new System.Windows.Forms.TextBox();
            this.btnExit = new EnhancedControls.EnhancedButton();
            this.txtBoxEnglishExample2 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample3 = new System.Windows.Forms.TextBox();
            this.txtBoxEnglishExample4 = new System.Windows.Forms.TextBox();
            this.txtArabicExample2 = new System.Windows.Forms.TextBox();
            this.txtArabicExample4 = new System.Windows.Forms.TextBox();
            this.txtArabicExample3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // borderlessFormAnimator1
            // 
            this.borderlessFormAnimator1.AnimateWindow = false;
            this.borderlessFormAnimator1.AnimationDuration = 400;
            this.borderlessFormAnimator1.CornerRadius = 80;
            this.borderlessFormAnimator1.Draggable = true;
            this.borderlessFormAnimator1.EntryAnimation = EnhancedControls.FormAnimationType.CenterZoomIn;
            this.borderlessFormAnimator1.EntryEasing = EnhancedControls.AnimationEasingType.EaseOut;
            this.borderlessFormAnimator1.ExitAnimation = EnhancedControls.FormAnimationType.CenterZoomOut;
            this.borderlessFormAnimator1.ExitEasing = EnhancedControls.AnimationEasingType.EaseIn;
            this.borderlessFormAnimator1.TargetForm = this;
            // 
            // btnAddExamples
            // 
            this.btnAddExamples.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExamples.BorderColor = System.Drawing.Color.Black;
            this.btnAddExamples.BorderSize = 1;
            this.btnAddExamples.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExamples.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnAddExamples.ForeColor = System.Drawing.Color.White;
            this.btnAddExamples.GradientEndColor = System.Drawing.Color.DarkGreen;
            this.btnAddExamples.GradientStartColor = System.Drawing.Color.LimeGreen;
            this.btnAddExamples.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnAddExamples.Location = new System.Drawing.Point(647, 744);
            this.btnAddExamples.Name = "btnAddExamples";
            this.btnAddExamples.Size = new System.Drawing.Size(305, 80);
            this.btnAddExamples.TabIndex = 7;
            this.btnAddExamples.TabStop = false;
            this.btnAddExamples.Text = "Add Example/s";
            this.btnAddExamples.UseVisualStyleBackColor = false;
            this.btnAddExamples.Click += new System.EventHandler(this.btnAddExamples_Click);
            // 
            // txtArabicExample1
            // 
            this.txtArabicExample1.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample1.Location = new System.Drawing.Point(871, 145);
            this.txtArabicExample1.Multiline = true;
            this.txtArabicExample1.Name = "txtArabicExample1";
            this.txtArabicExample1.Size = new System.Drawing.Size(586, 80);
            this.txtArabicExample1.TabIndex = 6;
            this.txtArabicExample1.Tag = "E1";
            this.txtArabicExample1.Text = "Enter Translation For Example 1";
            this.txtArabicExample1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample1.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample1.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample1
            // 
            this.txtBoxEnglishExample1.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample1.Location = new System.Drawing.Point(130, 145);
            this.txtBoxEnglishExample1.Multiline = true;
            this.txtBoxEnglishExample1.Name = "txtBoxEnglishExample1";
            this.txtBoxEnglishExample1.Size = new System.Drawing.Size(586, 80);
            this.txtBoxEnglishExample1.TabIndex = 5;
            this.txtBoxEnglishExample1.Tag = "A1";
            this.txtBoxEnglishExample1.Text = "Enter Example For English Word 1";
            this.txtBoxEnglishExample1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample1.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample1.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Cairo", 37.25F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.GradientStartColor = System.Drawing.Color.Maroon;
            this.btnExit.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.btnExit.Location = new System.Drawing.Point(1510, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 94);
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBoxEnglishExample2
            // 
            this.txtBoxEnglishExample2.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample2.Location = new System.Drawing.Point(130, 282);
            this.txtBoxEnglishExample2.Multiline = true;
            this.txtBoxEnglishExample2.Name = "txtBoxEnglishExample2";
            this.txtBoxEnglishExample2.Size = new System.Drawing.Size(586, 80);
            this.txtBoxEnglishExample2.TabIndex = 9;
            this.txtBoxEnglishExample2.Tag = "A2";
            this.txtBoxEnglishExample2.Text = "Enter Example For English Word 2";
            this.txtBoxEnglishExample2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample3
            // 
            this.txtBoxEnglishExample3.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample3.Location = new System.Drawing.Point(130, 419);
            this.txtBoxEnglishExample3.Multiline = true;
            this.txtBoxEnglishExample3.Name = "txtBoxEnglishExample3";
            this.txtBoxEnglishExample3.Size = new System.Drawing.Size(586, 80);
            this.txtBoxEnglishExample3.TabIndex = 10;
            this.txtBoxEnglishExample3.Tag = "A3";
            this.txtBoxEnglishExample3.Text = "Enter Example For English Word 3";
            this.txtBoxEnglishExample3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtBoxEnglishExample4
            // 
            this.txtBoxEnglishExample4.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEnglishExample4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtBoxEnglishExample4.Location = new System.Drawing.Point(130, 556);
            this.txtBoxEnglishExample4.Multiline = true;
            this.txtBoxEnglishExample4.Name = "txtBoxEnglishExample4";
            this.txtBoxEnglishExample4.Size = new System.Drawing.Size(586, 80);
            this.txtBoxEnglishExample4.TabIndex = 11;
            this.txtBoxEnglishExample4.Tag = "A4";
            this.txtBoxEnglishExample4.Text = "Enter Example For English Word 4";
            this.txtBoxEnglishExample4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxEnglishExample4.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxEnglishExample4.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample2
            // 
            this.txtArabicExample2.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample2.Location = new System.Drawing.Point(871, 282);
            this.txtArabicExample2.Multiline = true;
            this.txtArabicExample2.Name = "txtArabicExample2";
            this.txtArabicExample2.Size = new System.Drawing.Size(586, 80);
            this.txtArabicExample2.TabIndex = 12;
            this.txtArabicExample2.Tag = "E2";
            this.txtArabicExample2.Text = "Enter Translation For Example 2";
            this.txtArabicExample2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample2.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample4
            // 
            this.txtArabicExample4.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample4.Location = new System.Drawing.Point(871, 556);
            this.txtArabicExample4.Multiline = true;
            this.txtArabicExample4.Name = "txtArabicExample4";
            this.txtArabicExample4.Size = new System.Drawing.Size(586, 80);
            this.txtArabicExample4.TabIndex = 13;
            this.txtArabicExample4.Tag = "E4";
            this.txtArabicExample4.Text = "Enter Translation For Example 4";
            this.txtArabicExample4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample4.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample4.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // txtArabicExample3
            // 
            this.txtArabicExample3.Font = new System.Drawing.Font("Cairo", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.txtArabicExample3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtArabicExample3.Location = new System.Drawing.Point(871, 419);
            this.txtArabicExample3.Multiline = true;
            this.txtArabicExample3.Name = "txtArabicExample3";
            this.txtArabicExample3.Size = new System.Drawing.Size(586, 80);
            this.txtArabicExample3.TabIndex = 14;
            this.txtArabicExample3.Tag = "E3";
            this.txtArabicExample3.Text = "Enter Translation For Example 3";
            this.txtArabicExample3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArabicExample3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtArabicExample3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // frmExamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::English_Learning_Management_System.Properties.Resources.Whisk_464189a0601ec149fd841f6c137a8e2edr;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1597, 851);
            this.Controls.Add(this.txtArabicExample3);
            this.Controls.Add(this.txtArabicExample4);
            this.Controls.Add(this.txtArabicExample2);
            this.Controls.Add(this.txtBoxEnglishExample4);
            this.Controls.Add(this.txtBoxEnglishExample3);
            this.Controls.Add(this.txtBoxEnglishExample2);
            this.Controls.Add(this.btnAddExamples);
            this.Controls.Add(this.txtArabicExample1);
            this.Controls.Add(this.txtBoxEnglishExample1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExamples";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExamples_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EnhancedControls.BorderlessFormAnimator borderlessFormAnimator1;
        private EnhancedControls.EnhancedButton btnAddExamples;
        private System.Windows.Forms.TextBox txtArabicExample1;
        private System.Windows.Forms.TextBox txtBoxEnglishExample1;
        private EnhancedControls.EnhancedButton btnExit;
        private System.Windows.Forms.TextBox txtBoxEnglishExample4;
        private System.Windows.Forms.TextBox txtBoxEnglishExample3;
        private System.Windows.Forms.TextBox txtBoxEnglishExample2;
        private System.Windows.Forms.TextBox txtArabicExample3;
        private System.Windows.Forms.TextBox txtArabicExample4;
        private System.Windows.Forms.TextBox txtArabicExample2;
    }
}