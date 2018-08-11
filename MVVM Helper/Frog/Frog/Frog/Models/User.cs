using System;
using System.Collections.Generic;
using System.Text;
using Frog.Models.Base;

namespace Frog.Models
{
    public class User :BaseModel
    {
        private int _userId = 0;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }
        string  _userName=String.Empty;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private string _password = string.Empty;
        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _image = string.Empty;
        public string Image
        {
            get => _image;
            set => SetProperty(ref _image, value);
        }
    }
}
