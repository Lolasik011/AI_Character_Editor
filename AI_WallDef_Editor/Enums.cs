using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_WallDef_Editor
{
    public class Enums
    {
        public enum AI_Lord
        {
            Rat,
            Snake,
            Pig,
            Wolf,

            Sultan,
            Caliph,
            Richard,
            Saladin,

            Wazir,
            Emir,
            Nizar,
            Sheriff,
            Frederick,
            Philipp,
            Marshall,
            Abbot
        }
        public enum UnitType
        {
            NONE = 0x00,
            Tunnelers = 0x05,
            EuropeanArchers = 0x16,
            Crossbowmen = 0x17,
            Spearmen = 0x18,
            Pikemen = 0x19,
            Swordsmen = 0x1B,
            Knights = 0x1C,
            Engineers = 0x1E,
            Monks = 0x25,
            ArabianArchers = 0x46,
        }

        public enum DefUnit
        {
            DefUnit1,
            DefUnit2,
            DefUnit3,
            DefUnit4,
            DefUnit5,
            DefUnit6,
            DefUnit7,
            DefUnit8
        }
    }


}
