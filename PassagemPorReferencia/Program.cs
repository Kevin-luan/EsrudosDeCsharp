﻿using System;

class Progrma{


    static void Main(){
      
      int num=10;

       dobrar(ref num);
            Console.WriteLine( num);
        
    }


    static void dobrar( ref int valor){
        valor*= 2;
    }
}