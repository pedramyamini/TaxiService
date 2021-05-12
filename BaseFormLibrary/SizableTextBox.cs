﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseFormLibrary
{
    public class SizableTextBox : TextBox
    {
        public SizableTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            this.Font = new System.Drawing.Font("IRANYekan", 12F, FontStyle.Regular);
            this.Multiline = true;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
            base.OnKeyDown(e);
        }
    }
}