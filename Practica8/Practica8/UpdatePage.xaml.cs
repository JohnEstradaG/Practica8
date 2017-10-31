using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace Practica8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdatePage : ContentPage
    {
        public UpdatePage(object SelectedItem)
        {
            var dato = SelectedItem as _13090353;
            BindingContext = dato;
            InitializeComponent();
        }

        private async void Update_Clicked(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(Nombre.Text))
                {
                    DisplayAlert("Importante", "Ingresa Tu Nombre", "Ok");
                }
                else
                {
                    if (string.IsNullOrEmpty(Ape_pat.Text))
                    {
                        DisplayAlert("Importante", "Ingresa Tu Apellido Paterno", "Ok");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Ape_mat.Text))
                        {
                            DisplayAlert("Importante", "Ingresa Tu Apellido Materno", "Ok");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Direccion.Text))
                            {
                                DisplayAlert("Importante", "Ingresa Tu Direccion", "Ok");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(Telefono.Text))
                                {
                                    DisplayAlert("Importante", "Ingresa Tu Numero de Telefono", "Ok");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(Carrera.Text))
                                    {
                                        DisplayAlert("Importante", "Ingresa Tu Carrera", "Ok");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(Semestre.Text))
                                        {
                                            DisplayAlert("Importante", "Ingresa Tu Semestre", "Ok");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(Correo.Text))
                                            {
                                                DisplayAlert("Importante", "Ingresa Tu Correo", "Ok");
                                            }
                                            else
                                            {
                                                if (string.IsNullOrEmpty(Github.Text))
                                                {
                                                    DisplayAlert("Importante", "Ingresa Tu Github", "Ok");
                                                }
                                                else
                                                {
                                                        if (Telefono.Text.Length == 10)
                                                        {

                                                            if (Correo.Text.Contains("@hotmail.com"))
                                                            {
                                                                try
                                                                {
                                                                    var datos = new _13090353
                                                                    {
                                                                        Matricula = Matricula.Text,
                                                                        Nombre = Nombre.Text,
                                                                        ApellidoPaterno = Ape_pat.Text,
                                                                        ApellidoMaterno = Ape_mat.Text,
                                                                        Direccion = Direccion.Text,
                                                                        Telefono = Telefono.Text,
                                                                        Carrera = Carrera.Text,
                                                                        Semestre = Semestre.Text,
                                                                        Correo = Correo.Text,
                                                                        Github = Github.Text
                                                                    };
                                                                    await MainPage.Table.UpdateAsync(datos);
                                                                    await Navigation.PushAsync(new MainPage());
                                                                }
                                                                catch (Exception ex)
                                                                {

                                                                    DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                }
                                                            }
                                                            else
                                                            {

                                                                if (Correo.Text.Contains("@gmail.com"))
                                                                {
                                                                    try
                                                                    {
                                                                        var datos = new _13090353
                                                                        {
                                                                            Matricula = Matricula.Text,
                                                                            Nombre = Nombre.Text,
                                                                            ApellidoPaterno = Ape_pat.Text,
                                                                            ApellidoMaterno = Ape_mat.Text,
                                                                            Direccion = Direccion.Text,
                                                                            Telefono = Telefono.Text,
                                                                            Carrera = Carrera.Text,
                                                                            Semestre = Semestre.Text,
                                                                            Correo = Correo.Text,
                                                                            Github = Github.Text
                                                                        };
                                                                        await MainPage.Table.UpdateAsync(datos);
                                                                        await Navigation.PushAsync(new MainPage());
                                                                    }
                                                                    catch (Exception ex)
                                                                    {

                                                                        DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    if (Correo.Text.Contains("@outlook.com"))
                                                                    {
                                                                        try
                                                                        {
                                                                            var datos = new _13090353
                                                                            {
                                                                                Matricula = Matricula.Text,
                                                                                Nombre = Nombre.Text,
                                                                                ApellidoPaterno = Ape_pat.Text,
                                                                                ApellidoMaterno = Ape_mat.Text,
                                                                                Direccion = Direccion.Text,
                                                                                Telefono = Telefono.Text,
                                                                                Carrera = Carrera.Text,
                                                                                Semestre = Semestre.Text,
                                                                                Correo = Correo.Text,
                                                                                Github = Github.Text
                                                                            };
                                                                            await MainPage.Table.UpdateAsync(datos);
                                                                            await Navigation.PushAsync(new MainPage());
                                                                        }
                                                                        catch (Exception ex)
                                                                        {

                                                                            DisplayAlert("Importante", "Ya Existe La matricula", "Ok");

                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        DisplayAlert("Importante", "Su Correo debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");
                                                                    }
                                                                }
                                                            }

                                                        }
                                                        else
                                                        {
                                                            DisplayAlert("Importante", "El numero telefonico debe tener 10 Digitos", "Ok");
                                                        }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                    }
                }
            }
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datos = new _13090353
                {
                    Matricula = Matricula.Text,
                };
                await MainPage.Table.DeleteAsync(datos);
                await Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {

                DisplayAlert("Importante", "No se encontro el usuario ", "Ok");

            }
        }

        private async void Recupera_Clicked(object sender, EventArgs e)
        {
            try
            {
                var datos = new _13090353
                {
                    Matricula = Matricula.Text,
                };
                await MainPage.Table.UndeleteAsync(datos);
                await Navigation.PushAsync(new MainPage());
            }
            catch (Exception ex)
            {

                DisplayAlert("Importante", "Este Usuario no esta eliminado ", "Ok");

            }
        }
    }
}