using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRHustler_Test
{
    public class MonoTestClass : UnityEngine.MonoBehaviour
    {
        public MonoTestClass() : base(IntPtr.Zero) { }

        public void Update()
        {
            Console.WriteLine("Test Update()");
        }

        public void OnDestroy()
        {
            Console.WriteLine("Test OnDestroy()");
        }
    }
}
