using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HabitSculptor.Service.Users.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public bool TryAuthenticate(string passwordAttempt)
        {
            return PasswordsAreEqual(Password, passwordAttempt);
        }

        public void EncryptPassword()
        {
            Password = CreatePassword(Password);
        }

        private static string CreatePassword(string unHashed)
        {
            var x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(unHashed);
            data = x.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
        
        private static bool PasswordsAreEqual(string hashData, string hashUser)
        {
            hashUser = CreatePassword(hashUser);
            if (hashUser == hashData)
                return true;
            
            return false;
        }
    }
}