using System;

namespace NewProj
{

   public  class Calculate
    {
        int top;
        int x;


        int size;
        int val;

        int[] arr = new int[5];
        public Calculate()
        {
            size = 5;
            top = -1;

        }

        public void push(int x)
        {
            if (top >= size - 1)
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                top = top + 1;
                arr[top] = x;

                Console.WriteLine("The element inserted is {0} ", x);
            }
            for (int i = 0; i <= top; i++)
            {
                Console.WriteLine("Stack contains {0} ", arr[top]);

            }


        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("The stack is empty.");
            }
            else
            {
                int val;
                val = arr[top];
                Console.WriteLine("The item deleted is:{0}", val);
                top = top - 1;
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Stack contains {0} ", arr[top]);

                }

            }
        }



        public void Menu()
        {
            Console.WriteLine("1.push 2.pop 3.enqueue 4.dequeue");

            Console.WriteLine("Enter the choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {

                case 1:
                    push(10);
                    break;
                case 2:
                    pop();
                    break;



            }
        }

            public static void Main(String[] args)
            { 
                Calculate calculate = new Calculate();

                while (true)
                {
                    calculate.Menu();

                }

            }

        }
    }
