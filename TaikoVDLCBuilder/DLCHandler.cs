using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaikoVDLCBuilder
{
    public class DLCHandler
    {
        //Function to initialize conversion
        public static void InitializeDLC(ProgressBar progress, List<SongItem> selectedsongs)
        {
            // Initialize progress bar
            progress.Visible = true;
            progress.Value = 1;
            progress.Minimum = 1;
            // Check if readdcont exist and delete
            if (Directory.Exists(Global.PathDLC))
            {
                MessageBox.Show(Global.MsgDLC2,Global.TlSongSl);
                DeleteDirectory(Global.PathDLC);
            }
            uint uniqueID = 105;
            int folderID = 1;
            string strID;
            progress.Maximum = selectedsongs.Count;
            progress.Step = 1;
            for (int i = 0; i <= (selectedsongs.Count - 1); i++)
            {
                strID = folderID.ToString(Global.HexStart);
                BuildDLC(selectedsongs[i], uniqueID, strID);
                uniqueID++;
                if (selectedsongs[i].starUra > 0) //Songs with Ura takes 2 slots
                    uniqueID++;
                folderID++;
                progress.PerformStep();
            }
            MessageBox.Show(Global.MsgDLC1, Global.TlDLC1);
            progress.Visible = false;
        }
        //Function to copy DLC files to output
        static void BuildDLC(SongItem song, uint id, string folderid)
        {
            string SourcePath = Global.PathSongs + song.folder;
            //Check if folder exist
            if (!Directory.Exists(SourcePath))
            {
                MessageBox.Show(song.folder + Global.MsgDLC3, Global.TlDLC2);
                return;
            }
            string DestinationPath = Global.PathWay1 + folderid + Global.PathWay2;
            Directory.CreateDirectory(DestinationPath);

            //Now Create all of the directories
            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            //Copy all the files & Replaces any files with the same name
            foreach (string newPath in Directory.GetFiles(SourcePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);

            //Correct unique ID
            string SongInfoPath = DestinationPath + Global.PathSongDat;
            //Check if file exist
            if (!File.Exists(SongInfoPath))
            {
                MessageBox.Show(Global.MsgDLC4, Global.TlDLC2);
                return;
            }
            //Inject ID function
            InjectID(id, song.starUra, SongInfoPath);
        }
        //Function to inject unique ID into SongInfo.dat
        static void InjectID(uint id, int starUra, string path)
        {
            int IDPos = 60; //ID Position: 0x3C
            int UraPos = 124; //Ura ID Position: 0x7C
            byte[] idbytes = BitConverter.GetBytes(id);
            // inject ID into SongInfo.dat
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
            {
                stream.Position = IDPos;
                stream.WriteByte(idbytes[0]);
                stream.Position = IDPos + 1;
                stream.WriteByte(idbytes[1]);
            }
            // Check if Ura exist in song
            if (starUra > 0)
            {
                byte[] idurabytes = BitConverter.GetBytes(id + 1);
                // inject ura ID into SongInfo.dat
                using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite))
                {
                    stream.Position = UraPos;
                    stream.WriteByte(idurabytes[0]);
                    stream.Position = UraPos + 1;
                    stream.WriteByte(idurabytes[1]);
                    // repeat normal ID after Ura
                    stream.Position = UraPos + 2;
                    stream.WriteByte(idbytes[0]);
                    stream.Position = UraPos + 3;
                    stream.WriteByte(idbytes[1]);
                }
            }
        }
        //Directory Deleter
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        //Function to sort by genre
        public static SongList organizebyGenre(SongList data)
        {
            List<SongItem> organized = new List<SongItem>();
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= (data.Itens.Count - 1); j++)
                {
                    if (data.Itens[j].genreNo == i)
                    {
                        organized.Add(data.Itens[j]);
                    }
                }
            }
            data.Itens = organized;
            return data;
        }
    }
}
