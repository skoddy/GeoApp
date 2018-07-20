using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeoApp
{
    public class User
    {
        public int Id
        {
            get => default(int);
            set
            {
            }
        }

        public int Display_Name
        {
            get => default(int);
            set
            {
            }
        }

        public int Password
        {
            get => default(int);
            set
            {
            }
        }

        public User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SignIn()
        {
            throw new System.NotImplementedException();
        }

        public void SignOut()
        {
            throw new System.NotImplementedException();
        }

        public void SignUp()
        {
            throw new System.NotImplementedException();
        }
    }
}