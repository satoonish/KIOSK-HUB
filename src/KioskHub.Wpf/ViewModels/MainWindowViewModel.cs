using KioskHub.Wpf.Views;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KioskHub.Wpf.ViewModels
{
    public class MainWindowViewModel
    {
        public ReactiveProperty<Page> FrameSource { get; } = new();

        public MainWindowViewModel()
        {
            FrameSource.Value = new KioskRegistrationPage();
        }
    }
}
