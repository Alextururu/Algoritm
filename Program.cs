using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Algoritm
{
    internal class Program
    {

        static void Main(string[] args)
        {
            User user1 = new User("alex","Алексей",false);
            User user2 = new User("dima", "Дмитрий", true);
            User user3 = new User("natasha", "Наталья", false);
            List<User> users = new List<User>() { user1,user2,user3};
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            bool hasUser = false;
            foreach (User user in users)
            {
                if (user.Login == login)
                {
                    hasUser=true;
                    if(user.IsPremium==false)
                    {
                        ShowAds();
                    }
                    Console.WriteLine("Доброго времени суток " + user.Name);
                    break;
                }
            }
            if(hasUser==false)
            {
                Console.WriteLine("Пользователь не найден!");
            }
            Console.ReadKey();
        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string login, string name, bool isPremium)
        {
            Login = login;
            Name = name;
            IsPremium = isPremium;
        }
    }
}
