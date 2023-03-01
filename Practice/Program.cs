using System;
using System.Collections.Generic;

namespace Test3
{
    interface VideoGubun
    {
        VideoGubun DownVideoGubun();
        VideoGubun UpVideoGubun();
        string GetVideoGubun();
        int GetRentalPrice();
    }
    class HotVideo : VideoGubun
    {
        private HotVideo()
        { }
        public VideoGubun DownVideoGubun()
        {
            return NewVideo.CreateObject();
        }
        public VideoGubun UpVideoGubun()
        {
            return this;
        }
        private static VideoGubun m_StaticVideoGubun = null;
        public static VideoGubun CreateObject()
        {
            if (m_StaticVideoGubun == null)
            {
                m_StaticVideoGubun = new HotVideo();
            }
            return m_StaticVideoGubun;
        }
        public string GetVideoGubun()
        {
            return "최신비디오";
        }
        public int GetRentalPrice()
        {
            return 2500;
        }
    }
    class NewVideo : VideoGubun
    {
        public VideoGubun DownVideoGubun()
        {
            return NormalVideo.CreateObject();
        }
        public VideoGubun UpVideoGubun()
        {
            return HotVideo.CreateObject();
        }
        private static VideoGubun m_StaticVideoGubun = null;
        public static VideoGubun CreateObject()
        {
            if (m_StaticVideoGubun == null)
            {
                m_StaticVideoGubun = new NewVideo();
            }
            return m_StaticVideoGubun;
        }
        public string GetVideoGubun()
        {
            return "신규비디오";
        }
        public int GetRentalPrice()
        {
            return 2000;
        }
    }
    class NormalVideo : VideoGubun
    {
        public VideoGubun DownVideoGubun()
        {
            return OldVideo.CreateObject();
        }
        public VideoGubun UpVideoGubun()
        {
            return NewVideo.CreateObject();
        }
        private static VideoGubun m_StaticVideoGubun = null;
        public static VideoGubun CreateObject()
        {
            if (m_StaticVideoGubun == null)
            {
                m_StaticVideoGubun = new NormalVideo();
            }
            return m_StaticVideoGubun;
        }
        public string GetVideoGubun()
        {
            return "일반비디오";
        }
        public int GetRentalPrice()
        {
            return 1000;
        }
    }
    class OldVideo : VideoGubun
    {
        public VideoGubun DownVideoGubun()
        {
            return this;
        }
        public VideoGubun UpVideoGubun()
        {
            return NormalVideo.CreateObject();
        }

        private static VideoGubun m_StaticVideoGubun = null;
        public static VideoGubun CreateObject()
        {
            if (m_StaticVideoGubun == null)
            {
                m_StaticVideoGubun = new OldVideo();
            }
            return m_StaticVideoGubun;
        }
        public string GetVideoGubun()
        {
            return "구비디오";
        }
        public int GetRentalPrice()
        {
            return 500;
        }
    }
    class VideoGubunInputBase
    {
        public VideoGubunInputBase()
        {
            m_VideoGubunList.Add(HotVideo.CreateObject());
            m_VideoGubunList.Add(NormalVideo.CreateObject());
            m_VideoGubunList.Add(NewVideo.CreateObject());
            m_VideoGubunList.Add(OldVideo.CreateObject());
        }
        public virtual void DisplayMenu()
        {
        }
        public VideoGubun GetVideoGubun()
        {
            DisplayMenu();
            int iVideoGubun = int.Parse(Console.ReadLine());
            return m_VideoGubunList[iVideoGubun - 1];
        }
        protected List<VideoGubun> m_VideoGubunList = new List<VideoGubun>();
    }
    class VideoGubunInputRow : VideoGubunInputBase
    {
        public override void DisplayMenu()
        {
            for (int i = 0; i < m_VideoGubunList.Count; i++)
            {
                Console.WriteLine("{0}. {1} ", i + 1, m_VideoGubunList[i].GetVideoGubun());
            }
        }
    }
    class VideoGubunInputCol : VideoGubunInputBase
    {
        public override void DisplayMenu()
        {
            for (int i = 0; i < m_VideoGubunList.Count; i++)
            {
                Console.Write("{0}. {1} ", i + 1, m_VideoGubunList[i].GetVideoGubun());
            }
        }
    }
    class Video
    {
        public void UpVideoGubun()
        {
            m_VideoGubun = m_VideoGubun.UpVideoGubun();
        }
        public void DownVideoGubun()
        {
            m_VideoGubun = m_VideoGubun.DownVideoGubun();
        }
        public void InputData(VideoGubunInputBase vInput)
        {
            Console.Write("영화제목 : ");
            m_Title = Console.ReadLine();
            Console.Write("주연배우 : ");
            m_Actor = Console.ReadLine();
            Console.Write("영화감독 : ");
            m_Director = Console.ReadLine();
            m_VideoGubun = vInput.GetVideoGubun();
        }
        public void PrintData()
        {
            Console.WriteLine("영화제목 : {0}", m_Title);
            Console.WriteLine("주연배우 : {0}", m_Actor);
            Console.WriteLine("영화감독 : {0}", m_Director);
            Console.WriteLine("비디오구분 : {0}", m_VideoGubun.GetVideoGubun());
            Console.WriteLine("대여료 : {0}", m_VideoGubun.GetRentalPrice());
        }
        private string m_Title;
        private string m_Actor;
        private string m_Director;
        private VideoGubun m_VideoGubun;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Video v = new Video();
            VideoGubunInputBase vInput = new VideoGubunInputRow();
            v.InputData(vInput);
            v.PrintData();
            v.DownVideoGubun();
            v.PrintData();
            v.DownVideoGubun();
            v.PrintData();
            v.DownVideoGubun();
            v.PrintData();
        }
    }
}