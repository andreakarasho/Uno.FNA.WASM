using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using SDL2;

namespace uno.test
{
    class GameClass : Game
    {
        private GraphicsDeviceManager _manager;
        public GameClass()
        {
            Console.WriteLine("creating device manager");
           
            _manager = new GraphicsDeviceManager(this);
            _manager.PreparingDeviceSettings += (sender, e) => { e.GraphicsDeviceInformation.PresentationParameters.RenderTargetUsage = RenderTargetUsage.DiscardContents; };
            _manager.PreferredDepthStencilFormat = DepthFormat.Depth24Stencil8;

            IsFixedTimeStep = false;
            TargetElapsedTime = TimeSpan.FromMilliseconds(1000.0 / 60.0);
            InactiveSleepTime = TimeSpan.Zero;
        }

       override protected void Initialize()
        {
            base.Initialize();
        }

        override protected void LoadContent()
        {
            base.LoadContent();
        }

        override protected void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        override protected void Draw(GameTime gameTime)
        {
            Console.WriteLine("time: {0}/{1}", gameTime.TotalGameTime, gameTime.ElapsedGameTime);
            GraphicsDevice.Clear(Color.CornflowerBlue);

            base.Draw(gameTime);
        }     
    }
    
    class Program
    {
        private static GameClass _app;

        static void Main(string[] args)
        {
            Console.WriteLine(SDL.SDL_GetPlatform());

            //SDL.SDL_SetHint("FNA3D_OPENGL_FORCE_ES3", "0");
            //SDL.SDL_SetHint("FNA3D_OPENGL_FORCE_COMPATIBILITY_PROFILE", "1");


            _app = new GameClass();
            Console.WriteLine("run");
            _app.Run();
            _app.Dispose();
        }
    }
}
