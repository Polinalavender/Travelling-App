using fbRegLogin.ViewModels;

namespace fbRegLogin.SignUp;

public class SignUpVM:ViewModelBase
{
    public SignUpFormVM SignUpFormVm { get; }
    
    public SignUpVM(SignUpFormVM signUpFormVm)
    {
        SignUpFormVm = signUpFormVm;
    }
}