using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels.SettingsPageViewModels;

public class PrivacyAndSecurityViewModel : ViewModelBase
{
        public PrivacyAndSecurityViewModel()
        {
            DisplayName = "Privacy & Security";
            IconData = (StreamGeometry)Application.Current.FindResource("SecurityIcon");
        }

}