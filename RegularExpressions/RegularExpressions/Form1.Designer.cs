namespace RegularExpressions
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpBoxPattern = new System.Windows.Forms.GroupBox();
            this.textBoxPattern = new System.Windows.Forms.TextBox();
            this.grpBoxText = new System.Windows.Forms.GroupBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grpBoxMatches = new System.Windows.Forms.GroupBox();
            this.listBoxMatches = new System.Windows.Forms.ListBox();
            this.chkBoxCaseInsensitive = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxPattern.SuspendLayout();
            this.grpBoxText.SuspendLayout();
            this.grpBoxMatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxPattern
            // 
            this.grpBoxPattern.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.grpBoxPattern.Controls.Add(this.textBoxPattern);
            this.grpBoxPattern.Location = new System.Drawing.Point(28, 21);
            this.grpBoxPattern.Name = "grpBoxPattern";
            this.grpBoxPattern.Size = new System.Drawing.Size(229, 51);
            this.grpBoxPattern.TabIndex = 0;
            this.grpBoxPattern.TabStop = false;
            this.grpBoxPattern.Text = "Pattern";
            this.grpBoxPattern.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxPattern
            // 
            this.textBoxPattern.Location = new System.Drawing.Point(6, 19);
            this.textBoxPattern.Name = "textBoxPattern";
            this.textBoxPattern.Size = new System.Drawing.Size(217, 20);
            this.textBoxPattern.TabIndex = 0;
            this.textBoxPattern.TextChanged += new System.EventHandler(this.textBoxPattern_TextChanged);
            // 
            // grpBoxText
            // 
            this.grpBoxText.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.grpBoxText.Controls.Add(this.textBoxText);
            this.grpBoxText.Location = new System.Drawing.Point(28, 78);
            this.grpBoxText.Name = "grpBoxText";
            this.grpBoxText.Size = new System.Drawing.Size(229, 144);
            this.grpBoxText.TabIndex = 1;
            this.grpBoxText.TabStop = false;
            this.grpBoxText.Text = "Text";
            this.grpBoxText.Enter += new System.EventHandler(this.grpBoxText_Enter);
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(6, 19);
            this.textBoxText.Multiline = true;
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(217, 119);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Location = new System.Drawing.Point(289, 95);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // grpBoxMatches
            // 
            this.grpBoxMatches.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.grpBoxMatches.Controls.Add(this.listBoxMatches);
            this.grpBoxMatches.Location = new System.Drawing.Point(414, 40);
            this.grpBoxMatches.Name = "grpBoxMatches";
            this.grpBoxMatches.Size = new System.Drawing.Size(244, 182);
            this.grpBoxMatches.TabIndex = 3;
            this.grpBoxMatches.TabStop = false;
            this.grpBoxMatches.Text = "Matches";
            // 
            // listBoxMatches
            // 
            this.listBoxMatches.FormattingEnabled = true;
            this.listBoxMatches.Location = new System.Drawing.Point(6, 19);
            this.listBoxMatches.Name = "listBoxMatches";
            this.listBoxMatches.Size = new System.Drawing.Size(232, 160);
            this.listBoxMatches.TabIndex = 0;
            this.listBoxMatches.SelectedIndexChanged += new System.EventHandler(this.listBoxMatches_SelectedIndexChanged);
            // 
            // chkBoxCaseInsensitive
            // 
            this.chkBoxCaseInsensitive.AutoSize = true;
            this.chkBoxCaseInsensitive.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.chkBoxCaseInsensitive.Location = new System.Drawing.Point(289, 54);
            this.chkBoxCaseInsensitive.Name = "chkBoxCaseInsensitive";
            this.chkBoxCaseInsensitive.Size = new System.Drawing.Size(103, 17);
            this.chkBoxCaseInsensitive.TabIndex = 4;
            this.chkBoxCaseInsensitive.Text = "Case Insensitive";
            this.chkBoxCaseInsensitive.UseVisualStyleBackColor = true;
            this.chkBoxCaseInsensitive.CheckedChanged += new System.EventHandler(this.chkBoxCaseInsensitive_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(289, 161);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear matches";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegularExpressions.Properties.Resources.wallpaper;
            this.ClientSize = new System.Drawing.Size(773, 331);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkBoxCaseInsensitive);
            this.Controls.Add(this.grpBoxMatches);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grpBoxText);
            this.Controls.Add(this.grpBoxPattern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RegularExpressionChecks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxPattern.ResumeLayout(false);
            this.grpBoxPattern.PerformLayout();
            this.grpBoxText.ResumeLayout(false);
            this.grpBoxText.PerformLayout();
            this.grpBoxMatches.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxPattern;
        private System.Windows.Forms.TextBox textBoxPattern;
        private System.Windows.Forms.GroupBox grpBoxText;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.GroupBox grpBoxMatches;
        private System.Windows.Forms.ListBox listBoxMatches;
        private System.Windows.Forms.CheckBox chkBoxCaseInsensitive;
        private System.Windows.Forms.Button btnClear;
    }
}

