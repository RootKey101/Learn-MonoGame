using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace InputWrapperProject
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Add your variables here.
        Texture2D image1; // The image1 to be loaded.
        Texture2D image2; // The image2 to be loaded.
        Vector2 positionImage1; // Position of image1.
        Vector2 positionImage2; // Position of image2.

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
            IsMouseVisible = true; // Show the mouse cursor while playing.

            positionImage1 = new Vector2(100f, 100f); // Initial position of image1.
            positionImage2 = new Vector2(200f, 200f); // Initial position of image2.

            Console.WriteLine("All initialized");
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            //Add your new instance code here.


            //Add your loadcontent code here.
            image1 = Content.Load<Texture2D>("image1Texture"); // Assign to image1 the texture called "image1Texture" from the ContentPipeline.
            image2 = Content.Load<Texture2D>("image2Texture"); // Assign to image2 the texture called "image2Texture" from the Contentipeline.

            Console.WriteLine("Content loaded");
        }

        protected override void UnloadContent()
        {
            Console.WriteLine("Content unloaded");
        }

        protected override void Update(GameTime gameTime)
        {
            //Add your update code here.
            if (InputWrapper.Buttons.Left == ButtonState.Pressed) // Now we can use the custom inputs.
                positionImage1.X--;
            if (InputWrapper.Buttons.Right == ButtonState.Pressed)
                positionImage1.X++;
            if (InputWrapper.Buttons.Up == ButtonState.Pressed)
                positionImage1.Y--;
            if (InputWrapper.Buttons.Down == ButtonState.Pressed)
                positionImage1.Y++;


            if (Mouse.GetState().LeftButton == ButtonState.Pressed) // If we press the "LeftClick" button of the mouse, move the image1 to the mouse position.
                positionImage1 = new Vector2(Mouse.GetState().Position.X, Mouse.GetState().Position.Y);

            if (Mouse.GetState().RightButton == ButtonState.Pressed) // If we press the "RightClick" button of the mouse, move the image2 to the mouse position.
                positionImage2 = new Vector2(Mouse.GetState().Position.X, Mouse.GetState().Position.Y);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Add your Draw code here.
            spriteBatch.Begin(); // Initialize drawing.

            spriteBatch.Draw(image1, positionImage1, Color.White); // Draw the image1.
            spriteBatch.Draw(image2, positionImage2, Color.White); // Draw the image2.

            spriteBatch.End(); // We are done drawing.

            base.Draw(gameTime);
        }
    }
}
