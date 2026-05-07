using Avalonia.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AstroLauncher.ViewModels;

public class ViewModelBase : ObservableObject
{
    public string? DisplayName { get; init; }
    public StreamGeometry? IconData { get; init; }
}