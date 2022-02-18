using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template__.Services
{
    interface IDataStore<T>
    {
        Task<bool> CreateItemAsync(string pFile);
        Task<bool> AddItemAsync(T item, string pFile);
        Task<bool> UpdateItemAsync(T item, string pFile);
        Task<bool> DeleteItemAsync(string id, string pFile);
        Task<T> GetItemAsync(string id, string pFile);
        Task<T> GetObjectAsync(string pFile);
        Task<IEnumerable<T>> GetItemsAsync(string pFile, bool forceRefresh = false);
    }
}
