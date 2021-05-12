using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public static class MessageBoxRTL
    {
        public static void Info(string text,string caption)
        {
            BehComponents.MessageBoxFarsi.Show(text,caption, BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Information);
        }

        public static void Error(string text, string caption)
        {
            BehComponents.MessageBoxFarsi.Show(text, caption, BehComponents.MessageBoxFarsiButtons.OK, BehComponents.MessageBoxFarsiIcon.Error);
        }

        public static DialogResult Ask(string text, string caption)
        {
            DialogResult dr= BehComponents.MessageBoxFarsi.Show(text, caption, BehComponents.MessageBoxFarsiButtons.OkCancel, BehComponents.MessageBoxFarsiIcon.Question);
            return dr;
        }

        
    }
}
