using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class videoCameraAdapter : IVideoCamera
    {
        private videoCamera videoCamera;

        public videoCameraAdapter(videoCamera videoCamera)
        {
            this.videoCamera = videoCamera;
        }
        public int returnCapacity()
        {
            return videoCamera.returnCapacity() / 2;
        }
    }
}
