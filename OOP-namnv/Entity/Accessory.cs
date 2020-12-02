﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_namnv.Entity
{
    class Accessory
    {
        public int id;
        public string name;

        public Accessory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
}
