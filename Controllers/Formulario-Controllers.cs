using System;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Tarea_1._3.Models;

namespace Tarea_1._3.Controllers
{
    internal class FormularioController
    {
        readonly SQLiteAsyncConnection _connection;

        // Constructor Vacío
        public FormularioController()
        {
            SQLite.SQLiteOpenFlags extensiones = SQLite.SQLiteOpenFlags.ReadWrite |
                                                SQLite.SQLiteOpenFlags.Create |
                                                SQLite.SQLiteOpenFlags.SharedCache;

            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, "DBFormulario.db3"), extensiones);

            _connection.CreateTableAsync<DateBase>();
        }

        // Método para guardar un nuevo autor
        public async Task<int> StoreAutor(DateBase autor)
        {
            try
            {
                return await _connection.InsertAsync(autor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el autor: {ex.Message}");
                throw;
            }
        }
    }
}
