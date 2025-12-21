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

namespace lab07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ScaleUp_Click(object sender, RoutedEventArgs e)
        {
            EllipseScale.ScaleX += 0.1;
            EllipseScale.ScaleY += 0.1;

            PolygonScale.ScaleX += 0.1;
            PolygonScale.ScaleY += 0.1;

            PathScale.ScaleX += 0.1;
            PathScale.ScaleY += 0.1;
        }

        private void ScaleDown_Click(object sender, RoutedEventArgs e)
        {
            EllipseScale.ScaleX -= 0.1;
            EllipseScale.ScaleY -= 0.1;

            PolygonScale.ScaleX -= 0.1;
            PolygonScale.ScaleY -= 0.1;

            PathScale.ScaleX -= 0.1;
            PathScale.ScaleY -= 0.1;
        }

    }
}