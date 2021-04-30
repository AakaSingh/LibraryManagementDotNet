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
    /// Interaction logic for ModifyMemberPage.xaml
    /// </summary>
    public partial class ModifyMemberPage : Page
    {
        LibraryMember member;
        Object previousContent;
        MainWindow context;
        public ModifyMemberPage(LibraryMember _member, Object content, MainWindow _context)
        {
            InitializeComponent();
            member = _member;
            previousContent = content;
            context = _context;
            firstName.Text = member.Name;
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            member.Name = firstName.Text;
            context.RefreshDataGrid();
            Application.Current.MainWindow.Content = previousContent;
        }
    }
}
