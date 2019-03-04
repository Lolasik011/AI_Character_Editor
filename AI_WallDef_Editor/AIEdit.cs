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
        public List<Defender> Defenders = new List<Defender>();
        public int TotalDef;
        public int WallDef;
    }

    public struct Defender
    {
        public Enums.UnitType UnitType;
        public Enums.DefUnit DefUnit;
    }
}
