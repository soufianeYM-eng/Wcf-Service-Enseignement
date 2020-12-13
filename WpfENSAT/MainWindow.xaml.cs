using System.Linq;
using System.Windows;

namespace WpfENSAT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ServiceReference1.ServiceEnseignementClient d = new ServiceReference1.ServiceEnseignementClient();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btChercher_Click(object sender, RoutedEventArgs e)
        {
            if (d.getByCNE(txtCNE.Text).Count() == 0)
            {
                dataGridENSAT.ItemsSource = d.getByCNE(txtCNE.Text);
                lbMessage.Content = "No body";
            }
            else
            {
                dataGridENSAT.ItemsSource = d.getByCNE(txtCNE.Text);
                lbMessage.Content = "You are lucky ";
            }
        }
    }
}
