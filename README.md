# VRHustler_Test

Test Mod/Cheat/Plugin for VRChat

```cs
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
        }

        // Not required, needed to ship the DLL
        public static void Unload()
        {
            Console.WriteLine("Test Project: Unload!");
        }
    }
}
```

| IF Community | Developer |
|----------------|:-----------:|
| https://www.icefrag.ru/ | BlazeBest#1284 |
