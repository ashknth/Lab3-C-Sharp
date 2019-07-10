
//.Net program to find the sum of two numbers.
using System;
namespace MyPT1
{
    class RunQueue
    {
       
        int a;
        int b;
        float sum;
        float sub;
        float mul;
        float div;
        int size;
        int x;
        int front;
        int rear;
        int []queue = new int[5];

        public RunQueue()
        {
            front = -1;
            rear = -1;
            size = 5;
        }

        public void getData()
        {
            Console.WriteLine("Enter 2 numbers ::");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
    
        }

        public void Add()
        {
            sum = a + b;
            Console.WriteLine("The sum of {0} and {1} is {2}.",a,b,sum);
        }

        public void Sub()
        {
            sub = a - b;
            Console.WriteLine("The difference of {0} and {1} is {2}.", a, b, sub);
        }
        public void Mul()
        {
            mul= a*b;
            Console.WriteLine("The product of {0} and {1} is {2}.", a, b, mul);
        }

        public void Div()
        {
            div = a/b;
            Console.WriteLine("The divison of {0} and {1} is {2}.", a, b, div);
        }



        public void enqueue(int x)
        {

            if (rear == size - 1)

            {
                Console.WriteLine("Queue full.");

            }
            else
            {
                if (front == -1)
                    front = 0;
   
                rear = rear + 1;
                queue[rear]=x;
                Console.WriteLine("The element enqueued is:{0}", x);
                for (int i = front; i <=rear; i++)
                {
                    Console.WriteLine("The queue contains::{0}",+queue[rear]);

                }
            }
        }
     
            public void dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue empty.");
                return;
            }
            else
            {
                int x;
                x=queue[front];
                Console.WriteLine("The dequeued element is:{0}", x);
                front++;
                for (int i = front; i <=rear; i++)
                {
                    Console.WriteLine("The queue contains::{0}",+queue[rear]);

                }
            }

        }

        void Display()
        {
            if (front == -1)
                Console.WriteLine("Queue empty.");

            else
            {

                for (int i = front; i <= rear; i++)

                    Console.WriteLine("The  elements is:{0}", queue[i]);
            }
        }



            public void Menu()
        {
            Console.WriteLine(" 8.getData  1.Add 2.sub 3.mul 4.div 5.enqueue 6.dequeue");

            Console.WriteLine("Enter the choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    Add();
                    break;
                case 2:
                    Sub();
                    break;
                case 3:
                    Mul();
                    break;

                case 4:
                    Div();
                    break;

                case 5:
                    enqueue(13);

                    break;
                case 6:
                    dequeue();
                    break;
                case 7:
                    Display();
                    break;
                case 8:
                  getData();
                    break;

            }

        }

        public static void Main(string[] args)
        {
            RunQueue queue = new RunQueue();


            while (true)
            {
                queue.Menu();

            }

        }

    }
}

