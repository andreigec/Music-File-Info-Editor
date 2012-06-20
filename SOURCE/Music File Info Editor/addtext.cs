using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Music_File_Info_Editor
{
    public partial class addtext : Form
    {
        public addtext()
        {
            InitializeComponent();
        }

        public String result = null;
        public bool titleoptionb = false;
        public bool artistoptionb = false;
        public bool albumoptionb = false;

		public String titleExample = "";
		public String albumExample = "";
		public String artistExample = "";
		String otherExample = "abcdefghijklmnopqrstuvwxyz";

        public bool isfront = false;


        private void applybutton_Click_1(object sender, EventArgs e)
        {
            result = textadd.Text;

            if (artistoption.Checked)
                artistoptionb = true;
            else if (albumoption.Checked)
                albumoptionb = true;
            else if (titleoption.Checked)
                titleoptionb = true;

            if (frontbutton.Checked)
                isfront = true;
            else
                isfront = false;
            this.Close();
        }

        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            result = null;
            this.Close();
        }

		private void updateExample()
		{
			var ex = "";
			if (titleoption.Checked)
				ex = titleExample;
			else if (artistoption.Checked)
				ex = artistExample;
			else if (albumoption.Checked)
				ex = albumExample;
			else
				ex = otherExample;

			var newtext = "";

			if (frontbutton.Checked)
				newtext = textadd.Text + ex;
			else
				newtext = ex + textadd.Text;

			exampletext1.Text = ex;
			exampletext2.Text = newtext;
		}

		private void addtext_Load(object sender, EventArgs e)
		{
			updateExample();
		}

		private void frontbutton_CheckedChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void rearbutton_CheckedChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void textadd_TextChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void titleoption_TextChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void albumoption_CheckedChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void artistoption_CheckedChanged(object sender, EventArgs e)
		{
			updateExample();
		}

    }
}
