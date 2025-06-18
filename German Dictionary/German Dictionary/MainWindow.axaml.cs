using Avalonia.Controls;

namespace German_Dictionary
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Function to handle the border pointer pressed event to allow dragging the window.
        /// </summary>
        private void Border_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e) => this.BeginMoveDrag(e);

        /// <summary>
        /// Function to handle the exit button click event to close the application.
        /// </summary>
        private void ButtonExit_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => System.Diagnostics.Process.GetCurrentProcess().Kill();

        /// <summary>
        /// Function to handle the minimize button click event to change the window state to minimized.
        /// </summary>
        private void ButtonMinimize_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e) => this.WindowState = WindowState.Minimized;
    }
}