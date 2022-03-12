using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Reactive;
using ReactiveUI;

namespace lab5.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {
        string? path;
        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        string text = "";
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref text, value);
            }
        }

        string regex = "";
        public string Regex
        {
            get
            {
                return regex;
            }
            set
            {
                regex = value;
            }
        }

        string regexNew = "";
        public string RegexNew
        {
            get
            {
                return regexNew;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref regexNew, value);
            }
        }
    }
}
