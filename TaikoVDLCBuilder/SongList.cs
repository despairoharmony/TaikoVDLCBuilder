using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaikoVDLCBuilder
{
    public class SongList
    {
        public List<SongItem> Itens;
    }
    public class SongItem
    {
        // List with genre names
        private readonly string[] gnrNames = {
            "J-POP",
            "VOCALOID",
            "Variety",
            "Namco Original",
            "Game Music",
            "Classic",
            "Anime"
        };
        // List with genre colors
        private readonly Color[] gnrColors = {
            Color.SkyBlue,
            Color.LightGray,
            Color.LimeGreen,
            Color.Salmon,
            Color.Plum,
            Color.Khaki,
            Color.SandyBrown
        };
        // List with star names
        private readonly string[] starNames = {
            "--",
            "★1",
            "★2",
            "★3",
            "★4",
            "★5",
            "★6",
            "★7",
            "★8",
            "★9",
            "★10"
        };
        public bool isChecked { get; set; }
        public string name { get; set; }
        public string nameJP { get; set; }
        public int genreNo { get; set; }
        public string genreName
        {
            get
            {
                try
                {
                    return gnrNames[genreNo];
                }
                catch
                {
                    return String.Empty;
                }
            }
        }
        public Color genreColor
        {
            get
            {
                try
                {
                    return gnrColors[genreNo];
                }
                catch
                {
                    return Color.White;
                }
            }
        }
        public string folder { get; set; }
        public int starEasy { get; set; }
        public string strEasy
        {
            get
            {
                try
                {
                    return starNames[starEasy];
                }
                catch
                {
                    return starNames[0];
                }
            }
        }
        public int starNormal { get; set; }
        public string strNormal
        {
            get
            {
                try
                {
                    return starNames[starNormal];
                }
                catch
                {
                    return starNames[0];
                }
            }
        }
        public int starHard { get; set; }
        public string strHard
        {
            get
            {
                try
                {
                    return starNames[starHard];
                }
                catch
                {
                    return starNames[0];
                }
            }
        }
        public int starMania { get; set; }
        public string strMania
        {
            get
            {
                try
                {
                    return starNames[starMania];
                }
                catch
                {
                    return starNames[0];
                }
            }
        }
        public int starUra { get; set; }
        public string strUra
        {
            get
            {
                try
                {
                    return starNames[starUra];
                }
                catch
                {
                    return starNames[0];
                }
            }
        }
        public string source { get; set; }
    }
}
