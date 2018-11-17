using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GeonBit.UI;

namespace Dragon_For_Honor
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    /// 


    public class Game1 : Game
    {
        public static bool kilep = false;
        public static int x = 800;
        public static int y = 600;
        public static int kijelolt_felbontas = 0;
        public static bool ment = false;
        public static bool full_screen = true;

        public void Kilepes()
        {
            kilep = true;
        }
        public void Kilep()
        {
            this.Exit();
        }

        public void Kepernyo_Felbontas()
        {
             
            graphics.PreferredBackBufferHeight = y;
            graphics.PreferredBackBufferWidth = x;

            graphics.IsFullScreen = full_screen;
            graphics.ApplyChanges();

        }



        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
       // Texture2D Fold_Sprite;
        GUI_Interface IGUI = new GUI_Interface();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferredBackBufferWidth = 1024;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        /// 


        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Kepernyo_Felbontas();
            UserInterface.Initialize(Content, BuiltinThemes.hd);
            IGUI.GUI_Betolt();
            Menu_Manager.Menu_Valtas(Menu_Manager.Menu.Fo_Menu);
             
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {


            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // Fold_Sprite = Content.Load<Texture2D>("1");

            // TODO: use this.Content to load your game content here

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            UserInterface.Active.Update(gameTime);

            // TODO: Add your update logic here
            if (kilep == true)
            {
                Kilep();
            }
            base.Update(gameTime);
            if (ment==true)
            {
                Kepernyo_Felbontas();
                ment = false;
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            UserInterface.Active.Draw(spriteBatch);
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
