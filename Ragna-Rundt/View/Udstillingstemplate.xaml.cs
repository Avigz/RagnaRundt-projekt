﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.AppExtensions;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Editing;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Ragna_Rundt.Model;
using Ragna_Rundt.Viewmodel;


namespace Ragna_Rundt.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Udstillingstemplate : Page
    {
        public Udstillingstemplate()
        {
            
            this.InitializeComponent();
            VideoLink.NavigateToString($"<iframe height=\"768\" width=\"1024\" src="+$"{ViewModel.Catalog.VideoLink(ViewModel.Key)}"+ "frameborder=\"0\" allow=\"accelerometer; encrypted-media; gyroscope; controls=0; picture-in-picture\"></iframe>");
            

        }
    }
}
