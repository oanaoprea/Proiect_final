using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Proiect_final.Models;

namespace Proiect_final.Data
{
    public class ContractDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ContractDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contract>().Wait();
        }
        public Task<List<Contract>> GetContractAsync()
        {
            return _database.Table<Contract>().ToListAsync();
        }
        public Task<Contract> GetContractAsync(int id)
        {
            return _database.Table<Contract>()
            .Where(i => i.ID_contract == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveContractAsync(Contract rlist)
        {
            if (rlist.ID_contract != 0)
            {
                return _database.UpdateAsync(rlist);
            }
            else
            {
                return _database.InsertAsync(rlist);
            }
        }
        public Task<int> DeleteContractAsync(Contract rlist)
        {
            return _database.DeleteAsync(rlist);
        }
    }
}
