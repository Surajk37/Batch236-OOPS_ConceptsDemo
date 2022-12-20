using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo236Batch.Encapsulation
{
    internal class Account
    {
        private string userName;
        private string password;

        public string Name
        {
            get
            {
                return userName;
            }
            set
            {
                if (value.Length >= 3)
                {
                    userName = value;
                }

            }
        }
        public string Password
        {

            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
    }
}
