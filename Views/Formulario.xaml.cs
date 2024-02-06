using System;
using Microsoft.Maui.Controls;
using Tarea_1._3.Models;


namespace Tarea_1._3.Views
{
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            // Recuperar los valores del Entry y Picker
            string nombre = NombreEntry.Text;
            string pais = PaisPicker.SelectedItem as string;

            // Validar que se haya ingresado un nombre
            if (string.IsNullOrWhiteSpace(nombre))
            {
                DisplayAlert("Error", "Por favor, ingrese un nombre válido", "OK");
                return;
            }

            // Validar que se haya seleccionado un país
            if (string.IsNullOrWhiteSpace(pais))
            {
                DisplayAlert("Error", "Por favor, seleccione un país válido", "OK");
                return;
            }

            try
            {
                // Crear una nueva instancia del modelo DateBase con los valores
                var nuevoAutor = new DateBase
                {
                    Nombre = nombre,
                    Pais = pais
                };

                // Mostrar un mensaje de éxito
                DisplayAlert("Éxito", "La información se ha guardado correctamente", "OK");

                await Navigation.PushAsync(new Lista_Autores());

            }
            catch (Exception ex)
            {
                // Manejar errores en la operación de guardado
                DisplayAlert("Error", $"Ocurrió un error: {ex.Message}", "OK");
            }
        }
        async void VerListado(System.Object sender, System.EventArgs e)
        {
            // Navegar a la página de listado
            await Navigation.PushAsync(new Lista_Autores());
        }
    }
}
