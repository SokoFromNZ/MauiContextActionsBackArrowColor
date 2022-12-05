using System.Collections.ObjectModel;

namespace MauiContextActionsBackArrowColor;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public ObservableCollection<string> Items { get; } = new() { "first", "second" };
}

