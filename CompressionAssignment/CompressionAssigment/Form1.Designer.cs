namespace CompressionAssigment
{
    partial class CarstensZipper
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
            this.fromtextbox = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.methoddrop = new System.Windows.Forms.ComboBox();
            this.setfilter = new System.Windows.Forms.CheckBox();
            this.filtertext = new System.Windows.Forms.TextBox();
            this.totextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.settingdrop = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.CheckBox();
            this.zipname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fromtextbox
            // 
            this.fromtextbox.Location = new System.Drawing.Point(146, 128);
            this.fromtextbox.Name = "fromtextbox";
            this.fromtextbox.Size = new System.Drawing.Size(274, 22);
            this.fromtextbox.TabIndex = 0;
            // 
            // methoddrop
            // 
            this.methoddrop.FormattingEnabled = true;
            this.methoddrop.Items.AddRange(new object[] {
            "Zip",
            "GZip",
            "7z"});
            this.methoddrop.Location = new System.Drawing.Point(253, 259);
            this.methoddrop.Name = "methoddrop";
            this.methoddrop.Size = new System.Drawing.Size(167, 24);
            this.methoddrop.TabIndex = 2;
            // 
            // setfilter
            // 
            this.setfilter.AutoSize = true;
            this.setfilter.Location = new System.Drawing.Point(146, 221);
            this.setfilter.Name = "setfilter";
            this.setfilter.Size = new System.Drawing.Size(86, 21);
            this.setfilter.TabIndex = 3;
            this.setfilter.Text = "Set Filter";
            this.setfilter.UseVisualStyleBackColor = true;
            this.setfilter.CheckedChanged += new System.EventHandler(this.setfilter_Checked);
            // 
            // filtertext
            // 
            this.filtertext.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.filtertext.Location = new System.Drawing.Point(253, 221);
            this.filtertext.Name = "filtertext";
            this.filtertext.Size = new System.Drawing.Size(167, 22);
            this.filtertext.TabIndex = 4;
            // 
            // totextbox
            // 
            this.totextbox.Location = new System.Drawing.Point(146, 170);
            this.totextbox.Name = "totextbox";
            this.totextbox.Size = new System.Drawing.Size(274, 22);
            this.totextbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FromBrowse_Click);
            // 
            // settingdrop
            // 
            this.settingdrop.FormattingEnabled = true;
            this.settingdrop.Items.AddRange(new object[] {
            "Zip",
            "Unzip",
            "Add"});
            this.settingdrop.Location = new System.Drawing.Point(146, 41);
            this.settingdrop.MaxDropDownItems = 3;
            this.settingdrop.Name = "settingdrop";
            this.settingdrop.Size = new System.Drawing.Size(274, 24);
            this.settingdrop.TabIndex = 7;
            this.settingdrop.SelectedIndexChanged += new System.EventHandler(this.settingdrop_Change);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Browse...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ToBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select Method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Setting";
            // 
            // begin
            // 
            this.begin.Location = new System.Drawing.Point(345, 297);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(75, 23);
            this.begin.TabIndex = 13;
            this.begin.Text = "Begin";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(146, 299);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(54, 21);
            this.log.TabIndex = 14;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // zipname
            // 
            this.zipname.Location = new System.Drawing.Point(146, 87);
            this.zipname.Name = "zipname";
            this.zipname.Size = new System.Drawing.Size(274, 22);
            this.zipname.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Zip Name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // CarstensZipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 348);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.zipname);
            this.Controls.Add(this.log);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.settingdrop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totextbox);
            this.Controls.Add(this.filtertext);
            this.Controls.Add(this.setfilter);
            this.Controls.Add(this.methoddrop);
            this.Controls.Add(this.fromtextbox);
            this.Name = "CarstensZipper";
            this.Text = "CarstensZipper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromtextbox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.ComboBox methoddrop;
        private System.Windows.Forms.CheckBox setfilter;
        private System.Windows.Forms.TextBox filtertext;
        private System.Windows.Forms.TextBox totextbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox settingdrop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.CheckBox log;
        private System.Windows.Forms.TextBox zipname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}