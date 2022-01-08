using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_final.Models;

namespace Proiect_final.Data
{
    public class DestinatiiDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public DestinatiiDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Destinatii>().Wait();
        }

        public Task<List<Destinatii>> GetDestinatiiAsync()
        {
            return _database.Table<Destinatii>().ToListAsync();
        }
        public Task<Destinatii> GetDestinatiiAsync(int id)
        {
            return _database.Table<Destinatii>()
            .Where(i => i.ID_destinatie == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveDestinatiiAsync(Destinatii dlist)
        {
            if (dlist.ID_destinatie != 0)
            {
                return _database.UpdateAsync(dlist);
            }
            else
            {
                return _database.InsertAsync(dlist);
            }
        }
        public Task<int> DeleteDestinatiiAsync(Destinatii dlist)
        {
            return _database.DeleteAsync(dlist);
        }
    }
}

