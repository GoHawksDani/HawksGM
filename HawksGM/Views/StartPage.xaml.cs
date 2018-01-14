using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HawksGM.Views
{
    /// <summary>
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private Brush initialButtonTextColor;

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                this.initialButtonTextColor = button.Foreground;
                button.Foreground = Brushes.Black;
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                button.Foreground = this.initialButtonTextColor;  
            }
        }
    }
}
