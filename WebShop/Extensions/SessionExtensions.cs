using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop
{
    public static class SessionExtensions
    {
        private const string MAIL = "usermail";
        private const string ID = "usermaid";
        private const string BASKET = "userbasket";
        public static void SetUserEmail(this ISession session, string email)  //no sākuma klase, ko gribam paplašināt, pēc tam mainīgie
        {
            session.SetString(MAIL, email);
        }
        public static string GetUserEmail(this ISession session)
        {
            return session.GetString(MAIL);
        }
        public static void SetUserId(this ISession session, int id)
        {
            session.SetInt32(ID, id);
        }
        public static int? GetUserId(this ISession session)
        {
            return session.GetInt32(ID);
        }
        public static void SetUserBasket(this ISession session, List<int> items)
        {
            var json = JsonConvert.SerializeObject(items);

            session.SetString(BASKET, json);
        }
        //tā kā nav ne string, ne int, tāpēc jāizmanto JSON, jo extensions saprot tikai string un int
        public static List<int> GetUserBasket(this ISession session) //list šobrīd ir mainīgā tips, saraksts ar cipariem(identifikatoriem)
        {
            var json = session.GetString(BASKET);
            return json == null ? null : JsonConvert.DeserializeObject<List<int>>(json);

        }
    }
}
