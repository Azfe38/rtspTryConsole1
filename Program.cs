using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rtspTryConsole1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string rtspUrl = "..."; // "rtsp://user:password@url/connectionSettings"


            VideoCapture capture = new VideoCapture(rtspUrl);    // Video yakalama 
            if (capture == null || !capture.IsOpened)
            {
                Console.WriteLine("RTSP kaynağına bağlanılamadı!");
                return;
            }

            while (true)
            {
                Mat frame = new Mat();
                if (capture.Read(frame))
                {

                    CvInvoke.Imshow("CANLI", frame);

                    
                    if (CvInvoke.WaitKey(1) == 113)  // 'q' tuşuna basıldığında döngüden çıkar
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Görüntü okunamadı!");
                    break;
                }
            }

            capture.Dispose();
            CvInvoke.DestroyAllWindows();
        }
    }
}

//._     _
//.\\ Λ //
//.||(|)||
//.\\\|///
//..\\|//
//...\|/ 
//....|  /
//..\ | /
//...\|/
//....|
//....|
//....|
//....|
//....|
//....|
// from ali özdemir in 2024 https://www.linkedin.com/in/alioz/  https://github.com/Azfe38