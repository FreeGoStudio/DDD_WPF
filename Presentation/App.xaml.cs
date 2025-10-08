using Application;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Presentation.WPF.Views;
using System.IO;
using System.Windows;

namespace Presentation.WPF
{
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<AppDbContext>();
            containerRegistry.Register<IUserRepository, UserRepository>();
            containerRegistry.Register<IUserService, UserService>();
        }

        protected override void OnInitialized()
        {
            var db = Container.Resolve<AppDbContext>();
            var dbPath = "app.db"; // 与你的连接字符串保持一致

            if (!File.Exists(dbPath))
            {
                db.Database.EnsureCreated(); // 数据库文件不存在，直接创建
            }
            else
            {
                db.Database.Migrate(); // 数据库已存在，自动迁移结构
            }

            base.OnInitialized();
        }
    }
}