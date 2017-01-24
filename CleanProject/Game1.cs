using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace CleanGame1
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Add your variables here.
        
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Console.WriteLine("Game created");
        }

        protected override void Initialize()
        {
            base.Initialize();

            //Add your initialization code here.


            Console.WriteLine("All initialized");
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Add your new instance code here.


            //Add your loadcontent code here.


            Console.WriteLine("Content loaded");
        }

        protected override void UnloadContent()
        {
            Console.WriteLine("Content unloaded");
        }

        protected override void Update(GameTime gameTime)
        {
            //Add your update code here.


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Add your Draw code here.


            base.Draw(gameTime);
        }
    }
}
