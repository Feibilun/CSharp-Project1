using BabyStroller.SDK;
using System;

namespace Animal.Lib {
    public class Cat:IAnimal {
        public void Voice(int times) {
            for(int i = 0; i < times; i++) {
                Console.WriteLine("mi mi mi");
            }
        }
    }
}
