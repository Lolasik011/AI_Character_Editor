using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using UCP.AICharacters;
using System.Reflection;
using System.IO;

namespace AI_Character_Editor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // empty collection of characters
            AICCollection aicc = new AICCollection();

            // read .aic file from Resources/vanilla.aic into collection
            Assembly asm = Assembly.GetExecutingAssembly();
            using (Stream stream = asm.GetManifestResourceStream("AI_Character_Editor.Resources.vanilla.aic"))
                aicc.Read(stream);

            // get rat from collection
            AICharacter rat = aicc[AICIndex.Rat];

            // change personality
            rat.Personality.DefUnit1 = UnitType.EuropArcher;
            rat.Personality.DefTotal = 250;
            rat.Personality.DefWalls = 200;

            // save to file
            using (FileStream fs = new FileStream("output.aic", FileMode.Create))
                aicc.Write(fs);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
