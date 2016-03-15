using System.Windows.Forms;

namespace Music_File_Info_Editor
{
	partial class usercheck
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
			this.okbutton = new System.Windows.Forms.Button();
			this.cancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.beforelist = new ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
            this.afterlist = new ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.cancelbutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// okbutton
			// 
			this.okbutton.Location = new System.Drawing.Point(12, 460);
			this.okbutton.Name = "okbutton";
			this.okbutton.Size = new System.Drawing.Size(115, 23);
			this.okbutton.TabIndex = 0;
			this.okbutton.Text = "OK- Make Changes";
			this.okbutton.UseVisualStyleBackColor = true;
			this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
			// 
			// cancel
			// 
			this.cancel.Location = new System.Drawing.Point(133, 460);
			this.cancel.Name = "cancel";
			this.cancel.Size = new System.Drawing.Size(161, 23);
			this.cancel.TabIndex = 1;
			this.cancel.Text = "Do Not Make These Changes";
			this.cancel.UseVisualStyleBackColor = true;
			this.cancel.Click += new System.EventHandler(this.cancel_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Before:";
			// 
			// beforelist
			// 
			this.beforelist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.beforelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.beforelist.Location = new System.Drawing.Point(12, 25);
			this.beforelist.Name = "beforelist";
			this.beforelist.Size = new System.Drawing.Size(423, 205);
			this.beforelist.TabIndex = 3;
			this.beforelist.UseCompatibleStateImageBehavior = false;
			this.beforelist.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Width = 150;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 233);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "After:";
			// 
			// afterlist
			// 
			this.afterlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.afterlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
			this.afterlist.Location = new System.Drawing.Point(12, 249);
			this.afterlist.Name = "afterlist";
			this.afterlist.Size = new System.Drawing.Size(423, 205);
			this.afterlist.TabIndex = 5;
			this.afterlist.UseCompatibleStateImageBehavior = false;
			this.afterlist.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Width = 150;
			// 
			// cancelbutton
			// 
			this.cancelbutton.Location = new System.Drawing.Point(300, 460);
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.Size = new System.Drawing.Size(135, 23);
			this.cancelbutton.TabIndex = 6;
			this.cancelbutton.Text = "Cancel";
			this.cancelbutton.UseVisualStyleBackColor = true;
			this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
			// 
			// usercheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 492);
			this.Controls.Add(this.cancelbutton);
			this.Controls.Add(this.afterlist);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.beforelist);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancel);
			this.Controls.Add(this.okbutton);
			this.Name = "usercheck";
			this.Text = "usercheck";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button okbutton;
		private System.Windows.Forms.Button cancel;
		private System.Windows.Forms.Label label1;
		private ListView beforelist;
		private System.Windows.Forms.Label label2;
		private ListView afterlist;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Button cancelbutton;
	}
}