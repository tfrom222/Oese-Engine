using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharpex2D;
using Sharpex2D.Rendering.Scene;

namespace myGame
{
    class EngineClass
    {
        public Game game;

        

        bool shouldClose = false;

        
        


        EngineWindow mainWindow;

        public void CloseGame()
        {
            shouldClose = true;
        }


        public bool shouldGameClose()
        {
            return shouldClose;
        }

        public void Initialize(int Width, int Height, string title)
        {
            Sharpex2D.Rendering.Scene.Scene g;

           



                    
           

        }

        
    }
}
