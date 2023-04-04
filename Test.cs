using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRHustler_Test
{
    [BManager.Attributes.ModuleInfo("Test Project", "1.0", "BlazeBest")]
    public class NameProject : BManager.VRModule
    {
        // Only: static Main() for Start()
        public static void Main()
        {
            Console.WriteLine("Test Project: Hello world!");
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            go.RegisterCustomComponent<MonoTestClass>();
        }

        // Not required, needed to ship the DLL
        public static void Unload()
        {
            Console.WriteLine("Test Project: Unload!");
        }
    }
}
