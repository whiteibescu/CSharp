using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        { }
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
        private static Weapon m_weapon = null;
    }
    class Missile : Weapon
    {
        private Missile()
        { }
        public override void Attack()
        {
            Console.WriteLine("미사일 공격");
        }
        public static Weapon CreateObject()
        {
            if (m_weapon == null)
            {
                m_weapon = new Missile();
            }
            return m_weapon;
        }
        private static Weapon m_weapon = null;
    }
    class Sword : Weapon
    {
        private Sword()
        { }
        public override void Attack()
        {
            Console.WriteLine("칼 공격");
        }
        public static Weapon CreateObject()
        {
            if (m_weapon == null)
            {
                m_weapon = new Sword();
            }
            return m_weapon;
        }
        private static Weapon m_weapon = null;

    }
    class Robot
    {
        public void ChangeWeapon(Weapon weapon)
        {
            m_Weapon = weapon;
        }
        public void Attack()
        {
            m_Weapon.Attack();
        }
        private Weapon m_Weapon = Gun.CreateObject();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Robot r = new Robot();
            r.Attack();
            r.ChangeWeapon(Missile.CreateObject());
            r.Attack();
            r.ChangeWeapon(Sword.CreateObject());
            r.Attack();
            r.ChangeWeapon(Missile.CreateObject());
            r.Attack();
        }
    }
}