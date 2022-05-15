using System;

namespace classProject2
{
    static class myClass1
    {
        public static int Plus(int a, int b)
        {
            WritePlus(a, b);
            return a + b;
        }
        private static void WritePlus(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine(a + b);
        }
    }

    public class Program
    {

        class nuclearLauncher
        {
            int timer;
            public nuclearLauncher(int timer)
            {
                this.timer = timer;
            }
            public void Fire(int myTimer)
            {
                timer = myTimer;
                while (timer >= 0)
                {
                    Console.WriteLine(timer);
                    timer--;
                }
                Console.WriteLine("발사");
            }
            internal void Fire()
            {
                Fire(timer);
            }
        }
        static void Main(string[] args)
        {
            nuclearLauncher launcher1 = new nuclearLauncher(5);
            nuclearLauncher launcher2 = new nuclearLauncher(10);
            launcher1.Fire();
            launcher2.Fire();
        } // 잠시 변경하기
    }
}
