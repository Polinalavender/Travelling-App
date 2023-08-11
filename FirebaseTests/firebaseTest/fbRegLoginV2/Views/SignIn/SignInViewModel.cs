namespace fbRegLoginV2.Views.SignIn;

public class SignInViewModel : ViewModelBase
{
    public SignInFormViewModel SignInFormViewModel { get; }

    public SignInViewModel(SignInFormViewModel signInFormViewModel)
    {
        SignInFormViewModel = signInFormViewModel;
    }
}