using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class controller
    {
        private static controller ctrl;

        public static controller instance
        {
            get
            {
                if (ctrl == null) ctrl = new controller();
                return ctrl;
            }
        }

        videoCameraController videoCamController;
        Dictionary<string, int> streamData;
        public void startProcess(int videoCamNum)
        {
            videoCamController = new videoCameraController(videoCamNum);
            streamData = videoCamController.returnCamerasData();
        }

        public void printReport()
        {
            foreach (KeyValuePair<string,int> k in streamData)
            {
                Console.WriteLine("Камера: {0}, время: {1}", k.Key, k.Value);
            }
        }

    }
}
