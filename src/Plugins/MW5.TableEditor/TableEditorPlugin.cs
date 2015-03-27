﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MW5.Plugins.Concrete;
using MW5.Plugins.Interfaces;
using MW5.Plugins.Mef;
using MW5.Plugins.TableEditor.BO;
using MW5.Plugins.TableEditor.Forms;
using MW5.Plugins.TableEditor.Helpers;
using MW5.Plugins.TableEditor.Menu;
using MW5.UI.Helpers;


namespace MW5.Plugins.TableEditor
{
    [PluginExport()]
    public class TableEditorPlugin: BasePlugin
    {
        private IAppContext _context;
        private MenuListener _menuListener;
        private MapListener _mapListener;
        private MenuGenerator _menuGenerator;

        static TableEditorPlugin()
        {
            EnumHelper.RegisterConverter(new AttributeTypeConverter());
        }

        public override void Initialize(IAppContext context)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            CompositionRoot.Compose(context.Container);

            _menuGenerator = _context.Container.GetInstance<MenuGenerator>();
            _menuListener = _context.Container.GetSingleton<MenuListener>();
            _mapListener = _context.Container.GetSingleton<MapListener>();
        }

        public override void Terminate()
        {
            
        }
    }
}
