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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Media currentMedia;
        LibraryMember selectedMember;
        public MainWindow()
        {
            InitializeComponent();
            membersGrid.ItemsSource = Library.members;
            libraryItems.ItemsSource = Library.medias;
        }
        private void libraryItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentMedia = ((Media)libraryItems.SelectedItem);
        }

        private void membersGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedMember = ((LibraryMember)membersGrid.SelectedItem);
        }

        public void RefreshDataGrid()
        {
            currentMedia = null;
            selectedMember = null;
            libraryItems.ItemsSource = null;
            libraryItems.ItemsSource = Library.medias;
            membersGrid.ItemsSource = null;
            membersGrid.ItemsSource = Library.members;
        }

        private void lend_Click(object sender, RoutedEventArgs e)
        {
            if (currentMedia == null || selectedMember == null)
            {
                MessageBox.Show("No media or member has been selected!");
                return;
            }
            if (!currentMedia.IsBorrowed)
            {
                currentMedia.Borrower = selectedMember.Name;
                currentMedia.IsBorrowed = true;
                currentMedia.borrowerId = selectedMember.Id;
                selectedMember.borrowHistory.Add(currentMedia);
                selectedMember.currentlyBorrowed.Add(currentMedia);
                currentMedia.NumberOfTimesLent++;
                MessageBox.Show("The media has successfully been lent out to " + currentMedia.Borrower);

                RefreshDataGrid();       
            }
            else
            {
                MessageBox.Show("The Media has already been borrowed by " + currentMedia.Borrower);
            }
        }

        private void return_Click(object sender, RoutedEventArgs e)
        {
            if(currentMedia == null)
            {
                MessageBox.Show("No media has been selected!");
                return;
            }
            if (currentMedia.IsBorrowed)
            {
                MessageBox.Show("The media has been successfully returned by " + currentMedia.Borrower);
                foreach (LibraryMember mem in Library.members)
                {
                    if (currentMedia.borrowerId == mem.Id)
                    {
                        mem.currentlyBorrowed.Remove(currentMedia);
                        break;
                    }
                }
                currentMedia.Borrower = null;
                currentMedia.IsBorrowed = false;
                currentMedia.borrowerId = 0;
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("The Media hasn't been borrowed by anyone!");
            }
        }

        private void modifyMedia_Click(object sender, RoutedEventArgs e)
        {
            if (currentMedia != null)
                this.Content = new ModifyMediaPage(currentMedia, this.Content, this);
            else
                MessageBox.Show("No media has been selected!");
        }

        private void modifyMember_Click(object sender, RoutedEventArgs e)
        {
            if(selectedMember!=null)
                this.Content = new ModifyMemberPage(selectedMember,this.Content, this);
            else
                MessageBox.Show("No member has been selected!");
        }

        private void memberInfo_Click(object sender, RoutedEventArgs e)
        {
            if(selectedMember == null)
            {
                MessageBox.Show("No Member Selected");
                return;
            }
            MessageBox.Show(selectedMember.MemberInfo());
        }

        private void mediaInfo_Click(object sender, RoutedEventArgs e)
        {
            if(currentMedia == null)
            {
                MessageBox.Show("No Media Selected");
                return;
            }
            MessageBox.Show(currentMedia.MediaInfo());
        }
    }
}
