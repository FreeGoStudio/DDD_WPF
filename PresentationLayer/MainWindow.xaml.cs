
using ApplicationLayer;
using InfrastructureLayer;
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
using System.Xml.Linq;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IUserService _userService;
        public MainWindow(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void Button_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            _userService.CreateUser(txtName.Text);
            MessageBox.Show("用户创建成功！");
        }

        private void Button_GetUser_Click(object sender, RoutedEventArgs e)
        {
            var user = _userService.GetUserByName(txtName.Text);
            if (user != null)
                MessageBox.Show($"用户：{user.Name}");
            else
                MessageBox.Show("用户不存在！");
        }
    }
}