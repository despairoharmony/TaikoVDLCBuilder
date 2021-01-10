using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaikoVDLCBuilder
{
    public static class Global
    {
        public static SongList database;
        public const int tslot = 395; //Limit of slots that vita can handle
        public const string HexStart = "D3";
        public const string PathJSON = "Data/songdata.json";
        public const string PathDLC = "readdcont";
        public const string PathSongs = "Data/Songs/";
        public const string PathSongDat = "/_data/system/SongInfo.dat";
        public const string PathWay1 = "readdcont/PCSG00551/TAIKOV1SONG";
        public const string PathWay2 = "JH";
        public const string MsgDLC1 = "All done!\nMove readdcont folder to ux0:";
        public const string MsgDLC2 = "readdcont folder is present and will be deleted.";
        public const string MsgDLC3 = " folder is missing.";
        public const string MsgDLC4 = "SongInfo.dat is missing.";
        public const string MsgJSON = "songdata.json is missing";
        public const string MsgSongSl1 = "You selected ";
        public const string MsgSongSl2 = " songs, using a total of ";
        public const string MsgSongSl3 = " slots.";
        public const string MsgSongSl4 = "\nYou can use more ";
        public const string MsgSongSl5 = "\nDo you want to proceed?";
        public const string MsgSongSl6 = "\nYou can select only 395 slots.\nRemeber: Songs with Oni difficulty takes 2 slots.";
        public const string MsgSongSl7 = "No song has been selected.";
        public const string TlDLC1 = "Clear";
        public const string TlDLC2 = "Error";
        public const string TlSongSl = "Attention";
        public const string WlcmTxt = "Taiko no Tatsujin V Version - DLC Builder (1.0.0)\nMade By DespairOfHarmony\n\nSelect the songs that you wish to play. You can select up to 395 slots, each song will take one slot,\nbut songs with Oni Difficulty will take one more slot.";
    }
}
