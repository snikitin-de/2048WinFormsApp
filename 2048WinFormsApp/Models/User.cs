using Newtonsoft.Json;

namespace _2048WinFormsApp.Models
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
