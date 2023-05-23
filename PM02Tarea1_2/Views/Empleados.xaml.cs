using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM02Tarea1_2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Empleados : ContentPage
    {
        public Empleados()
        {
            InitializeComponent();
        }
        public Empleados(String pmessage)
        {
            InitializeComponent();

            lbnombres.Text = pmessage;
            lbapellidos.Text = pmessage;
            lbedad.Text = pmessage;
            lbcorreo.Text = pmessage;


        }
    }
}