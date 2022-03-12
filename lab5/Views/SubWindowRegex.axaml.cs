using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using lab5.ViewModels;

namespace lab5.Views
{
    public partial class SubWindowRegex : Window
    {
        public delegate MainWindowViewModel? MainWindowContext();
        public event MainWindowContext? MWContext;
        public delegate void OkHandler(string regex);
        public event OkHandler? OkRegexChange;
        public SubWindowRegex()
        {

            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            this.FindControl<Button>("OkButton").Click += async delegate
            {
                OkRegexChange((this.DataContext as MainWindowViewModel).Regex);
                Close();
            };

            this.FindControl<Button>("CancelButton").Click += async delegate
            {
                Close();
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
