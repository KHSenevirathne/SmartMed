using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace SmartMed.Data
{
    public abstract class JsonRepository<T> : IRepository<T> where T : class
    {
        private readonly string _filePath;

        protected List<T> Items;

        protected JsonRepository(string fileName)
        {
            _filePath = Path.Combine(SeedData.DataFolder, fileName);
            Load();
        }

        protected abstract int GetId(T item);

        protected abstract void SetId(T item, int id);

        private void Load()
        {
            try
            {
                if (File.Exists(_filePath))
                {
                    string json = File.ReadAllText(_filePath);
                    Items = JsonConvert.DeserializeObject<List<T>>(json) ?? new List<T>();
                }
                else
                {
                    Items = new List<T>();
                }
            }
            catch (Exception)
            {
                // A missing or unreadable data file means "no records yet" - the app must still start, and SeedData can repopulate it.
                Items = new List<T>();
            }
        }

        public IEnumerable<T> GetAll()
        {
            return Items.ToList();
        }

        public T GetById(int id)
        {
            return Items.FirstOrDefault(item => GetId(item) == id);
        }

        public void Add(T item)
        {
            SetId(item, NextId());
            Items.Add(item);
            Save();
        }

        public void Update(T item)
        {
            int id = GetId(item);
            int index = Items.FindIndex(existing => GetId(existing) == id);
            if (index >= 0)
            {
                Items[index] = item;
                Save();
            }
        }

        public void Delete(int id)
        {
            int index = Items.FindIndex(existing => GetId(existing) == id);
            if (index >= 0)
            {
                Items.RemoveAt(index);
                Save();
            }
        }

        public void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(Items, Formatting.Indented);
                File.WriteAllText(_filePath, json);
            }
            catch (Exception ex)
            {
                throw new IOException("Could not save data to '" + _filePath + "'. " + ex.Message, ex);
            }
        }

        private int NextId()
        {
            // Highest existing id + 1, not Items.Count + 1, because deletions leave gaps that would otherwise cause duplicate ids.
            int max = 0;
            foreach (T item in Items)
            {
                int id = GetId(item);
                if (id > max)
                {
                    max = id;
                }
            }
            return max + 1;
        }
    }
}
