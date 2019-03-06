using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_WallDef_Editor
{
    public class AIEdit
    {
        public Enums.AI_Lord AI;
        public List<DefendingUnit> Defenders = new List<DefendingUnit>();
        public int TotalDef;
        public int WallDef;

        public MarketBehaviour MarketBehaviour;
        public RecruitingBehaviour RecruitingBehaviour;
    }

    public class DefendingUnit
    {
        public Enums.UnitType UnitType;
        public Enums.DefUnit DefUnit;
    }
    public class AttackingUnit
    {
        public Enums.UnitType UnitType;
        public Enums.OffUnit AttackUnit;
    }

    public class MarketBehaviour
    {
        public List<Goods> GoodsToKeep = new List<Goods>();
        public int GoldToKeep;
    }

    public class RecruitingBehaviour
    {
        //public Enums.RecruitSpeed DefenceRecruitSpeed;
        //public Enums.RecruitSpeed OffenceRecruitSpeed;
        public Enums.RecruitSpeed RecruitSpeed;

        public List<DefendingUnit> Defenders = new List<DefendingUnit>();
        public int TotalDef;
        public int WallDef;

        public List<AttackingUnit> Attackers = new List<AttackingUnit>();
        public int FirstAttackForceSize;
        public int AttackForceIncreaseStatic; 
        public int AttackForceIncreaseMultiplier;
    }


    public class Goods
    {
        public Enums.Goods Good;
        public int Maximum;
        public int Minimum;
        public int QuantityToBuy;
        public int QuantityToSell;
        public bool BuyIn;
    }
}
