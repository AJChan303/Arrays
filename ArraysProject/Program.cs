﻿using System;

namespace ArraysProject {
    class Program {
        static void Main(string[] args) {
            int[] frames = new int[10];
            frames[0] = 10;
            frames[1] = 17;
            frames[2] = 15;
            frames[3] = 30;
            frames[4] = 22;
            frames[5] = 28;
            frames[6] = 10;
            frames[7] = 22;
            frames[8] = 16;
            frames[9] = 19;

            int total = 0;
            int index = 0;
            while (index < 10) {
                total = total + frames[index];
                index = index + 1;

            }
            Console.WriteLine($"Total is {total}");
        }
    }
}
