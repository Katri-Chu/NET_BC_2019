using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SludinajumuPortals.Logic
{
    public abstract class BaseManager<T>
        where T : BaseData
    {
        protected SludinajumuPortalsDB _db;
        protected abstract DbSet<T> Table { get; }

        public BaseManager(SludinajumuPortalsDB db)
        {
            _db = db;
        }

        public T Get(int Id)
        {
            return Table.FirstOrDefault(i => i.Id == Id);
        }
        public List<T> GetAll()
        {
            return Table.ToList();
        }
        public T Create(T data)
        {
            Table.Add(data);
            _db.SaveChanges();

            return data;
        }
        public void Update(T data)
        {
            Table.Update(data); //update automātiski atradīs, kurā tabulā jāveic izmaiņas
            _db.SaveChanges();
        }
        public void Delete(int id)
        {
            var item = Table.FirstOrDefault(i => i.Id == id);
            Table.Remove(item);
            _db.SaveChanges();
        }
    }
}
