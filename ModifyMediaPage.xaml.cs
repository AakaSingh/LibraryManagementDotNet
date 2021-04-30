using System;
using System.Collections.Generic;
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

namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for ModifyMediaPage.xaml
    /// </summary>
    public partial class ModifyMediaPage : Page
    {
        Media media;
        Object previousContent;
        MainWindow context;
        public ModifyMediaPage(Media _media, Object content, MainWindow _context)
        {
            InitializeComponent();
            media = _media;
            previousContent = content;
            context = _context;
            firstName.Text = media.Name;
            type.Text = media.MediaType;

        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            media.Name = firstName.Text;
            media.MediaType = type.Text;
            context.RefreshDataGrid();
            Application.Current.MainWindow.Content = previousContent;
        }
    }
}
