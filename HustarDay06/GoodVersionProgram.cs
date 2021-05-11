﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay06
{
    class VideoGubun
    {
        public virtual string GetVideoGubun()
        {
            return "";
        }
        public virtual int GetRentalPrice()
        {
            return 0;
        }
    }
    class HotVideo : VideoGubun
    {
        public override string GetVideoGubun()
        {
            return "최신비디오";
        }
        public override int GetRentalPrice()
        {
            return 2500;
        }
    }
    class NewVideo : VideoGubun
    {
        public override string GetVideoGubun()
        {
            return "신규비디오";
        }
        public override int GetRentalPrice()
        {
            return 2000;
        }
    }
    class NormalVideo : VideoGubun
    {
        public override string GetVideoGubun()
        {
            return "일반비디오";
        }
        public override int GetRentalPrice()
        {
            return 1000;
        }
    }
    class OldVideo : VideoGubun
    {
        public override string GetVideoGubun()
        {
            return "구비디오";
        }
        public override int GetRentalPrice()
        {
            return 500;
        }
    }
    class VideoGubunInputBase
    {
        public VideoGubunInputBase()
        {
            m_VideoGubunList.Add(new HotVideo());
            m_VideoGubunList.Add(new NormalVideo());
            m_VideoGubunList.Add(new NewVideo());
            m_VideoGubunList.Add(new OldVideo());
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
        }
    }
}