using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_final.Models;

namespace Proiect_final.Data
{
    public class TransportDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public TransportDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Transport>().Wait();
        }


        public Task<List<Transport>> GetTransportAsync()
        {
            return _database.Table<Transport>().ToListAsync();
        }


        public Task<Transport> GetTransportAsync(int id)
        {
            return _database.Table<Transport>()
            .Where(i => i.ID_transport == id)
            .FirstOrDefaultAsync();
        }

        public Task<int> SaveTransportAsync(Transport tlist)
        {
            if (tlist.ID_transport != 0)
            {
                return _database.UpdateAsync(tlist);
            }
            else
            {
                return _database.InsertAsync(tlist);
            }
        }

        public Task<int> DeleteTransportAsync(Transport tlist)
        {
            return _database.DeleteAsync(tlist);
        }
    }
}

