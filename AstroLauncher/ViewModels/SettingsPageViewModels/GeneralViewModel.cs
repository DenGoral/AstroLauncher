using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels.SettingsPageViewModels;

public partial class GeneralViewModel : ViewModelBase
{
    [ObservableProperty] private string _chosenLanguage = "English";
    [ObservableProperty] private int _maxRam = 2048;
    [ObservableProperty] private int _maxDownloads = 2;
    
    public GeneralViewModel()
    {
        DisplayName = "General";
        IconData = (StreamGeometry)Application.Current.FindResource("GeneralIcon");
    }
    
    // available language list
    public ObservableCollection<string> Languages { get; } = new()
    {
        "English", "Russian", "Portuguese", "French", "Spanish",
    };
    
    [RelayCommand]
    private void SetAccent(string hex)
    {
        Application.Current!.Resources["AccentColor"] = new SolidColorBrush(Color.Parse(hex));
    }
}