using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace intro
{
    public struct ScreenSize
    {
        public int Width;
        public int Height;
    }

    public class Sprite
    {
       public Texture2D image;
        public Vector2 position;
        Color tint;
        int xSpeed = 1;
        int ySpeed = 1;
        public Sprite(Texture2D image, Vector2 position, Color tint)
        {
            this.image = image;
            this.position = position;
            this.tint = tint;
            

        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, tint);
        }
        public void Update(ScreenSize screenSize)
        {
            if (position.X < 0)
            {
                xSpeed = 1;
            }
            if (position.X + image.Width > screenSize.Width)
            {
                xSpeed = -1;
            }
            if (position.Y < 0)
            {
                ySpeed = 1;
            }
            if (position.Y + image.Height > screenSize.Height)
            {
                ySpeed = -1;
            }

            position.X += 5 * xSpeed;
            position.Y += 5 * ySpeed;
        }

    }
}
