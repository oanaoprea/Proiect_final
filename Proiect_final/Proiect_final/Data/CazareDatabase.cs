using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_final.Models;

namespace Proiect_final.Data
{
    public class CazareDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public CazareDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Cazare>().Wait();
        }
        public Task<List<Cazare>> GetCazareAsync()
        {
            return _database.Table<Cazare>().ToListAsync();
        }
        public Task<Cazare> GetCazareAsync(int id)
        {
            return _database.Table<Cazare>()
            .Where(i => i.ID_cazare == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveCazareAsync(Cazare clist)
        {
            if (clist.ID_cazare != 0)
            {
                return _database.UpdateAsync(clist);
            }
            else
            {
                return _database.InsertAsync(clist);
            }
        }
        public Task<int> DeleteCazareAsync(Cazare clist)
        {
            return _database.DeleteAsync(clist);
        }
    }
}
