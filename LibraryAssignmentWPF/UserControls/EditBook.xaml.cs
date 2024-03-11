using System.Windows;
using System.Windows.Controls;
using BookJurnalLibrary;
namespace LibraryAssignmentWPF.UserControls
{
    public partial class EditBook : UserControl
    {
        public static string Isbn { get; set; }
        public EditBook()
        {
            InitializeComponent();
            btnEnter.ButtonContent = Resex.btnEnter;
            btnreturn.ButtonContent = Resex.btnReturn;
            
            btnEnter.ButtonClickEvent += btnInput_Click;
            btnreturn.ButtonClickEvent += btnInput_Click;           
        }
       
        private void btnInput_Click(object sender, RoutedEventArgs e)
        {            
            if (sender == btnEnter) // enter isbn to edit
            {                
                try
                {                   
                    DataBase.IsIsbnValid(isbnBox.txtInput.Text); 
                    Isbn = isbnBox.txtInput.Text;
                    ProceedToNextMenu();
                }
                catch (IllegalIsbnException ex)
                {
                    DataBase.LogException(ex);
                    MessageBox.Show(ex.Message, "ERORR", MessageBoxButton.OK, MessageBoxImage.Error);
                    isbnBox.txtInput.Focus();
                }              
            }
            else //return
            {
                ReturnToManagerMenu();
            }
        }

        private void ReturnToManagerMenu()
        {
            Window mainWindow = Window.GetWindow(this);
            Grid editBookGrid = (Grid)mainWindow.FindName("editBookGrid");           
            editBookGrid.Visibility = Visibility.Collapsed;

            Grid managerGrid = (Grid)mainWindow.FindName("managerGrid");
            managerGrid.Visibility = Visibility.Visible;

            isbnBox.txtInput.Text = string.Empty;
        }

        private void ProceedToNextMenu()
        {
            Window mainWindow = Window.GetWindow(this);
            Grid editBookGrid = (Grid)mainWindow.FindName("editBookGrid");
            editBookGrid.Visibility = Visibility.Collapsed;

            Grid editBookGrid2 = (Grid)mainWindow.FindName("editBookGrid2");
            editBookGrid2.Visibility = Visibility.Visible;
           
            EditBook2 editBookGrid2Control = (EditBook2)editBookGrid2.Children[0];
            editBookGrid2Control.ClearComboBox();
            editBookGrid2Control.FindBook();
            editBookGrid2Control.PopulateComboBox();
        }
    }
}