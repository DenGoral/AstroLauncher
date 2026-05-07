using System.Collections.ObjectModel;
using AstroLauncher.ViewModels.SettingsPageViewModels;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels;

public partial class SettingsViewModel : ObservableObject
{
    [ObservableProperty]
    private string _pageTitle = "Settings";

    // RAM values
    [ObservableProperty]
    private double _maxRamValue = 16384;
    
    [ObservableProperty]
    private ViewModelBase? _selectedCategory;

    public ObservableCollection<ViewModelBase> Categories { get; } = new()
    {
        new GeneralViewModel(),
        new LauncherViewModel(),
    };

    public SettingsViewModel()
    {
        SelectedCategory = new GeneralViewModel();
    }

    [RelayCommand]
    private void NavigateToGeneral()
    {
        SelectedCategory =  new GeneralViewModel();
    }

    [RelayCommand]
    private void NavigateToLauncher()
    {
        SelectedCategory = new LauncherViewModel();
    }
}