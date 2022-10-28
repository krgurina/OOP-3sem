using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Magazine : PrintedEdiction
    {
        public static int amount = 0;
        private string themes;
        public string Themes
        {
            get { return themes; }
            set { themes = value; }
        }
        public Magazine(string _PublishName, string _title, int _PublishYear, int _Cost, string _Themes)
           : base(_PublishName, _title, _PublishYear, _Cost)
        {
            Themes = _Themes;
            amount++;
        }

        public override string ToString()
        {
            return base.ToString() + "\nТематика: " + themes;
        }
    }
}
