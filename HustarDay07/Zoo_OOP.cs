using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test8
{
    interface IShape
    {
        string GetShapeName();
        void DrawShape();
        IShape Clone();
    }
    class Line : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("라인그리기");
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
    class Triangle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("삼각형그리기");
        }
        public string GetShapeName()
        {
            return "삼각형";
        }
        public IShape Clone()
        {
            return new Triangle();
        }
    }
    class Rectangle : IShape
    {
        public void DrawShape()
        {
            Console.WriteLine("사각형그리기");
        }
        public string GetShapeName()
        {
            return "사각형";
        }
        public IShape Clone()
        {
            return new Rectangle();
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
        {
            new Line(),new Line(),new Line(),new Line(),new Line(),new Line()
        };
    }
    delegate void DispTitle();
    static class ToolBarMenu
    {
        private static void DispEmpty()
        {

        }
        private static void DispAddMenuTitle()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("추가할 도형을 선택하세요...");
            Console.WriteLine("=========================");
        }
        private static void DisplayMenu(List<IShape> toolBarMenu, DispTitle dispTitle)
        {
            dispTitle();
            for (int i = 0; i < toolBarMenu.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, toolBarMenu[i].GetShapeName());
            }
        }
        private static void MoveMenuItem(List<IShape> Source, List<IShape> Dest, int iIndex)
        {
            Dest.Add(Source[iIndex]);
            Source.RemoveAt(iIndex);
        }
        private static void AddToolBarMenuItem()
        {
            DisplayMenu(m_ToolBarMenuBuffer, DispAddMenuTitle);
            int iDelChoice = int.Parse(Console.ReadLine());
            MoveMenuItem(m_ToolBarMenuBuffer, m_ToolBarMenu, iDelChoice - 1);
        }
        public static IShape Menu()
        {
            DisplayMenu(m_ToolBarMenu, DispEmpty);
            Console.WriteLine("{0}. 툴바메뉴삭제", m_ToolBarMenu.Count + 1);
            Console.WriteLine("{0}. 툴바메뉴추가", m_ToolBarMenu.Count + 2);
            int iChoice = int.Parse(Console.ReadLine());
            if (iChoice == m_ToolBarMenu.Count + 1)
            {
                MoveMenuItem(m_ToolBarMenu, m_ToolBarMenuBuffer, 0);
                return null;
            }
            if (iChoice == m_ToolBarMenu.Count + 2)
            {
                AddToolBarMenuItem();
                return null;
            }
            if (iChoice <= 0 || iChoice > m_ToolBarMenu.Count)
            {
                return null;
            }
            return m_ToolBarMenu[iChoice - 1];
        }
        private static List<IShape> m_ToolBarMenu = new List<IShape>()
        {
            new Line(),new Triangle(),new Rectangle(), new FreeLine()
        };
        private static List<IShape> m_ToolBarMenuBuffer = new List<IShape>();
    }
    class PaintShop
    {
        public void PrintShape()
        {
            for (int i = 0; i < m_ShapeList.Count; i++)
            {
                m_ShapeList[i].DrawShape();
            }
        }
        public void AddShape(IShape selShape)
        {
            if (selShape != null)
            {
                m_ShapeList.Add(selShape.Clone());
            }
        }
        public IShape SelShape()
        {
            return ToolBarMenu.Menu();
        }
        public void Menu()
        {
            IShape selShape = null;
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 동물선택");
                Console.WriteLine("2. 동물추가");
                Console.WriteLine("3. 그림판 보기");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        Console.WriteLine("되냐");
                        selShape = SelShape();
                        if (selShape != null)
                        {
                            Console.WriteLine("가자");
                            AddShape(selShape);
                        }
                        break;
                    case 2:
                        AddShape(selShape);
                        break;
                    case 3:
                        PrintShape();
                        break;
                }
            }
        }
        private List<IShape> m_ShapeList = new List<IShape>();
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