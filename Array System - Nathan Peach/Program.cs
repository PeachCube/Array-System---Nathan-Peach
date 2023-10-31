using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_System___Nathan_Peach
{
    internal class Program
    {
        static int equipped;
        static string[] weapons = {"Pistol", "Assault Rifle", "Shotgun", "Rocket Launcher" };
        static int[] ammo = { 0, 0, 0, 0};//no ammo for any weapons by default
        //ammo types correspond to weapon types according to integer values respectively
        static void Main(string[] args)
        {
            equipped = 0;
            ShowHud();
            
            
        
        }
        static void ShowHud()
        {
            Console.WriteLine("Weapon: " + weapons[equipped]);
            Console.ReadKey(true);
        }
        static void Fire()
        {
          
        }
        static void Reload()
        {

        }
    }
}
