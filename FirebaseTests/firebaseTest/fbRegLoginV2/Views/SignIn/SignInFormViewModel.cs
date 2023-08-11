using System.Windows.Input;
using Firebase.Auth;

namespace fbRegLoginV2.Views.SignIn;

public class SignInFormViewModel : ViewModelBase
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

    public ICommand SignInCommand { get; }

    public SignInFormViewModel(FirebaseAuthClient authClient, CurrentUserStore currentUserStore)
    {
        try
        {
            SignInCommand = new SignInCommand(this, authClient, currentUserStore);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
