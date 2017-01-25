using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OriginTokenizer;
namespace OriginText
{
    class Token 
    {
        private RichTextBox textBox;
        private TokenInfo info;
        private int position;
        private int length;
        public Token(TokenInfo info, RichTextBox textBox,int pos,int len)
        {
            this.info = info;
            this.textBox = textBox;
            position = pos;
            length = len;
        }
        /// <summary>
        /// change text color
        /// </summary>
        public void Effect()
        {
            var x = textBox.SelectionStart;
            textBox.SelectionStart = position;
            textBox.SelectionLength = length;
            textBox.SelectionColor = info.Color;
            textBox.SelectionStart = x;
        }
    }
}
