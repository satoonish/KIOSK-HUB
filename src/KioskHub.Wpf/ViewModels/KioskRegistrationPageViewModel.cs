using Microsoft.WindowsAPICodePack.Dialogs;
using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskHub.Wpf.ViewModels
{
    public class KioskRegistrationPageViewModel
    {
        public ReactivePropertySlim<string> KioskAppPath { get; } = new();

        public ReactiveCommandSlim KioskOnCommand { get; } = new();
    }
}
