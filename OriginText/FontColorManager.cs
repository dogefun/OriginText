using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OriginText
{
    class FontColorManager
    {
        private static FontColorManager instance;
        private List<TokenInfo> messagesList;
        private List<Token> tokenList;
        private OriginTokenizer.Scanner scanner;
        private OriginTokenizer.ScannerInfo info;
        //private RichTextBox textArea;
        public static FontColorManager Manager
        {
            get
            {
                if(instance == null)
                {
                    instance = new FontColorManager();
                }
                return instance;
            }
        }

        public FontColorManager()
        {
        }

        public void SetTokenMessagePlan(List<TokenInfo> list)
        {
            messagesList = list;
            info = new OriginTokenizer.ScannerInfo();
            
            foreach (var x in list)
            {
                info.AddRegex(x.Regex);
            }
            var space = OriginTokenizer.RegularExpression.CreateWithLiteral(" ");
            space.Describtion = "space break";
            info.AddRegex(space);
            info.GenerateData();
            scanner = new OriginTokenizer.Scanner(info);
            scanner.SetSkipTokenRegex(space);
        }
        //public void AddRegex(OriginTokenizer.RegularExpression regex,Color color)
        //{
        //    messagesList.Add(new TokenMessage(regex, color));
        //    info.AddRegex(regex);
        //} 
        //public void SetTextBox(RichTextBox tb)
        //{
        //    textArea = tb;
        //}
        public void Update(RichTextBox tb)
        {
            if(messagesList == null)
            {
                return;
            }

            scanner.SetSource(tb.Text);
            var list = scanner.ReadAll();
            tokenList = new List<Token>();
            foreach (var x in list)
            {
                var info = messagesList.Find(a => a.Regex.Index == x.Index);
                var token = new Token(info, tb, x.startPosition, x.value.Length);
                tokenList.Add(token);
                token.Effect();
            }
        }
    }
}
