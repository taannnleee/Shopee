using Shopee.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Shopee.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string username="letan";
        private string password="123123";

        public ICommand LoginCommand { get; set; }
        public ICommand ExitCommand { get; private set; }

        public string Username { get => username; set { username = value; OnPropertyChanged(); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(); } }

        public LoginViewModel() 
        {
            SetCommands();
        }

        private void SetCommands()
        {
            LoginCommand = new RelayCommand<Window>(ExecuteLoginCommand);
            ExitCommand = new RelayCommand<Window>(ExecuteExitCommand);
        }

        private void ExecuteLoginCommand(Window window)
        {
            if(username!=null && password !=null)
            {
                var mainWin = new MainWindow();
                mainWin.ShowDialog();
            }
        }

        private void ExecuteExitCommand(Window window)
        {
            try
            {
                MessageBox.Show("tan");
                window.Close();
            }
            catch { }
        }
    }
}
