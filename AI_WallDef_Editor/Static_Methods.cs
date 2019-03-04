using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

namespace AI_WallDef_Editor
{
    public static class Static_Methods
    {
        public static List<string> GetUnitTypes() => Enum.GetNames(typeof(Enums.UnitType)).ToList();
        public static string ToHex(int value) => String.Format("0x{0:X}", value);
        public static int FromHex(string value)
        {
            // strip the leading 0x
            if (value.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                value = value.Substring(2);
            }
            return Int32.Parse(value, NumberStyles.HexNumber);
        }


        public static bool CreateScript(AIEdit edit)
        {
            if (File.Exists(edit.AI.ToString() + ".aidm"))
                File.Delete(edit.AI.ToString() + ".aidm");

            try
            {

                var fileStream = new FileStream(edit.AI.ToString() + ".aidm", FileMode.CreateNew, FileAccess.Write);
                var streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine("AI_defence\n{");
                streamWriter.WriteLine($"\tAI_Lord={edit.AI.ToString()};");
                streamWriter.WriteLine($"\tTotalDef={edit.TotalDef};");
                streamWriter.WriteLine($"\tWallDef={edit.WallDef};");
                streamWriter.WriteLine("\tDefUnits\n\t{");


                for (var i = 0; i < edit.Defenders.Count(); i++)
                {
                    Defender x = edit.Defenders[i];
                    var hexUnitType = ToHex((int)edit.Defenders[i].UnitType);
                    streamWriter.WriteLine($"\t\t{edit.Defenders[i].DefUnit}={hexUnitType};");
                }
                streamWriter.WriteLine("\t}");

                streamWriter.WriteLine("}");

                streamWriter.Close();
                fileStream.Close();

            }catch(Exception exc)
            {
                return false;
            }

            return true;
        } 

        public static AIEdit LoadScript(string scriptPath)
        {
            if (!File.Exists(scriptPath) || Path.GetExtension(scriptPath) != ".aidm")
                return null;

            var edit = new AIEdit();

            var text = File.ReadAllLines(scriptPath);
            if (text.Length <= 1)
                return null;
            else
            {
                Enum.TryParse(text[2].Split('=').Last().Split(';').First(), out edit.AI);
                edit.TotalDef = Convert.ToInt32(text[3].Split('=').Last().Split(';').First());
                edit.WallDef = Convert.ToInt32(text[4].Split('=').Last().Split(';').First());

                //Add the Defenders
                var defender1 = text[7].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender2 = text[8].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender3 = text[9].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender4 = text[10].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender5 = text[11].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender6 = text[12].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender7 = text[13].Replace("\t", "").Replace(";", "").Split('=')[1];
                var defender8 = text[14].Replace("\t", "").Replace(";", "").Split('=')[1];

                Enums.UnitType unitType = Enums.UnitType.NONE;

                var hex = Convert.ToInt32(FromHex(defender1));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit1,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender2));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit2,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender3));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit3,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender4));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit4,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender5));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit5,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender6));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit6,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender7));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit7,
                    UnitType = unitType
                });

                hex = Convert.ToInt32(FromHex(defender8));
                unitType = (Enums.UnitType)hex;
                edit.Defenders.Add(new Defender()
                {
                    DefUnit = Enums.DefUnit.DefUnit8,
                    UnitType = unitType
                });

                return edit;
            }
        }
    }
}
