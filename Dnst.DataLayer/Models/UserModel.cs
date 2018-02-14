using System;

namespace Dnst.DataLayer.Models
{
    public class UserModel
    {
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name { get; set; }

        public DateTime DateCreation { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
