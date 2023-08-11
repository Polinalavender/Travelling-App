using fbRegLogin.SignUp;
using fbRegLogin.ViewModels;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;

namespace fbRegLogin;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddTransient<SignUpFormVM>();
        builder.Services.AddTransient<SignUpVM>();
        builder.Services.AddTransient<SignUpView>(
            s => new SignUpView(s.GetRequiredService<SignUpVM>()));
        builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
        {
            //different ways to login into the app (google auth and others are a bit harder to setup)
            ApiKey = "AIzaSyAg6seTP6EjA1MGEhYX7cw9OAoK4lqsGug", //api key from settings in firebase
            AuthDomain = "mauitest-694e1.firebaseapp.com", //In Firebase --> Authentication tab --> Settings tab --> Authorized domains --> copy the link with .firebaseapp.com in it
            Providers = new FirebaseAuthProvider[]
            {
                new EmailProvider()
            }
        }));

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}