using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Motel.Application;
using Motel.Application.Authenticate;
using Motel.Common;
using System;
using System.Threading;

namespace Motel.App.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthenticateService _service;
        private readonly IStorageProvider _storage;
        [ObservableProperty]
        string _userName;

        [ObservableProperty]
        string _password;
        public LoginViewModel(IAuthenticateService service,
            IStorageProvider storage)
        {
            _service = service;
            _storage = storage;
        }

        private LoginModel ToLoginModel() => new LoginModel(UserName, Password);

        [RelayCommand]
        async Task Login()
        {
            var res = await _service.Login(ToLoginModel());
            if (res != null)
            {
                await _storage.SetAsync(Constants.Authorization, res.Token);
            }
            await Common.Messages.ShowMessage(Common.Messages.LoginSuccess);
        }
    }
}
