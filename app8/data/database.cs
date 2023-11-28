using app8.mode;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace app8.data
{
    public class database
    {
        private readonly SQLiteAsyncConnection Conexion;
        public database(string dbpath)
        {
            Conexion = new SQLiteAsyncConnection(dbpath);
            Conexion.CreateTableAsync<tocv>().Wait();

        }
        public async Task<int> InsertItemAsyn(tocv item)
        {
            return await Conexion.InsertAsync(item);
        }
        //metodo para obtener los items (retorna la lista)
        public async Task<List<tocv>> GetItemsAsync()
        {
            return await Conexion.Table<tocv>().ToListAsync();
        }


    }
}
