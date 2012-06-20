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
    public partial class replacechar : Form
    {
        public replacechar()
        {
            InitializeComponent();
        }

        public char result1 = '\0';
        public char result2 = '\0';
		public String titleExample = "";
		public String albumExample = "";
		public String artistExample = "";
		String otherExample = "abcdefghijklmnopqrstuvwxyz";

        public bool titleoptionb = false;
        public bool artistoptionb = false;
        public bool albumoptionb = false;

        private void okbutton_Click(object sender, EventArgs e)
        {
            result1 = char.Parse(changethis.Text);
            result2 = char.Parse(tothis.Text);

            if (artistoption.Checked)
                artistoptionb = true;
            else if (albumoption.Checked)
                albumoptionb = true;
            else if (titleoption.Checked)
                titleoptionb = true;

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

			var a = ' ';
			
			var b = ' ';


			var newtext = "";
			try
			{
				a=char.Parse(changethis.Text);
				b=char.Parse(tothis.Text);
				newtext = ex.Replace(a, b);
			}
			catch
			{
				newtext = ex;
			}
			exampletext1.Text = ex;
			exampletext2.Text = newtext;
		}


        private void cancelbutton_Click(object sender, EventArgs e)
        {
            result1 =result2 = '\0';
            this.Close();
        }

        private void replacechar_Load(object sender, EventArgs e)
        {
			updateExample();
        }

		private void changethis_TextChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void tothis_TextChanged(object sender, EventArgs e)
		{
			updateExample();
		}

		private void titleoption_CheckedChanged(object sender, EventArgs e)
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
