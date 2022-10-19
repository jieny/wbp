﻿using System.Windows;
using Volo.Abp.DependencyInjection;

namespace Umi.Wbp.Dialogs
{
    /// <summary>
    /// Prism's default dialog host.
    /// </summary>
    public partial class DialogWindow : Window, IDialogWindow, ITransientDependency
    {
        /// <summary>
        /// The <see cref="IDialogResult"/> of the dialog.
        /// </summary>
        public IDialogResult Result { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DialogWindow"/> class.
        /// </summary>
        public DialogWindow()
        {
            InitializeComponent();
        }
    }
}