using fbRegLogin.ViewModels;
using Firebase.Auth;

namespace fbRegLogin.SignUp;

public class SignUpCommand  : AsyncCommandBase
{
    private readonly SignUpFormVM _signUpFormVm;
    private readonly FirebaseAuthClient _authClient;

    public SignUpCommand(SignUpFormVM signUpFormVm, FirebaseAuthClient authClient)
    {
        _signUpFormVm = signUpFormVm;
        _authClient = authClient;
    }
    protected override async Task ExecuteAsync(object parameter)
    {
        //check if password does not equal to the confirm password
        if (_signUpFormVm.Password != _signUpFormVm.ConfirmPassword)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Password and confirm password do not match !", "Ok");
            return;
        }
        
        try
        {
            await _authClient.CreateUserWithEmailAndPasswordAsync(_signUpFormVm.Email, _signUpFormVm.Password);
            await Application.Current.MainPage.DisplayAlert("Success", "Successfully signed up !", "Ok");
        }
        catch (Exception)
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Failed to sign up !", "Ok"); //alert if registration fails 
        }
    }
}