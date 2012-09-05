using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;

namespace Music_File_Info_Editor
{
	public partial class usercheck : Form
	{
		public bool makeChanges = false;
		public bool cancelval = false;
		public bool noChanges = false;

		public usercheck(List<ListViewItem> before, List<ListViewItem> after)
		{
			InitializeComponent();

			foreach (var LVI in before)
				beforelist.Items.Add(LVI);

			foreach (var LVI in after)
				afterlist.Items.Add(LVI);

			var changes = 0;

			for (var a = 0; a < afterlist.Items.Count; a++)
			{
				var str1 = beforelist.Items[a].SubItems[1].Text;
				var str2 = afterlist.Items[a].SubItems[1].Text;
				var diff = str1.CompareTo(str2);
				if (diff != 0)
				{
					afterlist.Items[a].BackColor = Color.LightBlue;
					changes++;
				}
				else
					afterlist.Items[a].BackColor = Color.White;
			}

			if (changes == 0)
			{
				noChanges = true;
				this.Close();
				return;
			}
            ListViewUpdate.AutoResize(afterlist);
            ListViewUpdate.AutoResize(beforelist);

		}

		private void okbutton_Click(object sender, EventArgs e)
		{
			makeChanges = true;
			this.Close();
		}

		private void cancel_Click(object sender, EventArgs e)
		{
			makeChanges = false;
			this.Close();
		}

		private void cancelbutton_Click(object sender, EventArgs e)
		{
			cancelval = true;
			this.Close();
		}


	}
}