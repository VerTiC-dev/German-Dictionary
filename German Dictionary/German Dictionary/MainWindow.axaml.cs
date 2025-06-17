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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Border_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e) => this.BeginMoveDrag(e);
    }
}