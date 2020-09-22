using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HomeWorkICT
{
    class videoCameraController
    {
        private List<videoCamera> videoCamList;

        public videoCameraController(int videoCamNum)
        {
            videoCamList = new List<videoCamera>();
            createCameras(videoCamNum);
        }

        private void createCameras(int num)
        {
            for (int i = 0; i < num; i++)
            {
                videoCamList.Add(new videoCamera() { name = "Видеокамера №" + (i + 1) });
            }
        }

        public Dictionary<string,int> returnCamerasData()
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            videoCameraAdapter videoCamAdapter;
            foreach (videoCamera camera in videoCamList)
            {
                videoCamAdapter = new videoCameraAdapter(camera);
                result.Add(camera.name, videoCamAdapter.returnCapacity());
            }

            return result;
        }
    }
}
