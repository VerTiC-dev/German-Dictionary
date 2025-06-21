using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace German_Dictionary;

public partial class NotificationWindow : Window
{
    public NotificationWindow() // here must be a parameter that determine the text of notification
    {
        InitializeComponent();
    }

    private void ButtonOK_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => this.Close();
}