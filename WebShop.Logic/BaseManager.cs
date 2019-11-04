using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public abstract class BaseManager<T>
        where T : BaseData //ar šo mēs pasakām, ka mainīgais T vienmēr būs klase (citādāk var būt jebkurš manīgais)
    {
        //generic types
        protected WebShopDB _db;
        protected abstract DbSet<T> Table { get; } //dbSet jāizmanto using || pateiktsim, kuru tabulu būs jāizmanto
        public BaseManager(WebShopDB db)
        {
            _db = db;
        }

       //T nosaka, ka tips, ko atgriezīs, ir mainīgs
        public T Get(int Id)
        {
            return Table.FirstOrDefault(i => i.Id == Id);
        }
        public List<T> GetAll()
        {
            return Table.ToList();
        }
        public T Create (T data)
        {
            Table.Add(data);
            _db.SaveChanges();

            return data;
        }
        public void Update (T data)
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
        //CRUD (create, read, undate, delete) saīsinājums tabulas darbībām
    }
}
