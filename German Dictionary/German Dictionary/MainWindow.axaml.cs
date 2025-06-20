using Avalonia.Controls;

namespace German_Dictionary
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // WKTButton.IsEnabled = (func to check if WKT is available) and change the buttons text accordingly
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

        /// <summary>
        /// Function to handle the Add button click event to add a new word to the dictionary.
        /// </summary>
        private void ButtonAdd_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // func logic to add the word to the dictionary

            // this button shuold have a func that will change WKTButton text accordingly to a count of words in the dictionary
        }

        /// <summary>
        /// Function to handle the WKT button click event to open a new window for WKT (Word knowledge test).
        /// </summary>
        private void WKTButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            // func logic to open a new window for WKT
        }
    }
}