﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Plugins.Interfaces;

namespace MW5.Plugins.Concrete
{
    public class DockPanelEventArgs: EventArgs
    {
        public DockPanelEventArgs(IDockPanel panel, string key)
        {
            if (panel == null) throw new ArgumentNullException("panel");
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException("key");

            Panel = panel;
            Key = key;
        }

        public IDockPanel Panel { get; private set; }
        public string Key { get; private set; }
    }
}
