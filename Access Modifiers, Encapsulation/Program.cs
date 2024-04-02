using Access_Modifiers__Encapsulation.Models;
using System.Reflection.Metadata;

namespace Access_Modifiers__Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Weapon a = new Weapon(30,10,0);
            a.Shoot();

            a.Fire();

            a.GetRemainBulletCount();



            do
            {
                Console.WriteLine(@"0. İnformasiya almaq üçün
1. Shoot metodu üçün
2. Fire metodu üçün
3. GetRemainBulletCount metodu üçün
4. Reload metodu üçün
5. ChangeFireMode metodu üçün
6. Proqramdan dayandırmaq üçün
qısayoldur.
7. Redaktə et");


                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        İnformasiya();
                        break;
                    case 1:
                        Shoot();
                        break;
                    case 2:
                        Fire();
                        break;
                    case 3:
                        GetRemainBulletCount();
                        break;
                    case 4:
                        Reload();
                        break;
                    case 5:
                        ChangeFireMode();
                        break;
                    case 6:
                        Proqramdan dayandırmaq();
                        break;
                    case 7:
                }

            } while (isContinue);
            Console.Clear();
            Console.WriteLine();
        }
    }
}
