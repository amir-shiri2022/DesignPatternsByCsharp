﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator.Sample1.Iterator
{
    public class FacebookIterator : IIterator
    {
        private LinkedList<string> Users;
        private int position;
        public FacebookIterator(LinkedList<string> users)
        {
            Users = users;
            position = 0;
        }
        public void First()
        {
            position = 0;
        }

        public string Next()
        {
            return Users.ElementAt(position++);
        }

        public bool IsDone()
        {
            return position >= Users.Count;
        }

        public string CurrentItem()
        {
            return Users.ElementAt(position);
        }
    }
}
