using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ANDREICSLIB;
using Mp3Lib;

namespace Music_File_Info_Editor
{
    public class Controller
    {
        public static void Initcols(List<string> cols)
        {
            cols.Add("Order");
            cols.Add("Album");
            cols.Add("Artist");
            cols.Add("Comment");
            cols.Add("Composer");
            cols.Add("Disc");
            cols.Add("Genre");
            cols.Add("Lyrics");
            cols.Add("Song");
            cols.Add("Title");
            cols.Add("Track");
            cols.Add("Year");
            cols.Add("Path");
        }

        public static ListViewItem initLVI(ListView fileList)
        {
            var LVI = new ListViewItem();

            //ignore first column
            for (var a = 1; a < fileList.Columns.Count; a++)
            {
                LVI.SubItems.Add("");
            }
            return LVI;
        }

        public static void setLVI(ListViewItem IN, String columnName, String text, ListView fileList)
        {
            var col = ListViewUpdate.GetColumnNumber(fileList,columnName);

            IN.SubItems[col].Text = text;
        }

        public static void DropInFiles(string[] files, ListView fileList)
        {
            var acceptall = false;
            var nochanges = false;
            const string YTA = "Yes To All";
            const string nostr = "No";
            const string noallstr = "No To All";
            const string yesstr = "Yes";
            const string cancelstr = "Cancel";

            var l = new List<string>();
            l.Add(YTA);
            l.Add(yesstr);
            l.Add(nostr);
            l.Add(noallstr);
            l.Add(cancelstr);

            foreach (var s in files)
            {
                var LVI = initLVI(fileList);
                LVI.Text = fileList.Items.Count.ToString();
                LVI.Name = LVI.Text;
                LVI.SubItems.Add(s);

                Mp3File mf = null;

                var retrycount = 0;
                var retrymax = 10;
            retry:

                try
                {
                    mf = new Mp3File(s);
                }
                catch (Exception exp)
                {
                    retrycount++;
                    if (retrycount >= retrymax)
                    {
                        MessageBox.Show("Error opening file:" + exp.ToString());

                        var DR = MessageBox.Show("Do you want to continue?", "option", MessageBoxButtons.YesNo);
                        if (DR == DialogResult.No)
                            return;

                        continue;
                    }

                    //for a certain period, retry
                    Thread.Sleep(100);
                    goto retry;
                }

                LVI.Tag = mf;
                var sas = mf.Audio;
                sas.ScanWholeFile();

                //clean files on entry
                var newData = new changes.TagHandlerUpdate(mf);

                if (nochanges == false)
                {
                    Music_File_Info_Editor.changes.cleanMP3(newData);

                    var changes = Music_File_Info_Editor.changes.areThereDifferences(mf, newData);
                    var makechanges = true;
                    if (changes && acceptall == false)
                    {
                        var tt = "The file:" + mf.FileName +
                                    " has a title/album/artist with blank characters at the start or end, or has multiple white space. Do you wish to fix these?";
                        var MMB = new multipleMessageBox("option", tt, l);
                        MMB.ShowDialog();

                        if (MMB.Set == false)
                            return;

                        switch (MMB.Result)
                        {
                            case cancelstr:
                                return;

                            case nostr:
                                makechanges = false;
                                break;

                            case YTA:
                                acceptall = true;
                                break;

                            case noallstr:
                                makechanges = false;
                                nochanges = true;
                                break;
                        }
                    }

                    if (makechanges)
                    {
                        if (Music_File_Info_Editor.changes.makeChangesAndContinue(newData, mf) == false)
                            return;
                    }
                }

                //only add if the name isnt there already
                var add = true;
                foreach (ListViewItem tt in fileList.Items)
                {
                    var s1 = tt.SubItems[ListViewUpdate.GetColumnNumber(fileList, "Path")].Text;

                    if (s1.Equals(mf.FileName))
                    {
                        add = false;
                        break;
                    }
                }

                if (add)
                    fileList.Items.Add(LVI);
            }
            
            RefreshInfo(fileList);
            ListViewUpdate.AutoResize(fileList);
        }

        public static void RefreshInfo(ListView fileList)
        {
            foreach (ListViewItem LVI in fileList.Items)
            {
                var mm = ((Mp3File)LVI.Tag);
                var TH = ((Mp3File)LVI.Tag).TagHandler;
                setLVI(LVI, "Album", TH.Album, fileList);
                setLVI(LVI, "Artist", TH.Artist, fileList);
                setLVI(LVI, "Comment", TH.Comment, fileList);
                setLVI(LVI, "Composer", TH.Composer, fileList);
                setLVI(LVI, "Disc", TH.Disc, fileList);
                setLVI(LVI, "Genre", TH.Genre, fileList);
                setLVI(LVI, "Lyrics", TH.Lyrics, fileList);
                setLVI(LVI, "Song", TH.Song, fileList);
                setLVI(LVI, "Title", TH.Title, fileList);
                setLVI(LVI, "Track", TH.Track, fileList);
                setLVI(LVI, "Year", TH.Year, fileList);
                setLVI(LVI, "Path", mm.FileName, fileList);
            }
        }

        public static IEnumerable<Mp3File> getMP3Tags(List<ListViewItem> selectedItems)
        {
            foreach(var l in selectedItems)
            {
                yield return ((Mp3File)l.Tag);
            }
            /*
            var count = 0;
            var max = selectedItems.Count;
            while (count < max)
            {
                ListViewItem save = null;
                foreach (var LVI in selectedItems)
                {
                    if (Int32.Parse(LVI.Name).Equals(count))
                    {
                        save = LVI;
                        break;
                    }
                }

                if (save != null)
                {
                    yield return ((Mp3File)save.Tag);
                    selectedItems.Remove(save);
                }
                count++;
            }
             * */
        }
    }
}
