using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Media;

namespace AstroLauncher.Controls;

public class SettingItem : TemplatedControl
{
    // header property
    public static readonly StyledProperty<string> HeaderProperty = 
        AvaloniaProperty.Register<SettingItem, string>(nameof(Header));

    public string Header
    {
        get => GetValue(HeaderProperty);
        set => SetValue(HeaderProperty, value);
    }
    
    // desc property
    public static readonly StyledProperty<string> DescriptionProperty =
        AvaloniaProperty.Register<SettingItem, string>(nameof(Description));

    public string Description
    {
        get => GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }
}