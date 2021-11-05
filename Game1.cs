using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lesson_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D backgroundTexture;
        Texture2D miceTexture;
        Texture2D johnnyTexture;
        Texture2D angyTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            _graphics.PreferredBackBufferWidth = 1200;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            this.Window.Title = "Creative Freedom";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            miceTexture = Content.Load<Texture2D>("Mice 2");
            johnnyTexture = Content.Load<Texture2D>("Canada");
            backgroundTexture = Content.Load<Texture2D>("Classroom Background");
            angyTexture = Content.Load<Texture2D>("Angry Sign");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkSalmon);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(backgroundTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(miceTexture, new Vector2(800, 200), Color.White);
            _spriteBatch.Draw(johnnyTexture, new Vector2(300, 10), Color.White);
            _spriteBatch.Draw(angyTexture, new Vector2(830, 180), Color.White);
            _spriteBatch.End();



            base.Draw(gameTime);
        }
    }
}
