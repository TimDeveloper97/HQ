using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template__.Services
{
    public class DataStore<T> : IDataStore<T>
    {
        public async Task<bool> AddItemAsync(T item, string pFile)
        {
            try
            {
                string jsonIn = File.ReadAllText(pFile);
                var list = JsonConvert.DeserializeObject<List<T>>(jsonIn);

                list.Add(item);

                var jsonOut = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(pFile, jsonOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
        public async Task<bool> CreateItemAsync(string pFile)
        {
            try
            {
                List<T> list = new List<T>();

                var jsonOut = JsonConvert.SerializeObject(list, Formatting.Indented);
                File.WriteAllText(pFile, jsonOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(string id, string pFile)
        {
            try
            {
                //string jsonIn = File.ReadAllText(pFile);
                //var list = JsonConvert.DeserializeObject<List<T>>(jsonIn);

                //var item = list.FirstOrDefault(x => x.Id == id);
                //list.Remove(item);

                //var jsonOut = JsonConvert.SerializeObject(list, Formatting.Indented);
                //File.WriteAllText(pFile, jsonOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
        public async Task<T> GetItemAsync(string id, string pFile)
        {
            //try
            //{
            //    string jsonIn = File.ReadAllText(pFile);
            //    var list = JsonConvert.DeserializeObject<List<T>>(jsonIn);

            //    var item = list.FirstOrDefault(x => x.Id == id);
            //    return await Task.FromResult(item);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return await Task.FromResult(new T());
            //}
            throw new Exception();
        }
        public async Task<T> GetObjectAsync(string pFile)
        {
            //try
            //{
            //    string jsonIn = File.ReadAllText(pFile);
            //    var obj = JsonConvert.DeserializeObject<T>(jsonIn);

            //    return await Task.FromResult(obj);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return await Task.FromResult(new T());
            //}
            throw new Exception();
        }
        public async Task<IEnumerable<T>> GetItemsAsync(string pFile, bool forceRefresh = false)
        {
            try
            {
                string jsonIn = File.ReadAllText(pFile);
                var list = JsonConvert.DeserializeObject<List<T>>(jsonIn);

                return await Task.FromResult(list);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(new List<T>());
            }
        }
        public async Task<bool> UpdateItemAsync(T item, string pFile)
        {
            try
            {
                //string jsonIn = File.ReadAllText(pFile);
                //var list = JsonConvert.DeserializeObject<List<T>>(jsonIn);

                //var oldItem = list.FirstOrDefault(x => x.Id == item.Id);
                //list.Remove(oldItem);
                //list.Add(item);

                //var jsonOut = JsonConvert.SerializeObject(list, Formatting.Indented);
                //File.WriteAllText(pFile, jsonOut);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return await Task.FromResult(false);
            }

            return await Task.FromResult(true);
        }
    }
}
