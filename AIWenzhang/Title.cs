﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIWenzhang
{
    class Title
    {
        int id;
        string name;

        public Title(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        string gettitle()
        {

            return name;
        }

        public void settitle(string title)
        {
            this.name = title;
        }

    }
}
