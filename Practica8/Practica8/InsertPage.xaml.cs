using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private async void Insert_Clicked(object sender, EventArgs e)
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
                                                                    await MainPage.Table.InsertAsync(datos);
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
                                                                        await MainPage.Table.InsertAsync(datos);
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
                                                                            await MainPage.Table.InsertAsync(datos);
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
                                                            DisplayAlert("Importante", "El Numero de telefono debe Tener 10 Digitos", "Ok");
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
        }
    }