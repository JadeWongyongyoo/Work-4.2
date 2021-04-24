using System;

namespace สอบปฎิบัติครั้งที่1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            { 
             step = Math.Abs(dx);                                
            }
            else
                {
                    step = Math.Abs(dy);
                }
            dx /= step;
            dy /= step;
            x = x1;
            y = y1;
            int i = 1;
            if (i<=step)
            {
                for (x += dx; y += dy, i++)  
                    {
                    Console.Write(",");
                }
            }
            else
            {
                Console.Write("End");
            }
        }
        
    }
}
