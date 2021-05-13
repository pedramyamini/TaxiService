using BehComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utility
{
    public static class MessageBoxRTL
    {
        public static void Info(string text, string caption)
        {
            MessageBoxFarsi.Show(text, caption, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information);
        }

        public static void Error(string text, string caption)
        {
            MessageBoxFarsi.Show(text, caption, MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
        }

        public static DialogResult Ask(string text, string caption)
        {
            DialogResult dr = MessageBoxFarsi.Show(text, caption, MessageBoxFarsiButtons.OkCancel, BehComponents.MessageBoxFarsiIcon.Question);
            return dr;
        }


    }
}
