﻿using Mine2DDesigner.Services;
using Mine2DDesigner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Mine2DDesigner.Views
{
    /// <summary>
    /// SelectBlockWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class SelectBlockWindow : Window
    {
        
        public SelectBlockWindow(IDialogViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult= false;
        }

    }
}
