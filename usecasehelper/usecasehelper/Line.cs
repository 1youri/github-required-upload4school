﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usecasehelper
{
    public class Line
    {
        //public int acindex;
        //public int ucindex;
        public int x1;
        public int y1;
        public int x2;
        public int y2;

        public Line(/*int acindex, int ucindex, */int x1, int y1, int x2, int y2)
        {
            //this.ucindex = ucindex;
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
    }
}
