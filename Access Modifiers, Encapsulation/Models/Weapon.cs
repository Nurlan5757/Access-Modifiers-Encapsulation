using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Encapsulation.Models
{
    internal class Weapon
    {
        private int _bulletCapacity;
        private int _bulletCount;
        private double _combDischargeSecond;
        private bool _shootingMode=true;


        public int BulletCapacity
        {
            get 
            { 
                return _bulletCapacity; 
            }
            set
            {
                if(value > 0)
                { 
                    _bulletCapacity = value;
                   
                }
                else
                {
                    Console.WriteLine("yanlisdir");
                   
                }
            }
        }

        public int BulletCount
        {
            get
            {
                return _bulletCount;
            }
            set
            {
                if (value > 0)
                {
                    _bulletCount = value;  
                    
                }
               /* else
                {
                    Console.WriteLine("gulle bitdi");
                }*/
               
            }
        }

        public double CombDischargeSecond
        {
            get
            {
                return _combDischargeSecond;
            }
            set
            {
                if (value > 0) 
                { 
                    _combDischargeSecond = value;
                  
                }
                
            }
        }

        public bool ShootingMode
        {
            get
            {
                return _shootingMode;
            }
            set
            {
               
                
            }

        }



        public Weapon(int bulletCapacity, int bulletCount, double combDischargeSecond, bool shootingMode)
        {
            BulletCapacity = bulletCapacity;
            BulletCount = bulletCount;
            CombDischargeSecond = combDischargeSecond;
            ShootingMode = shootingMode;
        }


        public void Shoot()
        {
            
                if (BulletCount >0)
                {
                    BulletCount--;
                
                    
                }
            Console.WriteLine("piyu piyu");

        }

        public void Fire()
        { 
           
                while (BulletCount !=0 )
                {
                    BulletCount--;
                    CombDischargeSecond++;
                break;
                      
                }
            Console.WriteLine(CombDischargeSecond++);


        }

        public void GetRemainBulletCount()
        {
            
                while (BulletCapacity != BulletCount)
                {
                    BulletCount++;
                   break;
                }
            Console.WriteLine(BulletCount);


        }

        public void Reload()
        {

        }

        public void ChangeFireMode()
        {

        }

        
    }
}
