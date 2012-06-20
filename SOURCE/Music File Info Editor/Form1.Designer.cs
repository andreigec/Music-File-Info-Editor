namespace Music_File_Info_Editor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.additems = new System.Windows.Forms.Button();
            this.removebutton = new System.Windows.Forms.Button();
            this.movedownbutton = new System.Windows.Forms.Button();
            this.moveupbutton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.camelcase = new System.Windows.Forms.ToolStripMenuItem();
            this.autoincrement = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTextFromFrontOrBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFilePathToTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addtext = new System.Windows.Forms.ToolStripMenuItem();
            this.replacechar = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usercheckfirst = new System.Windows.Forms.ToolStripMenuItem();
            this.titlecheckCB = new System.Windows.Forms.ToolStripMenuItem();
            this.capitaliseWordsCB = new System.Windows.Forms.ToolStripMenuItem();
            this.spacesAfterCommasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dontsave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemnumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileList = new ANDREICSLIB.ListViewUpdate();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.additems);
            this.panel2.Controls.Add(this.removebutton);
            this.panel2.Controls.Add(this.movedownbutton);
            this.panel2.Controls.Add(this.moveupbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 401);
            this.panel2.TabIndex = 4;
            // 
            // additems
            // 
            this.additems.Dock = System.Windows.Forms.DockStyle.Top;
            this.additems.Location = new System.Drawing.Point(0, 46);
            this.additems.Name = "additems";
            this.additems.Size = new System.Drawing.Size(87, 23);
            this.additems.TabIndex = 3;
            this.additems.Text = "Add MP3s";
            this.additems.UseVisualStyleBackColor = true;
            this.additems.Click += new System.EventHandler(this.additems_Click);
            // 
            // removebutton
            // 
            this.removebutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.removebutton.Enabled = false;
            this.removebutton.Location = new System.Drawing.Point(0, 23);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(87, 23);
            this.removebutton.TabIndex = 2;
            this.removebutton.Text = "Remove MP3s";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // movedownbutton
            // 
            this.movedownbutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.movedownbutton.Enabled = false;
            this.movedownbutton.Location = new System.Drawing.Point(0, 378);
            this.movedownbutton.Name = "movedownbutton";
            this.movedownbutton.Size = new System.Drawing.Size(87, 23);
            this.movedownbutton.TabIndex = 1;
            this.movedownbutton.Text = "Move Down";
            this.movedownbutton.UseVisualStyleBackColor = true;
            this.movedownbutton.Click += new System.EventHandler(this.movedownbutton_Click);
            // 
            // moveupbutton
            // 
            this.moveupbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.moveupbutton.Enabled = false;
            this.moveupbutton.Location = new System.Drawing.Point(0, 0);
            this.moveupbutton.Name = "moveupbutton";
            this.moveupbutton.Size = new System.Drawing.Size(87, 23);
            this.moveupbutton.TabIndex = 0;
            this.moveupbutton.Text = "Move Up";
            this.moveupbutton.UseVisualStyleBackColor = true;
            this.moveupbutton.Click += new System.EventHandler(this.moveupbutton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearItemsToolStripMenuItem,
            this.refreshFilesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // clearItemsToolStripMenuItem
            // 
            this.clearItemsToolStripMenuItem.Name = "clearItemsToolStripMenuItem";
            this.clearItemsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearItemsToolStripMenuItem.Text = "Clear Items";
            this.clearItemsToolStripMenuItem.Click += new System.EventHandler(this.clearItemsToolStripMenuItem_Click);
            // 
            // refreshFilesToolStripMenuItem
            // 
            this.refreshFilesToolStripMenuItem.Name = "refreshFilesToolStripMenuItem";
            this.refreshFilesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.refreshFilesToolStripMenuItem.Text = "Refresh File Info";
            this.refreshFilesToolStripMenuItem.Click += new System.EventHandler(this.refreshFilesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.camelcase,
            this.autoincrement,
            this.removeTextFromFrontOrBackToolStripMenuItem,
            this.copyFilePathToTitleToolStripMenuItem,
            this.addtext,
            this.replacechar});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // camelcase
            // 
            this.camelcase.Name = "camelcase";
            this.camelcase.Size = new System.Drawing.Size(256, 22);
            this.camelcase.Text = "Auto-Capitalise Title/Album/Artist";
            this.camelcase.ToolTipText = "Auto Capitalise a string so that the first letter of every word is a capital, whi" +
    "le the rest are lower case";
            this.camelcase.Click += new System.EventHandler(this.autocapitalise_Click_1);
            // 
            // autoincrement
            // 
            this.autoincrement.Name = "autoincrement";
            this.autoincrement.Size = new System.Drawing.Size(256, 22);
            this.autoincrement.Text = "Auto Increment Track Numbers";
            this.autoincrement.ToolTipText = "Increment the track numbers of the selected items";
            this.autoincrement.Click += new System.EventHandler(this.autoincrement_Click_1);
            // 
            // removeTextFromFrontOrBackToolStripMenuItem
            // 
            this.removeTextFromFrontOrBackToolStripMenuItem.Name = "removeTextFromFrontOrBackToolStripMenuItem";
            this.removeTextFromFrontOrBackToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.removeTextFromFrontOrBackToolStripMenuItem.Text = "Remove Text From Front Or Back";
            this.removeTextFromFrontOrBackToolStripMenuItem.ToolTipText = "Trim text from the front or back of the title, artist, or album";
            this.removeTextFromFrontOrBackToolStripMenuItem.Click += new System.EventHandler(this.removeTextFromFrontOrBackToolStripMenuItem_Click);
            // 
            // copyFilePathToTitleToolStripMenuItem
            // 
            this.copyFilePathToTitleToolStripMenuItem.Name = "copyFilePathToTitleToolStripMenuItem";
            this.copyFilePathToTitleToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.copyFilePathToTitleToolStripMenuItem.Text = "Copy File Path to Title";
            this.copyFilePathToTitleToolStripMenuItem.Click += new System.EventHandler(this.copyFilePathToTitleToolStripMenuItem_Click);
            // 
            // addtext
            // 
            this.addtext.Name = "addtext";
            this.addtext.Size = new System.Drawing.Size(256, 22);
            this.addtext.Text = "Append/Prepend Text";
            this.addtext.Click += new System.EventHandler(this.addtext_Click);
            // 
            // replacechar
            // 
            this.replacechar.Name = "replacechar";
            this.replacechar.Size = new System.Drawing.Size(256, 22);
            this.replacechar.Text = "Replace A Character With Another";
            this.replacechar.Click += new System.EventHandler(this.replacechar_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usercheckfirst,
            this.titlecheckCB,
            this.capitaliseWordsCB,
            this.spacesAfterCommasToolStripMenuItem,
            this.dontsave});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // usercheckfirst
            // 
            this.usercheckfirst.Checked = true;
            this.usercheckfirst.CheckOnClick = true;
            this.usercheckfirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.usercheckfirst.Name = "usercheckfirst";
            this.usercheckfirst.Size = new System.Drawing.Size(516, 22);
            this.usercheckfirst.Text = "Prompt The User For All File Changes";
            this.usercheckfirst.ToolTipText = "Prompt the user for all changes to be made to files";
            // 
            // titlecheckCB
            // 
            this.titlecheckCB.Checked = true;
            this.titlecheckCB.CheckOnClick = true;
            this.titlecheckCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.titlecheckCB.Name = "titlecheckCB";
            this.titlecheckCB.Size = new System.Drawing.Size(516, 22);
            this.titlecheckCB.Text = "If MP3 Title Is Blank, Set From File Path";
            // 
            // capitaliseWordsCB
            // 
            this.capitaliseWordsCB.Checked = true;
            this.capitaliseWordsCB.CheckOnClick = true;
            this.capitaliseWordsCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.capitaliseWordsCB.Name = "capitaliseWordsCB";
            this.capitaliseWordsCB.Size = new System.Drawing.Size(516, 22);
            this.capitaliseWordsCB.Text = "Capitalise DJ and MC if found as a separate word";
            // 
            // spacesAfterCommasToolStripMenuItem
            // 
            this.spacesAfterCommasToolStripMenuItem.Checked = true;
            this.spacesAfterCommasToolStripMenuItem.CheckOnClick = true;
            this.spacesAfterCommasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.spacesAfterCommasToolStripMenuItem.Name = "spacesAfterCommasToolStripMenuItem";
            this.spacesAfterCommasToolStripMenuItem.Size = new System.Drawing.Size(516, 22);
            this.spacesAfterCommasToolStripMenuItem.Text = "Enforce Spaces After Commas and Close Brackets, and Spaces Before Open Brackets";
            // 
            // dontsave
            // 
            this.dontsave.CheckOnClick = true;
            this.dontsave.Name = "dontsave";
            this.dontsave.Size = new System.Drawing.Size(516, 22);
            this.dontsave.Text = "Don\'t Save These Options to Config File";
            // 
            // itemnumber
            // 
            this.itemnumber.Text = "Item Number";
            this.itemnumber.Width = 82;
            // 
            // fileList
            // 
            this.fileList.AllowDrop = true;
            this.fileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(87, 24);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(886, 401);
            this.fileList.TabIndex = 0;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.SelectedIndexChanged += new System.EventHandler(this.fileList_SelectedIndexChanged);
            this.fileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.fileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.fileList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fileList_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 425);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music File Info Editor 1.5";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private ANDREICSLIB.ListViewUpdate fileList;
		private System.Windows.Forms.ColumnHeader itemnumber;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button movedownbutton;
		private System.Windows.Forms.Button moveupbutton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshFilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearItemsToolStripMenuItem;
		private System.Windows.Forms.Button removebutton;
		private System.Windows.Forms.Button additems;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem camelcase;
		private System.Windows.Forms.ToolStripMenuItem autoincrement;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usercheckfirst;
        private System.Windows.Forms.ToolStripMenuItem removeTextFromFrontOrBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titlecheckCB;
        private System.Windows.Forms.ToolStripMenuItem copyFilePathToTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addtext;
		private System.Windows.Forms.ToolStripMenuItem replacechar;
		private System.Windows.Forms.ToolStripMenuItem capitaliseWordsCB;
		private System.Windows.Forms.ToolStripMenuItem spacesAfterCommasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dontsave;
	}
}

