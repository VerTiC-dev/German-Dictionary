using Avalonia.Controls;

namespace German_Dictionary;

public partial class NotificationWindow : Window
{
    private readonly Window _mainWindow;

    public NotificationWindow(Window mianWindow, string notificationText, int fontSize)
    {
        InitializeComponent();

        _mainWindow = mianWindow;

        this.Message.Text = notificationText;
        this.Message.FontSize = fontSize;
    }

    // Functions that close the notification window and re-enables the main window
    private void ButtonOK_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => this.Close();
    private void Window_Closing(object? sender, Avalonia.Controls.WindowClosingEventArgs e) => _mainWindow.IsEnabled = true;
}