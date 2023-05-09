namespace LabCaseus.Analise.Api.Models
{
    public class CreateUserModel
    {
        private string _username;
        public string Username
        { 
            get { return _username?.ToLower().Trim(); }
            set { _username = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email?.ToLower().Trim(); }
            set { _email = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password?.Trim(); }
            set { _password = value; }
        }

        private string _rePassword;
        public string RePassword
        {
            get { return _rePassword?.Trim(); }
            set { _rePassword = value; }
        }
    }
}