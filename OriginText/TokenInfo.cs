using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace OriginText
{
    class TokenInfo
    {
        private OriginTokenizer.RegularExpression regex;
        private Color color;
       
        public Color Color
        {
            get
            {
                return color;
            }
        }

        public OriginTokenizer.RegularExpression Regex
        {
            get
            {
                return regex;
            }
        }

        public TokenInfo(OriginTokenizer.RegularExpression rg,Color col)
        {
            color = col;
            regex = rg;
        }
    }
}
