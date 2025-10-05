using ApplicationLayer;
using System.Windows;

namespace PresentationLayer.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IUserService _userService;

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                if (SetProperty(ref _userName, value))
                {
                    CreateUserCommand.RaiseCanExecuteChanged();
                    GetUserCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public DelegateCommand CreateUserCommand { get; }
        public DelegateCommand GetUserCommand { get; }

        public MainWindowViewModel(IUserService userService)
        {
            _userService = userService;

            CreateUserCommand = new DelegateCommand(OnCreateUser, CanCreateUser);
            GetUserCommand = new DelegateCommand(OnGetUser, CanGetUser);
        }

        private void OnCreateUser()
        {
            _userService.CreateUser(UserName);
            MessageBox.Show("用户创建成功！");
        }

        private bool CanCreateUser()
        {
            if (string.IsNullOrWhiteSpace(UserName))
                return false;
            return true;
        }

        private void OnGetUser()
        {
            var user = _userService.GetUserByName(_userName);
            if (user != null)
                MessageBox.Show($"用户：{user.Name}");
            else
                MessageBox.Show("用户不存在！");
        }

        private bool CanGetUser()
        {
            if (string.IsNullOrWhiteSpace(UserName))
                return false;
            return true;
        }
    }
}
