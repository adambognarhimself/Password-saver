using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using Password_saver.Properties;

namespace Password_saver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        string path;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            if (Settings.Default.Path != string.Empty)
            {
                path = Settings.Default.Path;
                mySaveButton.IsEnabled = true;
            }
            else
            {
                mySaveButton.IsEnabled = false;
            }
        }


        #region text focus
        private void myServiceText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (myServiceText.Text == "Service")
            {
                myServiceText.Text = string.Empty;
            }
            myServiceLabel.Visibility = Visibility.Visible;

        }

        private void myServiceText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (myServiceText.Text == string.Empty)
            {
                myServiceText.Text = "Service";
            }
            myServiceLabel.Visibility = Visibility.Hidden;
        }

        private void myEmailText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (myEmailText.Text == "Email or username")
            {
                myEmailText.Text = string.Empty;
            }
            myEmailLabel.Visibility = Visibility.Visible;
        }

        private void myEmailText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (myEmailText.Text == string.Empty)
            {
                myEmailText.Text = "Email or username";
            }
            myEmailLabel.Visibility = Visibility.Hidden;
        }

        private void myPasswordText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (myPasswordText.Text == "Password")
            {
                myPasswordText.Text = string.Empty;
            }
            myPasswordLabel.Visibility = Visibility.Visible;
        }

        private void myPasswordText_LostFocus(object sender, RoutedEventArgs e)
        {
            if (myPasswordText.Text == string.Empty)
            {
                myPasswordText.Text = "Password";
            }
            myPasswordLabel.Visibility = Visibility.Hidden;
        }
        #endregion

        private void myDierctoryButton_Click(object sender, RoutedEventArgs e)
        {

            
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == true)
            {
                Settings.Default.Path = saveFileDialog.FileName;
                File.WriteAllText(saveFileDialog.FileName, string.Empty);
                Settings.Default.Save();
            }

            if (Settings.Default.Path != string.Empty)
            {
                mySaveButton.IsEnabled = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.Path = string.Empty;
            Settings.Default.Save();

            if (Settings.Default.Path == string.Empty)
            {
                mySaveButton.IsEnabled = false;
            }
        }

        private void mySaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (myEmailText.Text != "Email or username" && myPasswordText.Text != "Password" && myServiceText.Text != "Service")
            {
                File.AppendAllText(path, $"\n------------------\n{myServiceText.Text}\n{myEmailText.Text}\n{myPasswordText.Text}\n------------------\n");
            }

        }
    }
}
