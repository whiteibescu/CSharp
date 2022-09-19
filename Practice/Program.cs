using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay08
{

    class Enemy
    {
        public Enemy(string EnemyName)
        {
            m_EnemyName = EnemyName;
            EnemyMgr.StopGameEvent += () => { };
        }

        private void EnemyMgr_StopGameEvent()
        {
            throw new NotImplementedException();
        }
        private string m_EnemyName;
    }
    delegate void StopGameDelegate();

    class EnemyMgr
    {
        public void DiePlayer()
        {
            StopGameEvent();
        }
        public static event StopGameDelegate StopGameEvent;
    }
    class Program
    {
        static void Main(string[] args)
        {
            EnemyMgr mgr = new EnemyMgr();
            Enemy m1 = new Enemy("적군1");
            Enemy m2 = new Enemy("적군2");
            Enemy m3 = new Enemy("적군3");
            Enemy m4 = new Enemy("적군4");
            Enemy m5 = new Enemy("적군5");
            Enemy m6 = new Enemy("적군6");
            mgr.DiePlayer();
        }
    }
}
