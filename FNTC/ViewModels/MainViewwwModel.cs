// MainViewwwModel.cs
using CommunityToolkit.Mvvm.ComponentModel;

namespace FNTC.ViewModels
{
    public partial class MainViewwwModel : ViewModelBase
    {
        // Use a simple field name to avoid generator confusion
        [ObservableProperty]
        private string test = "TANGINAA";

        // optional explicit ctor (parameterless is required for XAML instantiation)
        public MainViewwwModel() { }
    }
}
