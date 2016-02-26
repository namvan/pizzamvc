﻿using Pizza.Contracts.Presentation.Security.ServiceContracts;
using Pizza.Contracts.Presentation.Security.ViewModels;

namespace Pizza.Contracts.Presentation.Security
{
    public interface IAuthService
    {
        LoginResult<TUserViewModel> LoginUser<TUserViewModel>(LoginRequest loginRequest) 
            where TUserViewModel : PizzaUserViewModel, new();

        ChangePasswordResult ChangePassword(ChangePasswordRequest changePasswordRequest);
    }
}