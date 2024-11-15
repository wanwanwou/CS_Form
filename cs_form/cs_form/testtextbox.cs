﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_form
{
    class testtextbox : TextBox
    {
        public testtextbox(string str, int x, int y, int width, int height)
        {
            Text = str;

            Location = new Point(x, y);

            Size= new Size(width, height);
        }

    }
}
