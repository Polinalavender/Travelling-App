using System.Windows.Input;
using fbRegLogin.SignUp;
using Firebase.Auth;

namespace fbRegLogin.ViewModels;

public class SignUpFormVM : ViewModelBase
{
    private string _email;

    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            _email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    private string _password;

    public string Password
    {
        get
        {
            return _password;
        }
        set
        {
            _password = value;
            OnPropertyChanged(nameof(Password));
        }
    }

    private string _confirmPassword;

    public string ConfirmPassword
    {
        get
        {
            return _confirmPassword;
        }
        set
        {
            _confirmPassword = value;
            OnPropertyChanged(nameof(ConfirmPassword));
        }
    }
    public ICommand SignUpCommand { get; }

    public SignUpFormVM(FirebaseAuthClient authClient)
    {
        SignUpCommand = new SignUpCommand(this,authClient);
    }
}