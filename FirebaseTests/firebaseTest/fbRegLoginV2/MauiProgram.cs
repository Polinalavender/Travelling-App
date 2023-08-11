using fbRegLoginV2.Views;
using fbRegLoginV2.Views.SignIn;
using fbRegLoginV2.Views.SignUp;
using Firebase.Auth;
using Firebase.Auth.Providers;
using Microsoft.Extensions.Logging;

namespace fbRegLoginV2;

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

        builder.Services.AddTransient<CurrentUserStore>();
        builder.Services.AddTransient<SignInFormViewModel>();
        builder.Services.AddTransient<SignInViewModel>();
        builder.Services.AddTransient<SignInView>(
            s => new SignInView(s.GetRequiredService<SignInViewModel>()));
        
        builder.Services.AddTransient<SignUpFormViewModel>();
        builder.Services.AddTransient<SignUpViewModel>();
        builder.Services.AddTransient<SignUpView>(
            s => new SignUpView(s.GetRequiredService<SignUpViewModel>()));

        builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig()
        {
            ApiKey = "AIzaSyAg6seTP6EjA1MGEhYX7cw9OAoK4lqsGug",
            AuthDomain = "mauitest-694e1.firebaseapp.com",
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