using System;
using TravellingApp.Model;
using System.Security.Cryptography;
using TravellingApp.Services;
using Microsoft.AspNetCore.Identity;

namespace TravellingApp
{
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;
            string confirmPassword = passwordConfirmEntry.Text;

            // Perform validation checks here (e.g., password matching, required fields)

            if (!string.IsNullOrWhiteSpace(email) &&
                !string.IsNullOrWhiteSpace(username) &&
                !string.IsNullOrWhiteSpace(password) &&
                !string.IsNullOrWhiteSpace(confirmPassword))
            {
                if (password == confirmPassword)
                {
                    if(true)
                    {
                        // User registration successful
                        MainPage mainPage = new MainPage();
                        Navigation.PushAsync(mainPage);
                    }
                    else
                    {
                        // User registration failed (username already taken)
                        DisplayAlert("Registration Failed", "Username already exists. Please choose a different username.", "OK");
                    }
                }
                else
                {
                    // Passwords do not match
                    DisplayAlert("Registration Failed", "Passwords do not match. Please re-enter your password.", "OK");
                }
            }
            else
            {
                // Required fields are missing
                DisplayAlert("Registration Failed", "Please fill in all the required fields.", "OK");
            }
        }

    }
}
