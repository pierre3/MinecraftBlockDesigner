﻿using Microsoft.Win32;
using Mine2DDesigner.Services;
using Mine2DDesigner.ViewModels;
using System;
using System.Windows;

namespace Mine2DDesigner.Views
{
    public class NewProjectWindowService : IDialogService
    {
        public Type VmType { get; } = typeof(NewProjectWindowViewModel);
        private readonly Window owner;
        public NewProjectWindowService(Window owner)
        {

            this.owner = owner;
        }

        public bool? ShowDialog(IDialogViewModel vm)
        {
            var window = new NewProjectWindow(vm);
            window.Owner = owner;
            return window.ShowDialog();
        }
    }
}
