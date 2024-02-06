// ListaAutoresViewModel.cs

using System.Collections.ObjectModel;
using Tarea_1._3.Controllers;
using Tarea_1._3.Models;

namespace Tarea_1._3.ViewModels
{
    public class ListaAutoresViewModel
    {
        public ObservableCollection<DateBase> Autores { get; set; }

        public ListaAutoresViewModel()
        {
        }

    }
}
