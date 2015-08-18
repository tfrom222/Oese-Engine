using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Sharpex2D.GameService;

namespace myGame
{
   

    class Program
    {

       static EngineClass Engine = new EngineClass();

        static void Main(string[] args)
        {

            Engine.Initialize(1920, 1080, "My Game");

            while(!Engine.shouldGameClose())
            {

            }


            

        }





    }
}
