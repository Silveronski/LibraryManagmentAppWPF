using System.Windows;
using System.Windows.Controls;
namespace LibraryAssignmentWPF.UserControls
{
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {           
            InitializeComponent();
        }

        public static readonly DependencyProperty ButtonContentProperty =
            DependencyProperty.Register("ButtonContent", typeof(string), typeof(MenuButton), new PropertyMetadata("Button"));    
        public string ButtonContent
        {
            get { return (string)GetValue(ButtonContentProperty); }
            set { SetValue(ButtonContentProperty, value); }
        }
        // in order to be able to change the content of the buttons (because they are set from MenuButton UserControl).


        public event RoutedEventHandler ButtonClickEvent;
        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            ButtonClickEvent?.Invoke(this, e);
        }
        // a main button click event for the buttons.
    }
}