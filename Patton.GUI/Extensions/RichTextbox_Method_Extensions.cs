using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPostman.Extensions
{
    public static class RichTextbox_Method_Extensions
    {
        public static void HighlightText(this RichTextBox myRtb, string word, Color foreColor,Color backColor)
        {

            if (word == string.Empty)
                return;

            int s_start = myRtb.SelectionStart, startIndex = 0, index;

            while ((index = myRtb.Text.IndexOf(word, startIndex)) != -1)
            {
                myRtb.Select(index, word.Length);
                myRtb.SelectionColor = foreColor;

                startIndex = index + word.Length;
            }

            myRtb.SelectionStart        = s_start;
            myRtb.SelectionLength       = 0;
            myRtb.SelectionColor        = Color.Black;
            
        }
    }
}
