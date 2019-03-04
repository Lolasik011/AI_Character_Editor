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


        public static void CreateScript(AIEdit edit)
        {
            if (File.Exists(edit.AI.ToString() + ".aidm"))
                File.Delete(edit.AI.ToString() + ".aidm");

            try
            {

                var fileStream = new FileStream(edit.AI.ToString() + ".aidm", FileMode.CreateNew, FileAccess.Write);
                var streamWriter = new StreamWriter(fileStream);

                streamWriter.WriteLine("AI_Defence\n{");
                streamWriter.WriteLine($"\tAI_Lord={edit.AI.ToString()};");
                streamWriter.WriteLine($"\tTotalDef={edit.TotalDef};");
                streamWriter.WriteLine($"\tWallDef={edit.WallDef};");
                streamWriter.WriteLine("\tDefUnits\n\t{");


                for (var i = 0; i < edit.Defenders.Count(); i++)
                {
                    Defender x = edit.Defenders[i];
                    var hexUnitType = ToHex((int)edit.Defenders[i].UnitType);
                    streamWriter.WriteLine($"\t\t{edit.Defenders[i].DefUnit},{hexUnitType};");
                }
                streamWriter.WriteLine("\t}");

                streamWriter.WriteLine("}");

                streamWriter.Close();
                fileStream.Close();

            }catch(Exception exc)
            {
                
            }
        } 

        public static void LoadScript(string scriptPath)
        {
            if (!File.Exists(scriptPath) || Path.GetExtension(scriptPath) != ".aidm")
                return;

            var edit = new AIEdit();

            var text = File.ReadAllLines(scriptPath);
            if (text.Length <= 1)
                return;
            else
            {
                Enum.TryParse(text[2].Split('=').Last().Split(';').First(), out edit.AI);
                edit.TotalDef = Convert.ToInt32(text[3].Split('=').Last().Split(';').First());
                edit.WallDef = Convert.ToInt32(text[4].Split('=').Last().Split(';').First());
                
                //Add the Defenders
            }
        }
    }
}
