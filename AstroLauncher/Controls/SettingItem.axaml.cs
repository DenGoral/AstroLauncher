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
    
    // icon property
    public static readonly StyledProperty<Geometry> IconDataProperty =
        AvaloniaProperty.Register<SettingItem, Geometry>(nameof(IconData));

    public Geometry IconData
    {
        get => GetValue(IconDataProperty);
        set => SetValue(IconDataProperty, value);
    }
    
    // action content property
    public static readonly StyledProperty<object> ActionContentProperty =
        AvaloniaProperty.Register<SettingItem, object>(nameof(ActionContent));

    public object ActionContent
    {
        get => GetValue(ActionContentProperty);
        set => SetValue(ActionContentProperty, value);
    }

    // lower content property
    public static readonly StyledProperty<object> LowerContentProperty =
        AvaloniaProperty.Register<SettingItem, object>(nameof(LowerContent));

    public object LowerContent
    {
        get => GetValue(LowerContentProperty);
        set => SetValue(LowerContentProperty, value);
    }
}