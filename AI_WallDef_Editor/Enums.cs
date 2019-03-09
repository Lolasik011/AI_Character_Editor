using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Character_Editor
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
            Macemen = 0x1A,
            Swordsmen = 0x1B,
            Knights = 0x1C,
            Laddermen = 0x1D,
            Engineers = 0x1E,
            Monks = 0x25,
            ArabianArchers = 0x46,
            Slaves = 0x47,
            Slingers = 0x48,
            Assassins = 0x49,
            HorseArchers = 0x4A,
            ArabianSwordsmen = 0x4B,
            FireThrowers = 0x4C,
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
        public enum OffUnit
        {
            OfffUnit1,
            OffUnit2,
            OffUnit3,
            OffUnit4,
            OffUnit5,
            OffUnit6,
            OffUnit7,
            OffUnit8
        }

        public enum Goods
        {
            Lumber,
            Stone,
            Iron,
            Wheat,
            Flour,
            Bread,
            Fruits,
            Meat,
            Crossbows,
            Bows,
            Spears,
            Pikes,
            Maces,
            Swords,
            Cheese,
            LeatherArmour,
            IronArmour,
            Hop,
            Beer,
            Pitch,
            Gold
        }

        public enum RecruitSpeed
        {
            Maximum = 0,
            Extreme = 1,
            VeryHigh = 2,
            High = 3,
            Medium = 4,
            Slow = 5,
            VerySlow = 6,
            ExtremeSlow = 7,
            Null = 8
        }

        //public enum LikelyhoodToSendGoods
        //{
        //    Always,
        //    High,
        //    Medium,
        //    Low,
        //    VeryLow,
        //    OnlyIfInDanger,
        //    Never
        //}

        //public enum LikelyhoodToAttack
        //{
        //    Always,
        //    High,
        //    Medium,
        //    Low,
        //    VeryLow,
        //    OnlyIfAttacking,
        //    OnlyIfDefenceIsFull,
        //    Never
        //}

        //public enum LikelyhoodToDefend
        //{
        //    Always,
        //    High,
        //    Medium,
        //    Low,
        //    VeryLow,
        //    OnlyIfAttacking,
        //    OnlyIfDefenceIsFull,
        //    Never
        //}

        //public enum Relationship
        //{
        //    CloseFriends,
        //    Friends,
        //    Neutral,
        //    Enemies,
        //    Rivals
        //}
    }


}
