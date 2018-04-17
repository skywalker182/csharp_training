using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adressbook_test
{
    public class Contact
    {
        private string name;
        private string lastname;
        private string nickname;

        public Contact(string name, string lastname, string nickname)
        {
            this.name = name;
            this.lastname = lastname;
            this.nickname = nickname;
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public string Nickname
        {
            get
            {
                return nickname;
            }

            set
            {
                nickname = value;
            }
        }
    }
}

