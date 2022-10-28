using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class Magazine : PrintedEdiction
    {
        private string themes;
        public string Themes
        {
            get { return themes; }
            set { themes = value; }
        }
        public Magazine(string _PublishName, string _title, int _PublishYear, string _Themes)
           : base(_PublishName, _title, _PublishYear)
        {
            Themes = _Themes;
        }

        public override string ToString()
        {
            return base.ToString() + "\nТематика: " + themes;
        }
    }
}
