using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BindingCodeBehind
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _testo; public string Testo { get => _testo; set { Set(() => Testo, ref _testo, value); }}
    }
}
