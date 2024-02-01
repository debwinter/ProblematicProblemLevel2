using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProblematicLibrary;
using ProblematicProblemLevel2;
using static ProblematicProblemLevel2.Interaction.ConsoleLogging;

namespace ProblematicLibrary
{
    public class SithLord
    {
        //Comment this method out on MacOS
        public static void ExecuteOrder66()
        {
            try
            {
                Process.Start("OldManCanoli.jpg", Directory.GetCurrentDirectory());
            }
            catch (Win32Exception ex)
            {
                PassMessage($"Sith Lord has met his match: \n\n{ex.Message}", StatusCode.Error);
            }
        }
    }
}
