namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo() { Name = "Ali", Id = 1, Email = "ali@gmail.com", Phone = "2222", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Ahmet", Id = 2, Email = "abc@gmail.com", Phone = "4444", WillAttend = true });
            _users.Add(new UserInfo() { Name = "Canan", Id = 3, Email = "abd@gmail.com", Phone = "5555", WillAttend = false });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void CreateUSer(UserInfo user)
        {
            user.Id = Users.Count() + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}