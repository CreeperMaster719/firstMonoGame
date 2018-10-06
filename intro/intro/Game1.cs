using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace intro
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        ScreenSize screenSize;

        Sprite sprite;
        int xSpeed = 1;
        int ySpeed = 1;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        
        protected override void Initialize()
        {
            screenSize.Width = GraphicsDevice.Viewport.Width;
            screenSize.Height = GraphicsDevice.Viewport.Height;

            base.Initialize();
        }


        protected override void LoadContent()
        {
           
            spriteBatch = new SpriteBatch(GraphicsDevice);
            

            sprite = new Sprite(Content.Load<Texture2D>("ball"), new Vector2(0, 0), Color.White);
       
        }

        protected override void Update(GameTime gameTime)
        {

            sprite.Update(screenSize);
            base.Update(gameTime);
        }

    
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();


            sprite.Draw(spriteBatch);

            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
