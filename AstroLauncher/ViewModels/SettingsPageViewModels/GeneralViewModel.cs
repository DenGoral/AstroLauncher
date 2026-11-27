using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels.SettingsPageViewModels;

public partial class GeneralViewModel : ViewModelBase
{
    [ObservableProperty] private string _chosenLanguage = "English";
    [ObservableProperty] private int _maxRam = 2048;
    [ObservableProperty] private int _maxDownloads = 2;
    private ThemeVariant _selectedTheme = ThemeVariant.Default;
    
    public GeneralViewModel()
    {
        DisplayName = "General";
        IconData = (StreamGeometry)Application.Current.FindResource("GeneralIcon");
    }
    
    // available theme list
    public List<ThemeVariant> AvailableThemes { get; } = new()
    {
        ThemeVariant.Default,
        ThemeVariant.Light,
        ThemeVariant.Dark
    };
    
    // available language list
    public ObservableCollection<string> Languages { get; } = new()
    {
        "English", "Russian", "Portuguese", "French", "Spanish",
    };
    
    // set accent color
    [RelayCommand]
    private void SetAccent(string hex)
    {
        Application.Current!.Resources["AccentColor"] = new SolidColorBrush(Color.Parse(hex));
    }
    
    // set theme
    public ThemeVariant SelectedTheme
    {
        get => _selectedTheme;
        set
        {
            _selectedTheme = value;
            if (Application.Current is not null)
            {
                Application.Current.RequestedThemeVariant = value;
            }

        }
    }

}