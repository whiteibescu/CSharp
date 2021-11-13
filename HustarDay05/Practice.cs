using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay05
{
    class Weapon
    {
        public virtual void Attack()
        {

        }
    }

    class Gun : Weapon
    {
        private Gun()
        {

        }
        public override void Attack()
        {
            Console.WriteLine("총 공격");
        }
        public static Weapon CreateObject()
        {
            if (m_weapon == null)
            {
                m_weapon = new Gun();
            }
            return m_weapon;
        }
        private static Weapon weapon = null;
    }
}
