using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeonBit.UI.Entities;

namespace Dragon_For_Honor
{
    class Menu_Manager
    {
        public static Menu menu;
        public static void Menu_Valtas(Menu menu)
        {
            foreach (var panel in GUI_Interface.Windows)
            {
                panel.Visible = false;
            }
            GUI_Interface.Windows[(int)menu].Visible = true;
        }

        public enum Menu
        {
            Fo_Menu,
            Uj_Jatek,
            Jatek_Betoltes,
            Beallitasok


        }
    }
}
