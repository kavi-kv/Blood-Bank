using System.IO;

namespace Blood_Bank.View
{
      public  class RemUser
        {
            public string name;
            public string password;
        }
    public static class RememberUser
    {
        public static void SaveUserName(string username, string password = "")
        {
            RemUser r = new RemUser()
            {
                name = username,
                password = password
            };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(r);
            File.WriteAllText("remember.txt", json);
        }
        public static RemUser LoadUserName()
        {
            if (!File.Exists("remember.txt")) return new RemUser(); //just retunr empty one
            var remUser = Newtonsoft.Json.JsonConvert.DeserializeObject<RemUser>(File.ReadAllText("remember.txt"));
            if (remUser == null) return new RemUser();// if null return empty one
            return remUser;//if all succeed return the remUser
        }
    }
}
