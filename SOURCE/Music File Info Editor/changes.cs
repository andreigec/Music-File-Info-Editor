using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ANDREICSLIB;
using Mp3Lib;
using Id3Lib;


namespace Music_File_Info_Editor
{
    class changes
    {

        public class TagHandlerUpdate
        {

            public string Album;
            public string Artist;
            public string Comment;
            public string Composer;
            public string Disc;
            public string Genre;
            public string Lyrics;
            public string Song;
            public string Title;
            public string Track;
            public string Year;
            public string Path;

            public TagHandlerUpdate(Mp3Lib.Mp3File mff)
            {
                var TH = mff.TagHandler;
                this.Album = TH.Album;
                Artist = TH.Artist;
                Comment = TH.Comment;
                Composer = TH.Composer;
                Disc = TH.Disc;
                Genre = TH.Genre;
                Lyrics = TH.Lyrics;
                Song = TH.Song;
                Title = TH.Title;
                Track = TH.Track;
                Year = TH.Year;
                Path = mff.FileName;
            }

            public void copy(Id3Lib.TagHandler TH)
            {
                TH.Album = this.Album;
                TH.Artist = Artist;
                TH.Comment = Comment;
                TH.Composer = Composer;
                TH.Disc = Disc;
                TH.Genre = Genre;
                TH.Lyrics = Lyrics;
                TH.Song = Song;
                TH.Title = Title;
                TH.Track = Track;
                TH.Year = Year;
                //dont copy path, since that wouldnt do anything
            }

            public Dictionary<String, String> toDict()
            {
                var ret = new Dictionary<string, string>();
                ret.Add("Album", Album);
                ret.Add("Artist", Artist);
                ret.Add("Comment", Comment);
                ret.Add("Composer", Composer);
                ret.Add("Disc", Disc);
                ret.Add("Genre", Genre);
                ret.Add("Lyrics", Lyrics);
                ret.Add("Song", Song);
                ret.Add("Title", Title);
                ret.Add("Track", Track);
                ret.Add("Year", Year);
                ret.Add("Path", Path);
                return ret;
            }
        }

        private static Dictionary<String, String> TagHandlerToDict(Mp3Lib.Mp3File mpf)
        {
            var TH = mpf.TagHandler;
            var ret = new Dictionary<string, string>();
            ret.Add("Album", TH.Album);
            ret.Add("Artist", TH.Artist);
            ret.Add("Comment", TH.Comment);
            ret.Add("Composer", TH.Composer);
            ret.Add("Disc", TH.Disc);
            ret.Add("Genre", TH.Genre);
            ret.Add("Lyrics", TH.Lyrics);
            ret.Add("Song", TH.Song);
            ret.Add("Title", TH.Title);
            ret.Add("Track", TH.Track);
            ret.Add("Year", TH.Year);
            ret.Add("Path", mpf.FileName);
            return ret;
        }

        public static bool areThereDifferences(Mp3File orig, TagHandlerUpdate newData)
        {
            var UC = new usercheck(DictionaryUpdates.DictToListOfListViewItems(TagHandlerToDict(orig)),
                DictionaryUpdates.DictToListOfListViewItems(newData.toDict()));

            if (UC.noChanges)
                return false;
            
            return true;
        }


        //title from path
        public static bool testTitles(IEnumerable<Mp3Lib.Mp3File> list, bool force, bool checkFirst)
        {
            foreach (var MF in list)
            {
                var newData = new TagHandlerUpdate(MF);

                var orig = MF.TagHandler;

                if (orig.Title.Length == 0 || force)
                {
                    var title = MF.FileName;
                    title = title.Substring(title.LastIndexOf('\\') + 1);
                    title = title.Substring(0, title.LastIndexOf('.'));

                    newData.Title = title;
                    if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// copy the newdata to the original.
        /// </summary>
        /// <param name="newData"></param>
        /// <param name="orig"></param>
        /// <returns>always true</returns>
        public static bool makeChangesAndContinue(TagHandlerUpdate newData,  Mp3File orig)
    {
            newData.copy(orig.TagHandler);

            var retrycount = 0;
            var maxretry = 10;
        retry:
            try
            {
                orig.Update();
            }
            catch (Exception ecp)
            {
                retrycount++;
                if (retrycount >= maxretry)
                {
                    MessageBox.Show("Changes could not be made-" + ecp.ToString());
                    return true;
                }
                System.Threading.Thread.Sleep(100);
                goto retry;
            }

        return true;
    }


        /// <summary>
        /// Ask the user if they want changes to be made. if yes, then make the changes, if no, return true, if cancel, return false
        /// </summary>
        /// <param name="newData">the copied mp3files taghandler</param>
        /// <param name="orig">the original mp3file</param>
        /// <param name="checkFirst"></param>
        /// <returns>return false if the user wants to cancel all changes, true in any other case</returns>
        public static bool queryUserMakeChangesAndContinue(TagHandlerUpdate newData, Mp3Lib.Mp3File orig, bool checkFirst)
        {
            usercheck UC = null;
            if (checkFirst)
            {
                if (areThereDifferences(orig, newData) == false)
                {
                    MessageBox.Show("No changes need to be made for this file");
                }
                else
                {
                    UC = new usercheck(DictionaryUpdates.DictToListOfListViewItems(TagHandlerToDict(orig)),
                DictionaryUpdates.DictToListOfListViewItems(newData.toDict()));
                    UC.ShowDialog();
                }

                if (UC==null||UC.cancelval)
                    return false;
                if (UC.makeChanges == false)
                    return true;
            }

            return makeChangesAndContinue(newData,orig);
        }

        public static void cleanMP3(TagHandlerUpdate TH)
        {
            TH.Title = ANDREICSLIB.StringUpdates.cleanString(TH.Title);
            TH.Album = ANDREICSLIB.StringUpdates.cleanString(TH.Album);
            TH.Artist = ANDREICSLIB.StringUpdates.cleanString(TH.Artist);
        }

        public static void autoCapitalise(IEnumerable<Mp3Lib.Mp3File> mp3s, bool checkFirst,bool capSpecials,bool spaceAfter)
        {
			var CWS = new List<string>();
			if (capSpecials)
			{
				CWS.Add("dj");
				CWS.Add("mc");
			}

			foreach (var MF in mp3s)
            {
                var newData = new TagHandlerUpdate(MF);

                var orig = MF.TagHandler;

				newData.Title = ANDREICSLIB.StringUpdates.ToCamelCase(newData.Title, true, CWS, spaceAfter);
				newData.Album = ANDREICSLIB.StringUpdates.ToCamelCase(newData.Album, true, CWS, spaceAfter);
				newData.Artist = ANDREICSLIB.StringUpdates.ToCamelCase(newData.Artist, true, CWS, spaceAfter);

                if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                    return;
            }
        }

        public static void autoIncrement(IEnumerable<Mp3Lib.Mp3File> mp3s, bool checkFirst)
        {
            var trackno = 0;

            foreach (var MF in mp3s)
            {
                var newData = new TagHandlerUpdate(MF);
                var orig = MF.TagHandler;

                if (trackno == 0)
                {
                    var DR = MessageBox.Show("Do you want to start at the first tracks track number?", "question", MessageBoxButtons.YesNoCancel);
                    if (DR == DialogResult.Cancel)
                        return;

                    if (newData.Track == null || newData.Track == "" || DR == DialogResult.No || int.Parse(newData.Track) < 1)
                        trackno = 1;
                    else
                        trackno = int.Parse(newData.Track);
                }

                newData.Track = trackno.ToString();

                trackno++;

                if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                    return;
            }
        }

        public static void trimText(IEnumerable<Mp3Lib.Mp3File> mp3s, bool checkFirst)
        {

			var newDataEX = new TagHandlerUpdate(mp3s.First());

			var TF = new trimform();
			TF.titleExample = newDataEX.Title;
			TF.albumExample = newDataEX.Album;
			TF.artistExample = newDataEX.Artist;

			TF.ShowDialog();
            if (TF.result == -1)
                return;

            foreach (var MF in mp3s)
            {
                var newData = new TagHandlerUpdate(MF);

                var orig = MF.TagHandler;

                if (TF.titleoptionb)
                {
                    newData.Title = ANDREICSLIB.StringUpdates.ApplyTrim(newData.Title, TF.isfront, TF.result);
                }
                else if (TF.albumoptionb)
                {
                    newData.Album = ANDREICSLIB.StringUpdates.ApplyTrim(newData.Album, TF.isfront, TF.result);
                }
                else if (TF.artistoptionb)
                {
                    newData.Artist = ANDREICSLIB.StringUpdates.ApplyTrim(newData.Artist, TF.isfront, TF.result);
                }

                if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                    return;
            }
        }

        public static void addText(IEnumerable<Mp3Lib.Mp3File> mp3s, bool checkFirst)
        {
            var AF = new addtext();
			var newDataEX = new TagHandlerUpdate(mp3s.First());
			AF.titleExample = newDataEX.Title;
			AF.albumExample = newDataEX.Album;
			AF.artistExample = newDataEX.Artist;

            AF.ShowDialog();
            if (AF.result == null)
                return;

            foreach (var MF in mp3s)
            {
                var newData = new TagHandlerUpdate(MF);

                var orig = MF.TagHandler;

                if (AF.titleoptionb)
                {
                    newData.Title = ANDREICSLIB.StringUpdates.addText(newData.Title,AF.result, AF.isfront );
                }
                else if (AF.albumoptionb)
                {
                    newData.Album = ANDREICSLIB.StringUpdates.addText(newData.Album,AF.result, AF.isfront);
                }
                else if (AF.artistoptionb)
                {
                    newData.Artist = ANDREICSLIB.StringUpdates.addText(newData.Artist,AF.result, AF.isfront);
                }

                if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                    return;
            }
        }

        public static void replaceChar(IEnumerable<Mp3Lib.Mp3File> mp3s, bool checkFirst)
        {
            var RC = new replacechar();

			var newDataEX = new TagHandlerUpdate(mp3s.First());
			RC.titleExample = newDataEX.Title;
			RC.albumExample = newDataEX.Album;
			RC.artistExample = newDataEX.Artist;

            RC.ShowDialog();
            if (RC.result1 == '\0')
                return;

            foreach (var MF in mp3s)
            {
                var newData = new TagHandlerUpdate(MF);

                var orig = MF.TagHandler;

                if (RC.titleoptionb)
                {
                    newData.Title = ANDREICSLIB.StringUpdates.replaceAllChars(newData.Title, RC.result1, RC.result2);
                }
                else if (RC.albumoptionb)
                {
                    newData.Album = ANDREICSLIB.StringUpdates.replaceAllChars(newData.Album, RC.result1, RC.result2);
                }
                else if (RC.artistoptionb)
                {
                    newData.Artist = ANDREICSLIB.StringUpdates.replaceAllChars(newData.Artist, RC.result1, RC.result2);
                }

                if (queryUserMakeChangesAndContinue(newData, MF, checkFirst) == false)
                    return;
            }
        }

    }
}
