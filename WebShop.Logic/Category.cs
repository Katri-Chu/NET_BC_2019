using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class Category : BaseData
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        /// <summary>
        /// virskategorijas identifikators
        /// ja nav definēts - tad tā ir pamatkategorija
        /// </summary>
        public int? CategoryId { get; set; }
        //? jo nav nebūt vērtības. ? nozīmē, ka ir nullējams
        public int ItemCount { get; set; } 
    }
}
