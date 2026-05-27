using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels.SettingsPageViewModels;

public partial class AboutViewModel : ViewModelBase
{
    public AboutViewModel()
    {
        DisplayName = "About";
        IconData = (StreamGeometry)Application.Current.FindResource("AboutIcon");
    }
}