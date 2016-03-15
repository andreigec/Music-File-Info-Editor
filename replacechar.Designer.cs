namespace Music_File_Info_Editor
{
    partial class replacechar
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
			this.label1 = new System.Windows.Forms.Label();
			this.changethis = new System.Windows.Forms.TextBox();
			this.cancelbutton = new System.Windows.Forms.Button();
			this.okbutton = new System.Windows.Forms.Button();
			this.tothis = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.artistoption = new System.Windows.Forms.RadioButton();
			this.albumoption = new System.Windows.Forms.RadioButton();
			this.titleoption = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.exampletext2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.exampletext1 = new System.Windows.Forms.Label();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Change This Character:";
			// 
			// changethis
			// 
			this.changethis.Location = new System.Drawing.Point(130, 5);
			this.changethis.MaxLength = 1;
			this.changethis.Name = "changethis";
			this.changethis.Size = new System.Drawing.Size(32, 20);
			this.changethis.TabIndex = 1;
			this.changethis.TextChanged += new System.EventHandler(this.changethis_TextChanged);
			// 
			// cancelbutton
			// 
			this.cancelbutton.Location = new System.Drawing.Point(129, 255);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(109, 23);
			this.cancelbutton.TabIndex = 9;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
			// 
			// okbutton
			// 
			this.okbutton.Location = new System.Drawing.Point(8, 255);
			this.okbutton.Name = "okbutton";
			this.okbutton.Size = new System.Drawing.Size(115, 23);
			this.okbutton.TabIndex = 7;
			this.okbutton.Text = "OK- Make Changes";
			this.okbutton.UseVisualStyleBackColor = true;
			this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
			// 
			// tothis
			// 
			this.tothis.Location = new System.Drawing.Point(130, 28);
			this.tothis.MaxLength = 1;
			this.tothis.Name = "tothis";
			this.tothis.Size = new System.Drawing.Size(32, 20);
			this.tothis.TabIndex = 11;
			this.tothis.TextChanged += new System.EventHandler(this.tothis_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(5, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "To This Character:";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.artistoption);
			this.groupBox4.Controls.Add(this.albumoption);
			this.groupBox4.Controls.Add(this.titleoption);
			this.groupBox4.Location = new System.Drawing.Point(8, 54);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(231, 103);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Apply To Which Field";
			// 
			// artistoption
			// 
			this.artistoption.AutoSize = true;
			this.artistoption.Location = new System.Drawing.Point(6, 65);
			this.artistoption.Name = "artistoption";
			this.artistoption.Size = new System.Drawing.Size(48, 17);
			this.artistoption.TabIndex = 3;
			this.artistoption.Text = "Artist";
			this.artistoption.UseVisualStyleBackColor = true;
			this.artistoption.CheckedChanged += new System.EventHandler(this.artistoption_CheckedChanged);
			// 
			// albumoption
			// 
			this.albumoption.AutoSize = true;
			this.albumoption.Location = new System.Drawing.Point(6, 42);
			this.albumoption.Name = "albumoption";
			this.albumoption.Size = new System.Drawing.Size(54, 17);
			this.albumoption.TabIndex = 2;
			this.albumoption.Text = "Album";
			this.albumoption.UseVisualStyleBackColor = true;
			this.albumoption.CheckedChanged += new System.EventHandler(this.albumoption_CheckedChanged);
			// 
			// titleoption
			// 
			this.titleoption.AutoSize = true;
			this.titleoption.Checked = true;
			this.titleoption.Location = new System.Drawing.Point(6, 19);
			this.titleoption.Name = "titleoption";
			this.titleoption.Size = new System.Drawing.Size(45, 17);
			this.titleoption.TabIndex = 1;
			this.titleoption.TabStop = true;
			this.titleoption.Text = "Title";
			this.titleoption.UseVisualStyleBackColor = true;
			this.titleoption.CheckedChanged += new System.EventHandler(this.titleoption_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.exampletext2);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.exampletext1);
			this.groupBox3.Location = new System.Drawing.Point(8, 163);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(231, 86);
			this.groupBox3.TabIndex = 15;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Example";
			// 
			// exampletext2
			// 
			this.exampletext2.AutoSize = true;
			this.exampletext2.Location = new System.Drawing.Point(6, 60);
			this.exampletext2.Name = "exampletext2";
			this.exampletext2.Size = new System.Drawing.Size(17, 13);
			this.exampletext2.TabIndex = 7;
			this.exampletext2.Text = "zz";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Will become:";
			// 
			// exampletext1
			// 
			this.exampletext1.AutoSize = true;
			this.exampletext1.Location = new System.Drawing.Point(6, 16);
			this.exampletext1.Name = "exampletext1";
			this.exampletext1.Size = new System.Drawing.Size(17, 13);
			this.exampletext1.TabIndex = 4;
			this.exampletext1.Text = "zz";
			// 
			// replacechar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 289);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.tothis);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cancelbutton);
			this.Controls.Add(this.okbutton);
			this.Controls.Add(this.changethis);
			this.Controls.Add(this.label1);
			this.Name = "replacechar";
			this.Text = "replacechar";
			this.Load += new System.EventHandler(this.replacechar_Load);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox changethis;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.TextBox tothis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton artistoption;
        private System.Windows.Forms.RadioButton albumoption;
        private System.Windows.Forms.RadioButton titleoption;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label exampletext2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label exampletext1;
    }
}