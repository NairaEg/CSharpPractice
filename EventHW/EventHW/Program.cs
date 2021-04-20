using System;
using System.Threading;

namespace EventHW
{
    public delegate void VideoRecordingSartsEventHandler();
    public delegate void VideoRecordingFinishEventHandler();
    class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video();
            video.StartEventSMS += new VideoRecordingSartsEventHandler(SentSMS);
            video.StartEventMail += new VideoRecordingSartsEventHandler(SentMail);
            video.myStartEvent();

            TimeSpan time = new TimeSpan(0, 0, 10);
            Thread.Sleep(time);
            video.FinishEventSMS += new VideoRecordingFinishEventHandler(SentSMSfinish);
            video.myFinishEvent();


        }
        static void SentSMS()
        {
            Console.WriteLine("I sent SMS - Video recording starts");
        }

        static void SentMail()
        {
            Console.WriteLine("I sent mail - Video recording starts");
        }

        static void SentSMSfinish()
        {
            Console.WriteLine("I sent SMS - Video recording finishes");
        }
    }



    class Video
    {
        public event VideoRecordingSartsEventHandler StartEventSMS = null;
        public event VideoRecordingSartsEventHandler StartEventMail = null;

        public event VideoRecordingFinishEventHandler FinishEventSMS = null;

        void myEventSMS()
        {
            if (StartEventSMS != null)
            {
                StartEventSMS.Invoke();
            }
        }
        void myEventMail()
        {
            if(StartEventMail != null)
            {
                StartEventMail.Invoke();
            }
        }
        public void myStartEvent()
        {
            bool result = true;
            while (result)
            {
                Console.WriteLine("Enter \"S\" - for start vidoe recording");
                string key = Console.ReadLine();
                switch (key.ToUpper())
                {
                    case "S":
                        myEventSMS();
                        myEventMail();
                        result = false;
                        break;
                    default:
                        Console.WriteLine("invalid key");
                        break;
                };
            }
        }

        public void myFinishEvent()
        {
            if(FinishEventSMS!=null)
            {
                FinishEventSMS.Invoke();
            }
        }

    }
}

