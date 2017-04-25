using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dactylo
{
    class Dactylo
    {
        private string _texteExemple;
        private int _progression;
        private int _total;
        public string TexteExemple
        {
            get
            {
                return _texteExemple;
            }

            set
            {
                _texteExemple = value;
            }
        }
        public int Progression
        {
            get
            {
                return _progression;
            }

            set
            {
                _progression = value;
            }
        }
        public int Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
            }
        }

        public Dactylo(string paramText)
        {
            this.Progression = 0;
            this.TexteExemple = paramText;
            this.Total = TexteExemple.Length;
        }
    }
}
