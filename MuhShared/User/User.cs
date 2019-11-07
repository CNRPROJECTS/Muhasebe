using System;
using System.ComponentModel.DataAnnotations;

namespace MuhShared
{
    public class MUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakılamaz!")]
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Isactive { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdate { get; set; }
        //public string Token { get; set; }


    }

    public class MUserLogin
    {
        [Required(ErrorMessage = "Kullanıcı Adı boş bırakılamaz!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz!")]
        public string Password { get; set; }
    }
}