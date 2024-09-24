using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThreads // Note: actual namespace depends on the project name.
{
    public class Program
    {

        static int cpt=12; //déclare le compteur à 12

        //Delegate
        public static void threadcallback(int i)
        {
            if(cpt/2==i)
            {
                Console.WriteLine("J'ai fais la moitié"); //S'execute à la moitié du compteur thread et s'affiche donc a la moitié+1
            }
            else if(i==cpt-1)
            {
                Console.WriteLine("J'ai finis"); //S'execute et s'affiche à la fin du compteur thread
            }
        }
        public static void Main(string[] args)
        {
            ThreadTest mt = new ThreadTest(12); //Permet d'executer 12 fois le thread qui est dans mythread.cs
            mt.callback += threadcallback; //delegate, permet d'executer la fonction (public static void threadcallback)
            Thread thread = new Thread(new ThreadStart(mt.ThreadLoop)); //Permet d'executer la fonction qui est dans mythread.cs(public void threadloop)
            thread.Start(); //Execute le thread
        }
    }
}