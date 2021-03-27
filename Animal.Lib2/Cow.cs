using BabyStroller.SDK;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animal.Lib2 {
    [Unfinished]
    public class Cow:IAnimal {
        public void Voice(int times) {
            for(int i = 0; i < times; i++) {
                Console.WriteLine("niu niu niu");
            }
        }
    }
}
