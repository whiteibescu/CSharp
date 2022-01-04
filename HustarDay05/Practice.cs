using System;
using System.Collections;

namespace letsget
{
    class evening
    {
        static void Main2(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while(que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }


        }
    }
}