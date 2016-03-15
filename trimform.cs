using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;

namespace Music_File_Info_Editor
{
    public partial class trimform : Form
    {
        String otherExample = "test text abcdefg";
        public String titleExample = "";
        public String albumExample = "";
        public String artistExample = "";

        public trimform()
        {
            InitializeComponent();
        }

        public int result = -1;
        public bool titleoptionb = false;
        public bool artistoptionb = false;
        public bool albumoptionb = false;

        public bool isfront = false;


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

            var trimfront = false;
            if (frontbutton.Checked)
                trimfront = true;

            var len = 0;

            var newtext = "";

            if (trimlength.Text.Length > 0)
            {
                len = int.Parse(trimlength.Text);

                newtext = StringExtras.ApplyTrim(ex, trimfront, len);
            }
            else
                newtext = ex;

            exampletext1.Text = ex;
            exampletext2.Text = newtext;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void frontbutton_CheckedChanged(object sender, EventArgs e)
        {
            updateExample();
        }

        private void rearbutton_CheckedChanged(object sender, EventArgs e)
        {
            updateExample();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateExample();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            result = -1;
            this.Close();
        }

        private void applybutton_Click(object sender, EventArgs e)
        {
            result = int.Parse(trimlength.Text);

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

        private void trimform_Load(object sender, EventArgs e)
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
