using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ANDREICSLIB;

namespace Music_File_Info_Editor
{
    public partial class Form1 : Form
    {
        private static string configPath = "MFIE.cfg";
        List<String> cols = new List<string>();

        #region licensing
        private const string AppTitle = "Music File Info Editor";
        private const double AppVersion = 1.8;
        private const String HelpString = "";

        private const String UpdatePath = "https://github.com/EvilSeven/Music-File-Info-Editor/zipball/master";
        private const String VersionPath = "https://raw.github.com/EvilSeven/Music-File-Info-Editor/master/INFO/version.txt";
        private const String ChangelogPath = "https://raw.github.com/EvilSeven/Music-File-Info-Editor/master/INFO/changelog.txt";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets/ID3 Tagging © CSID3LIB (http://sourceforge.net/projects/csid3lib/)";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            var files = (string[])e.Data.GetData(DataFormats.FileDrop);
            Controller.DropInFiles(files,fileList);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Controller.Initcols(cols);
            ListViewUpdate.InitColumnHeaders(fileList,cols);
            loadConfig();

            Licensing.CreateLicense(this, HelpString, AppTitle, AppVersion, OtherText, VersionPath, UpdatePath, ChangelogPath, menuStrip1);
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controller.RefreshInfo(fileList);
            ListViewUpdate.AutoResize(fileList);
        }

        private void fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            removebutton.Enabled = true;
            camelcase.Enabled = true;

            if (fileList.SelectedItems.Count == 0)
            {
                removebutton.Enabled = false;
                camelcase.Enabled = false;
            }

            moveupbutton.Enabled = false;
            movedownbutton.Enabled = false;

            if (fileList.SelectedItems.Count != 1)
                return;

            var index = int.Parse(fileList.SelectedItems[0].Text);

            if (index > 0)
                moveupbutton.Enabled = true;

            if (index < (fileList.Items.Count - 1))
                movedownbutton.Enabled = true;
        }

        private void moveupbutton_Click(object sender, EventArgs e)
        {
            var index = int.Parse(fileList.SelectedItems[0].Text);

            var one = (ListViewItem)fileList.Items[index].Clone();

            var b1 = index - 1;

            var two = (ListViewItem)fileList.Items[b1].Clone();
            ListViewUpdate.SwapIndicies(fileList,index, b1);

            fileList.Items[b1].Name = two.Text;
            fileList.Items[index].Name = one.Text;

            fileList.SelectedIndices.Clear();
            fileList.SelectedIndices.Add(b1);
        }

        private void movedownbutton_Click(object sender, EventArgs e)
        {
            var index = int.Parse(fileList.SelectedItems[0].Text);

            var one = (ListViewItem)fileList.Items[index].Clone();

            var b1 = index + 1;

            var two = (ListViewItem)fileList.Items[b1].Clone();

            ListViewUpdate.SwapIndicies(fileList, index, b1);

            fileList.Items[b1].Name = two.Text;
            fileList.Items[index].Name = one.Text;

            fileList.SelectedIndices.Clear();
            fileList.SelectedIndices.Add(b1);
        }

        private void clearItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileList.Clear();
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in fileList.SelectedItems)
            {
                fileList.Items.Remove(LVI);
            }
        }

        private void additems_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To add MP3's, drag them onto the window to the right");
        }

        private void fileList_KeyPress(object sender, KeyPressEventArgs e)
        {
            //select all
            if (e.KeyChar == 1)
            {
                ListViewUpdate.SelectAllItems(fileList);
            }
        }

        private void autoincrement_Click_1(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files are selected");
                return;
            }
            var sel = GetSelectedItems();

            if (titlecheckCB.Checked)
            {
                if (changes.testTitles(Controller.getMP3Tags(sel), false, usercheckfirst.Checked) == false)
                    return;
            }

            changes.autoIncrement(Controller.getMP3Tags(sel), usercheckfirst.Checked);

            Controller.RefreshInfo(fileList);
        }


        private void autocapitalise_Click_1(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files are selected");
                return;
            }

            var sel = GetSelectedItems();

            if (titlecheckCB.Checked)
            {
                if (changes.testTitles(Controller.getMP3Tags(sel), false, usercheckfirst.Checked) == false)
                    return;
            }

            changes.autoCapitalise(Controller.getMP3Tags(sel), usercheckfirst.Checked, capitaliseWordsCB.Checked, spacesAfterCommasToolStripMenuItem.Checked);

            Controller.RefreshInfo(fileList);
        }

        private List<ListViewItem> GetSelectedItems(ListView.SelectedListViewItemCollection slvic=null)
        {
            return fileList.SelectedItems.Cast<ListViewItem>().ToList();
        }

        private void removeTextFromFrontOrBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files are selected");
                return;
            }

            var sel = GetSelectedItems();


            if (titlecheckCB.Checked)
            {
                if (changes.testTitles(Controller.getMP3Tags(sel), false, usercheckfirst.Checked) == false)
                    return;
            }

            changes.trimText(Controller.getMP3Tags(sel), usercheckfirst.Checked);

            Controller.RefreshInfo(fileList);
        }

        private void copyFilePathToTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                if (fileList.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No files are selected");
                    return;
                }

                var sel = GetSelectedItems();

                if (titlecheckCB.Checked)
                {
                    if (changes.testTitles(Controller.getMP3Tags(sel), true, usercheckfirst.Checked) == false)
                        return;
                }

                Controller.RefreshInfo(fileList);
            }
        }

        private void addtext_Click(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files are selected");
                return;
            }

            var sel = GetSelectedItems();

            if (titlecheckCB.Checked)
            {
                if (changes.testTitles(Controller.getMP3Tags(sel), false, usercheckfirst.Checked) == false)
                    return;
            }

            changes.addText(Controller.getMP3Tags(sel), usercheckfirst.Checked);

            Controller.RefreshInfo(fileList);
        }

        private void replacechar_Click(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count == 0)
            {
                MessageBox.Show("No files are selected");
                return;
            }
            var sel = GetSelectedItems();

            if (titlecheckCB.Checked)
            {
                if (changes.testTitles(Controller.getMP3Tags(sel), false, usercheckfirst.Checked) == false)
                    return;
            }

            changes.replaceChar(Controller.getMP3Tags(sel), usercheckfirst.Checked);

            Controller.RefreshInfo(fileList);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();
        }

        public void saveConfig()
        {
            var savethese1 = new List<Control>();
            var savethese2 = new List<ToolStripItem>();

            if (dontsave.Checked)
            {
                savethese2.Add(dontsave);
            }
            else
            {
                savethese2.Add(usercheckfirst);
                savethese2.Add(titlecheckCB);
                savethese2.Add(capitaliseWordsCB);
                savethese2.Add(spacesAfterCommasToolStripMenuItem);
            }

            FormConfigRestore.SaveConfig(this, configPath, savethese1, savethese2);
        }

        public void loadConfig()
        {
            FormConfigRestore.LoadConfig(this, configPath);
        }
    }
}