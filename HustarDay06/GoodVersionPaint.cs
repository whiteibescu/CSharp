using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay06
{
    interface IDrawObject
    {
        void Draw();
        string GetDrawObjectName();
        IDrawObject Clone();
    }
    class ToolbarMenu
    {
        private List<IDrawObject> m_MenuObject = new List<IDrawObject>()
        {
            new Line(),new Triangle(), new Rectangle(), new Circle(), new FreeLine()
        };
        
        private List<IDrawObject> m_MenuBuffer = new List<IDrawObject>()
        {

        };

        public IDrawObject SelectDrawObject()
        {
            int i = 0;
            for (; i < m_MenuObject.Count; i++)
            {
                Console.WriteLine("{0}, {1}", i + 1, m_MenuObject[i].GetDrawObjectName());
            }
            Console.WriteLine("{0}, 메뉴삭제", i + 1);
            Console.WriteLine("{0}, 메뉴추가", i + 2);
            int iObjectGubun = int.Parse(Console.ReadLine());
            if (iObjectGubun == i +1)
            {
                m_MenuBuffer.Add(m_MenuObject[0]);
                m_MenuObject.RemoveAt(0);
            }
            else if (iObjectGubun == i + 2)
            {
                if (m_MenuBuffer.Count > 0)
                {
                    m_MenuObject.Insert(0, m_MenuBuffer[m_MenuBuffer.Count-1]);
                    m_MenuBuffer.RemoveAt(m_MenuBuffer.Count - 1);
                }
            }

            if (iObjectGubun <= 0 || iObjectGubun >= m_MenuObject.Count) 
            {
                return null;
            }
            return m_MenuObject[iObjectGubun - 1];
        }
        class PaintShop
        {
            public void DrawPaintShop()
            {
                for (int i = 0; i < m_DrawList.Count; i++)
                {
                    m_DrawList[i].Draw();
                }
            }
            public void InputDrawObject(IDrawObject selObject)
            {
                if (selObject != null)
                {
                    m_DrawList.Add(selObject.Clone());
                }
            }
            public void Menu()
            {
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
                                selObject = m_ToolBarMenu.SelectDrawObject();
                            }
                            break;
                        case 2:
                            {
                                InputDrawObject(selObject);
                            }
                            break;
                        case 3:
                            {
                                DrawPaintShop();
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            List<IDrawObject> m_DrawList = new List<IDrawObject>();                
            ToolbarMenu m_ToolBarMenu = new ToolbarMenu();
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
                PaintShop p = new PaintShop();
                p.Menu();

            }
        }
    }
}