using System;
using System.Collections.Generic;
using System.Text;

namespace DesignWeek1
{
    class SingeltonEg
    {
        private static readonly SingeltonEg se = new SingeltonEg();
        private SingeltonEg() { }
        static SingeltonEg() { }

        public static SingeltonEg GetInstance()
        {
            return se;
        }
        public static SingeltonEg GetObject { get; set; }

        
    }
}
