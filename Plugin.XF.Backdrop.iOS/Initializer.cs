﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Plugin.XF.Backdrop.iOS
{
    public class Initializer
    {
        public static void Init()
        {
            Renderer.RoundedCornerStackLayoutRenderer.Init();
        }
    }
}