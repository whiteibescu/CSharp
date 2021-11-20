using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test9
{
    interface IShape
    {
        string GetShapeName();
        void DrawSahpe();
        IShape Clone();
    }

    class Line : IShape
    {
        public void DrawShape()
        {
            Console.Write("라인그리기");
        }
        public string GetShapeName()
        {
            return "라인";
        }
        public IShape Clone()
        {
            return new Line();
        }
    }

    class Triangle: IShape
    {
        public void DrawShape()
        {
            Console.Write("삼각형그리기");
        }
    }
    
    class Rectangle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("자유곡선 그리기 시작");
        }
    }
    
    class FreeLine : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("자유곡선 그리기 시작");
            for (int i = 0; i < m_LineList.Count; i++)
            {
                m_LineList[i].DrawShape();
            }
            Console.WriteLine("자유곡선 그리기 종료");
        }
        public string GetShapeName()
        {
            return "자유곡선";
        }
        public IShape Clone()
        {
            return new FreeLine();
        }
        private List<IShape> m_LineList = new List<IShape>()
        { new Line(), }
    }
}