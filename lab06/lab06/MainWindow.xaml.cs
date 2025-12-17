using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace lab06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbNoun.Items.Add("река");
            cbNoun.Items.Add("гора");
            cbNoun.Items.Add("пустыня");
            cbNoun.Items.Add("страна");

            cbNoun.SelectedIndex = 0;
            lbVerb.SelectedIndex = 0;
        }

        private void BtnBuild_Click(object sender, RoutedEventArgs e)
        {
            string adjective = "";

            foreach (var item in ((StackPanel)((GroupBox)((DockPanel)Content).Children[1]).Content).Children)
            {
                if (item is RadioButton rb && rb.IsChecked == true)
                {
                    adjective = rb.Content.ToString();
                    break;
                }
            }

            string noun = cbNoun.SelectedItem.ToString();
            string verb = ((ListBoxItem)lbVerb.SelectedItem).Content.ToString();

            lblResult.Content = $"{adjective} {noun} {verb}";
        }
    }
}