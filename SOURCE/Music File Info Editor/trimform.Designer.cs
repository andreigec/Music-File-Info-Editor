namespace Music_File_Info_Editor
{
    partial class trimform
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
			this.frontbutton = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rearbutton = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.trimlength = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.exampletext2 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.exampletext1 = new System.Windows.Forms.Label();
			this.applybutton = new System.Windows.Forms.Button();
			this.cancelbutton = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.artistoption = new System.Windows.Forms.RadioButton();
			this.albumoption = new System.Windows.Forms.RadioButton();
			this.titleoption = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// frontbutton
			// 
			this.frontbutton.AutoSize = true;
			this.frontbutton.Checked = true;
			this.frontbutton.Location = new System.Drawing.Point(6, 19);
			this.frontbutton.Name = "frontbutton";
			this.frontbutton.Size = new System.Drawing.Size(49, 17);
			this.frontbutton.TabIndex = 0;
			this.frontbutton.TabStop = true;
			this.frontbutton.Text = "Front";
			this.frontbutton.UseVisualStyleBackColor = true;
			this.frontbutton.CheckedChanged += new System.EventHandler(this.frontbutton_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rearbutton);
			this.groupBox1.Controls.Add(this.frontbutton);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(231, 83);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Direction To Trim Text";
			// 
			// rearbutton
			// 
			this.rearbutton.AutoSize = true;
			this.rearbutton.Location = new System.Drawing.Point(6, 42);
			this.rearbutton.Name = "rearbutton";
			this.rearbutton.Size = new System.Drawing.Size(48, 17);
			this.rearbutton.TabIndex = 1;
			this.rearbutton.Text = "Rear";
			this.rearbutton.UseVisualStyleBackColor = true;
			this.rearbutton.CheckedChanged += new System.EventHandler(this.rearbutton_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.trimlength);
			this.groupBox2.Location = new System.Drawing.Point(12, 101);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(231, 59);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Length of Text to Trim";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(79, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "characters";
			// 
			// trimlength
			// 
			this.trimlength.Location = new System.Drawing.Point(6, 19);
			this.trimlength.Name = "trimlength";
			this.trimlength.Size = new System.Drawing.Size(67, 20);
			this.trimlength.TabIndex = 0;
			this.trimlength.Text = "5";
			this.trimlength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.trimlength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.exampletext2);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.exampletext1);
			this.groupBox3.Location = new System.Drawing.Point(12, 275);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(231, 86);
			this.groupBox3.TabIndex = 4;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Will become:";
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
			// applybutton
			// 
			this.applybutton.Location = new System.Drawing.Point(12, 367);
			this.applybutton.Name = "applybutton";
			this.applybutton.Size = new System.Drawing.Size(107, 23);
			this.applybutton.TabIndex = 5;
			this.applybutton.Text = "Apply Options";
			this.applybutton.UseVisualStyleBackColor = true;
			this.applybutton.Click += new System.EventHandler(this.applybutton_Click);
			// 
			// cancelbutton
			// 
			this.cancelbutton.Location = new System.Drawing.Point(125, 367);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(118, 23);
			this.cancelbutton.TabIndex = 6;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.artistoption);
			this.groupBox4.Controls.Add(this.albumoption);
			this.groupBox4.Controls.Add(this.titleoption);
			this.groupBox4.Location = new System.Drawing.Point(12, 166);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(231, 103);
			this.groupBox4.TabIndex = 7;
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
			// trimform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(266, 407);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.cancelbutton);
			this.Controls.Add(this.applybutton);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "trimform";
			this.Text = "trimform";
			this.Load += new System.EventHandler(this.trimform_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton frontbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rearbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trimlength;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label exampletext2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exampletext1;
        private System.Windows.Forms.Button applybutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton artistoption;
        private System.Windows.Forms.RadioButton albumoption;
        private System.Windows.Forms.RadioButton titleoption;

    }
}