using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp19.Models;
namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {

            Vepon gun = new Vepon(30, 10, 2, "false");

            int key = 0;
            while (key != 6)
            {
                Console.WriteLine("key");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 0:
                        {
                            gun.Shoot();
                        }
                        break;
                    case 1:
                        {
                            gun.Fire();
                        }
                        break;
                    case 2:
                        {
                            gun.GetRemainBulletCount();
                        }
                        break;
                    case 3:
                        {
                            gun.Reload();
                        }
                        break;
                    case 4:
                        {
                            gun.ChangeFireMode();
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("this is wrong");
                        }
                        break;
                }
            }
        }
    }
}
