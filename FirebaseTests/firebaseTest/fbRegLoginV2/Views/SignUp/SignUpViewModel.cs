namespace fbRegLoginV2.Views;

public class SignUpViewModel:ViewModelBase
{
    public SignUpFormViewModel SignUpFormViewModel { get; }

    public SignUpViewModel(SignUpFormViewModel signUpFormViewModel)
    {
        SignUpFormViewModel = signUpFormViewModel;
    }
}