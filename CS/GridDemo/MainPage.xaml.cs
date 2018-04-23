using App2.ServiceReference1;
using DevExpress.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Service1Client Service1 = new Service1Client();
        public AsyncCollection<Item> Items { get; set; }
        public MainPage()
        {
            this.InitializeComponent();

            Items = new AsyncCollection<Item>(
                async () =>
                {
                    return await Service1.CountAsync();
                },
                async (int skipCount, int takeCount) =>
                {
                    Debug.WriteLine(string.Format("skip {0}; take {1}", skipCount, takeCount));
                    return await Service1.GetDataAsync(skipCount, takeCount);
                });
            grid.ItemsSource = Items;
        }
    }
}