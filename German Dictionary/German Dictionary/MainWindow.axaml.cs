using Avalonia.Controls;
using Avalonia.Threading;
using System.Threading.Tasks;

namespace German_Dictionary
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ButtonAdd.IsEnabled = false; // Disable the Add button initially
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

        /// <summary>
        /// Function to determine button enable state based on the input fields.
        /// </summary>
        /// <returns></returns>
        private bool IsButtonAddEnabled()
        {
            // Check if all required fields are filled
            return !string.IsNullOrEmpty(Translation.Text) &&
                   !string.IsNullOrEmpty(Singular.Text) &&
                   !string.IsNullOrEmpty(Plural.Text) &&
                   !string.IsNullOrEmpty(Article.Text) && Article.Text.Length == 3; // Assuming Article should be exactly 3 characters long
        }

        // Functions to handle text changes in the input fields
        private void TranslationTextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e) => ButtonAdd.IsEnabled = IsButtonAddEnabled();
        private void SingularTextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e) => ButtonAdd.IsEnabled = IsButtonAddEnabled();
        private void PluralTextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e) => ButtonAdd.IsEnabled = IsButtonAddEnabled();
        private void ArticleTextBox_TextChanged(object? sender, Avalonia.Controls.TextChangedEventArgs e) => ButtonAdd.IsEnabled = IsButtonAddEnabled();
    }
}