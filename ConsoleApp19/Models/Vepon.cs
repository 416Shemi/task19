using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19.Models
{
    class Vepon
    {

        private int _BulledCapacity;
        private int _NumberBulletsin;
        private int _SecondsCombing;
        private string _AtisMode;
        public int BulledCapacity
        {
            get
            {
                return _BulledCapacity;
            }
            set
            {
                if(value>0 && value < 50)
                {
                    _BulledCapacity = value;
                    return;
                }
                else
                {
                    Console.WriteLine("Uygun deyil");
                }
            }
        }
        public int NumberBulletsin
        {
            get
            {
                return _NumberBulletsin;
            }
            set
            {
                if(value>3 && value < 20)
                {
                    _NumberBulletsin = value;
                }
                else
                {
                    Console.WriteLine("Duzgun daxl edin");
                }
            }
        }
        public int SecondsCombing
        {
            get
            {
                return _SecondsCombing;
            }
            set
            {
                if(value>0 && value < 5)
                {
                    _SecondsCombing = value;

                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin");
                }
            }
        }
        public string AtisMode
        {
            get
            {
                return _AtisMode;
            }
            
        }
        public Vepon(int BulledCapacity, int NumberBulletsin, int SecondsCombing, string AtisMode)
        {
            this._BulledCapacity = BulledCapacity;
            this._NumberBulletsin = NumberBulletsin;
            this._SecondsCombing = SecondsCombing;
            this._AtisMode = AtisMode;
        }
        public void Shoot()
        {
            int k = 0;
            if (k > 0)
            {
                k--;
                Console.WriteLine("A projectile was fired");
            }
            else
            {
                Console.WriteLine("There are no shells");
            }
        }
        public void Fire()
        {
            
            {
                int cont=0;
                if (cont == 0)
                {
                    cont = _SecondsCombing;
                }

            }
            

        }
        public void GetRemainBulletCount()
        {

            if (_NumberBulletsin < _BulledCapacity)
            {
                Console.WriteLine(_BulledCapacity - _NumberBulletsin);

            }
            else
            {
                Console.WriteLine("The comb is full");
            }

        }
        public void Reload()
        {
            if (_NumberBulletsin < _BulledCapacity)
            {

                _NumberBulletsin = _BulledCapacity;
                Console.WriteLine("The comb is filled");
            }

            else
            {
                Console.WriteLine("The comb is filled");
            }

        }
        public void ChangeFireMode()
        {
            if (_AtisMode == "true")
            {
                Console.WriteLine("Shooting mode is single");
            }
            else if (_AtisMode == "false")
            {
                Console.WriteLine("Shooting mode is automatic");
            }
        }
    }
}
