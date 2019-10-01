using System;

namespace CSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //make a bool, string, int variables
            bool isTrue =false;
            string word = "Hello The World";
            int x = 20;

            //chage their values to somthing else
            isTrue = true;
            word = "change the word";
            x = x + 15;

            //print their values with Console

            Console.WriteLine("print values of variables declared : {0}, {1}, {2}", isTrue, word,x);

            //do somthing with the while loop
              int count = 0;
              Console.WriteLine("While Loop");
              while(count < 10){
                  count ++;
                  Console.WriteLine(count);
                  
              }  

            // do something in a for loop
            Console.WriteLine("For Loop");
            for(int i =1; i<= 5; i++){
                Console.WriteLine(i+" x 2 = " + i*2);
            }

            //do something in a switch statement
            Console.WriteLine("Switch Statement");
            int y = 2;
            switch(y){
                case 1:
                    Console.WriteLine("This is case 1");
                    break;
                case 2:
                    Console.WriteLine("This is case 2");
                    break;
                default:
                    Console.WriteLine("Neither case 1 nore case 2");
                    break;
            }

            //do something with if , else if, else
                if(2<=5){
                    Console.WriteLine("2<5");
                }
                else if(2==2){
                    Console.WriteLine("it's 2");
                }
                else if( 2>3 ){
                    Console.WriteLine("2>3");
                }
                else{
                    Console.WriteLine("something else");
                }

            /*
                multi-line comments in C#
                hahaha
                format in Windows  Shift+Alt+F
             */

            // static method

            doSomething();

        }

        static void doSomething(){
                Console.WriteLine("This is a static method");
        }
    }

    
}
