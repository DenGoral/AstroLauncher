using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels.SettingsPageViewModels;

public partial class LauncherViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _settingsPageTitle = "Launcher";
}