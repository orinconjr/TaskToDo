namespace ORJ.TaskToDo.Domain.Entities
{
    public sealed class User : BaseEntity
    {
        public string Email { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public bool Active { get; private set; }

        public User(string email, string name, string password, bool active)
        {
            Email = email;
            Name = name;
            Password = password;
            Active = active;
        }

        public void SetUser(string email, string name, string password, bool active)
        {
            Email = email;
            Name = name;
            Password = password;
            Active = active;
        }
    }
}
