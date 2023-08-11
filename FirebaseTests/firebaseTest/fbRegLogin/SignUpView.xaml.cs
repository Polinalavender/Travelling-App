using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fbRegLogin;

public partial class SignUpView : ContentPage
{
    public SignUpView(object bindingContext)
    {
        InitializeComponent();
        BindingContext = bindingContext;
    }
}