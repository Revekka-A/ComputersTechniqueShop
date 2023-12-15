using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAprepearing
{
    public class CheckUser
    {
        public string UserName { get; set; }
        public string UserPost { get; set; }
        public string UserPhoto { get; set; }
        public bool IsAdmin { get; }

        public CheckUser(string name, string post, string photo)
        {
            UserName = name.Trim(); //Trim() - удаляет лишние символы, оставляет только логин
            UserPost = post;
            UserPhoto = photo;
            if (post == "Администратор")
            {
                IsAdmin = true;
            }
            else
                IsAdmin = false;
        }
        public string Status => IsAdmin ? "Администратор" : "Кассир";
    }
}
