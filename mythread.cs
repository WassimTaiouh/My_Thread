using System;
using System.Collections.Generic;
using System.Linq;

namespace MyThreads // Note: actual namespace depends on the project name.
{

    public class ThreadTest
    {
        
        private int cpt;
        public delegate void handler(int i); //delegate handler pour pouvoir declarer un callback
        public handler callback; //Delegate déclare callback
        public ThreadTest(int n)
        {
            cpt = n;
        }

        public void ThreadLoop()
        {   
            for(int i=0; i<cpt; i++)
            {
                //AFfiche dans la console le thread tant que i est inférieur au compteur 
                Console.WriteLine("Je travaille..."+(i+1));
                //Delegate. Fonction callback
                callback(i);
                //Le thread attend 50ms avant de recommencer
                Thread.Sleep(500);
            }
        }
    }
}