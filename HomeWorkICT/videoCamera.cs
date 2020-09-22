using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class videoCamera : IVideoCamera
    {
        public videoCameraType type;
        public string name { get; set; }

        public int returnCapacity()
        {
            return Program.rnd.Next(0, 100);
        }
    }
}
