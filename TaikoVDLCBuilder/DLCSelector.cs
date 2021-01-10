using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TaikoVDLCBuilder
{
    public partial class DLCSelector : Form
    {
        public DLCSelector()
        {
            InitializeComponent();
        }

        private void DLCSelector_Load(object sender, EventArgs e)
        {
            //Check if file exist
            if (!File.Exists(Global.PathJSON))
            {
                MessageBox.Show(Global.MsgJSON);
                System.Environment.Exit(1);
            }
            RunPBar.Visible = false;
            //Parse songdata.json to object
            string jsonfile = File.ReadAllText(Global.PathJSON);
            Global.database = JsonConvert.DeserializeObject<SongList>(jsonfile);
            //Sort by genre
            Global.database = DLCHandler.organizebyGenre(Global.database);
            BindingSource sorce = new BindingSource();
            sorce.DataSource = Global.database.Itens;
            DBView.AutoSize = true;
            DBView.DataSource = sorce;
            DBView.Refresh();
            IntroLabel.Text = Global.WlcmTxt;
        }
        //Run button Click
        private void RunButton_Click(object sender, EventArgs e)
        {
            int nslot = 0;
            int nsong = 0;
            //List selected songs
            List<SongItem> selectedsongs = new List<SongItem>();
            //Check how many songs has been selected
            for (int i = 0; i <= (DBView.Rows.Count - 1); i++)
            {
                if (Global.database.Itens[i].isChecked == true)
                {
                    nsong++;
                    nslot++;
                    //If has Ura add one more slot
                    if (Global.database.Itens[i].starUra > 0)
                    {
                        nslot++;
                    }
                    selectedsongs.Add(Global.database.Itens[i]);
                }
            }
            string ms1 = Global.MsgSongSl1 + nsong + Global.MsgSongSl2 + nslot + Global.MsgSongSl3;
            string ms2 = Global.MsgSongSl4 + (Global.tslot - nslot) + Global.MsgSongSl3;
            //No song selected
            if (nslot == 0)
            {
                MessageBox.Show(Global.MsgSongSl7, Global.TlSongSl);
            } else if (nslot > Global.tslot)  //More songs selected than limit
            {
                MessageBox.Show(ms1 + Global.MsgSongSl6, Global.TlSongSl);
            } else
            {
                //Confirm song selection
                string message = ms1 + ms2 + Global.MsgSongSl5;
                DialogResult result = MessageBox.Show(message, Global.TlSongSl, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    DLCHandler.InitializeDLC(RunPBar,selectedsongs);
                }
            }
        }
        // Organize BG color by genre
        private void DBView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Set BGColor per genre
            foreach (DataGridViewRow row in DBView.Rows)
            {
                SongItem rowObject = (SongItem)row.DataBoundItem;
                row.DefaultCellStyle.BackColor = rowObject.genreColor;
            }
            // Put each of the columns into programmatic sort mode.
            foreach (DataGridViewColumn column in DBView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
        //Randomizer button click
        private void RandomButton_Click(object sender, EventArgs e)
        {
            int rndslt = 0;
            int rndsng = 0;
            Random rnd = new Random();
            int idx;
            //Clear all selection
            ClearDB();
            //Repeat while limit is not reached or number of songs is lower than total
            while (rndslt < Global.tslot)
            {
                //Get a random song
                idx = rnd.Next(DBView.Rows.Count);
                //Select song only if it's not selected
                if (Global.database.Itens[idx].isChecked == false)
                {
                    Global.database.Itens[idx].isChecked = true;
                    rndslt++;
                    rndsng++;
                    //Add 1 more slot if Ura is avaible
                    if (Global.database.Itens[idx].starUra > 0)
                    {
                        rndslt++;
                    }
                }
                if (rndsng == Global.database.Itens.Count)
                {
                    break;
                }
            }
            DBView.Refresh();
        }
        //Clear button click
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearDB();
            DBView.Refresh();
        }
        //Function to clear all selection
        private void ClearDB()
        {
            for (int i = 0; i <= (DBView.Rows.Count - 1); i++)
            {
                Global.database.Itens[i].isChecked = false;
            }
        }
    }
}
