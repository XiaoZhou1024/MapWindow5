﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Plugins.Mvp
{
    /// <summary>
    /// Base presenter with command enumeration.
    /// </summary>
    /// <typeparam name="TView">The type of the view.</typeparam>
    /// <typeparam name="TCommand">The type of the command.</typeparam>
    public abstract class ComplexPresenter<TView, TCommand> : CommandDispatcher<TView, TCommand>, IPresenter
        where TCommand : struct, IConvertible
        where TView : IComplexView
    {
        protected ComplexPresenter(TView view)
            : base(view)
        {
        }

        public abstract bool Run(bool modal = true);
    }

    /// <summary>
    /// Base presenter with command enumeration and argument.
    /// </summary>
    /// <typeparam name="TView">The type of the view.</typeparam>
    /// <typeparam name="TCommand">The type of the command.</typeparam>
    /// <typeparam name="TArg">The type of the argument.</typeparam>
    public abstract class ComplexPresenter<TView, TCommand, TArg> : CommandDispatcher<TView, TCommand>, IPresenter<TArg>
        where TCommand : struct, IConvertible
        where TView : IComplexView
    {
        protected ComplexPresenter(TView view)
            : base(view)
        {
        }

        public abstract bool Run(TArg argument, bool modal = true);
    }
}
