using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    interface IDrawObject
    {
        void Draw();
        string GetDrawObjectName();
        IDrawObject Clone();
    }
    class Line : IDrawObject
    {
        public IDrawObject Clone()
        {
            return new Line();
        }
        public void Draw()
        {
            Console.WriteLine("라인 그리기");
        }

        public string GetDrawObjectName()
        {
            return "라인";
        }
    }
    class Triangle : IDrawObject
    {
        public IDrawObject Clone()
        {
            return new Triangle();
        }
        public void Draw()
        {
            Console.WriteLine("삼각형 그리기");
        }

        public string GetDrawObjectName()
        {
            return "삼각형";
        }
    }
    class Rectangle : IDrawObject
    {
        public IDrawObject Clone()
        {
            return new Rectangle();
        }
        public void Draw()
        {
            Console.WriteLine("사각형 그리기");
        }
        public string GetDrawObjectName()
        {
            return "사각형";
        }
    }
    class Circle : IDrawObject
    {
        public IDrawObject Clone()
        {
            return new Circle();
        }

        public void Draw()
        {
            Console.WriteLine("원형 그리기");
        }
        public string GetDrawObjectName()
        {
            return "원형";
        }
    }
    class FreeLine : IDrawObject
    {
        public IDrawObject Clone()
        {
            return new FreeLine();
        }

        public string GetDrawObjectName()
        {
            return "자유곡선";
        }
        public void Draw()
        {
            Console.WriteLine("자유곡선 그리기 시작");
            for (int i = 0; i < m_FreeLine.Count; i++)
            {
                m_FreeLine[i].Draw();
            }
            Console.WriteLine("자유곡선 그리기 종료");
        }
        private List<IDrawObject> m_FreeLine = new List<IDrawObject>() { new Line(), new Line(),
        new Line(),new Line(),new Line(),new Line()};
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IDrawObject> drawList = new List<IDrawObject>();
            int iChoice = 1;
            IDrawObject selObject = null;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 객체선택");
                Console.WriteLine("2. 그리기");
                Console.WriteLine("3. 그림판보기");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("1. 라인");
                            Console.WriteLine("2. 삼각형");
                            Console.WriteLine("3. 사각형");
                            Console.WriteLine("4. 원형");
                            Console.WriteLine("5. 자유곡선");
                            int iObjectGubun = int.Parse(Console.ReadLine());
                            switch (iObjectGubun)
                            {
                                case 1:
                                    selObject = new Line();
                                    break;
                                case 2:
                                    selObject = new Triangle();
                                    break;
                                case 3:
                                    selObject = new Rectangle();
                                    break;
                                case 4:
                                    selObject = new Circle();
                                    break;
                                case 5:
                                    selObject = new FreeLine();
                                    break;
                                default:
                                    selObject = null;
                                    break;
                            }
                        }
                        break;
                    case 2:
                        {
                            if (selObject != null)
                            {
                                drawList.Add(selObject.Clone());
                            }
                        }
                        break;
                    case 3:
                        {
                            for (int i = 0; i < drawList.Count; i++)
                            {
                                drawList[i].Draw();
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}