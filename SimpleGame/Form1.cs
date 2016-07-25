using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game;
        private Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);

            // By this point I should have got the enemies and players drawn.
            UpdateCharacters();
        }


        private void UpdateCharacters()
        {
            //throw new NotImplementedException();

            playerBox.Location = game.PlayerLocation;

            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;

            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                enemy.Move(random);
                if (enemy is Bat)
                {
                    batBox.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghost)
                {
                    ghostBox.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();

                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    ghoulBox.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();

                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (showBat == false)
            {
                batBox.Visible = false;
                batHitPoints.Text = String.Empty;
            }

            if (showGhost == false)
            {
                ghostBox.Visible = false;
                ghostHitPoints.Text = String.Empty;
            }

            if (showGhoul == false)
            {
                ghoulBox.Visible = false;
                ghoulHitPoints.Text = String.Empty;
            }

            swordBox.Visible = false;
            bowBox.Visible = false;
            rBox.Visible = false;
            bBox.Visible = false;
            maceBox.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = swordBox;
                    break;

                case "Bow":
                    weaponControl = bowBox;
                    break;

                case "Mace":
                    weaponControl = maceBox;
                    break;

                case "Red Potion":
                    weaponControl = rBox;
                    break;

                case "Blue Potion":
                    weaponControl = bBox;
                    break;
            }

            if(game.CheckPlayerInventory("Sword"))
            {
                swordPictureBox.Visible = true;
            }

            if (game.CheckPlayerInventory("Bow"))
            {
                bowPictureBox.Visible = true;
            }

            if (game.CheckPlayerInventory("Mace"))
            {
                macePictureBox.Visible = true;
            }

            if (game.CheckPlayerInventory("Red Potion"))
            {
                redPotionPictureBox.Visible = true;
            }

            if (game.CheckPlayerInventory("Blue Potion"))
            {
                bluePotionPictureBox.Visible = true;
            }

            weaponControl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp)
                weaponControl.Visible = false;
            else
                weaponControl.Visible = true;

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }

            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void swordPictureBox_Click(object sender, EventArgs e)
        {
            bool present = game.CheckPlayerInventory("Sword");
            if(present == true)
            {
                game.Equip("Sword");
            }

            swordPictureBox.BorderStyle = BorderStyle.Fixed3D;
            bowPictureBox.BorderStyle = BorderStyle.None;
            macePictureBox.BorderStyle = BorderStyle.None;
            bluePotionPictureBox.BorderStyle = BorderStyle.None;
            redPotionPictureBox.BorderStyle = BorderStyle.None;

        }

        private void bowPictureBox_Click(object sender, EventArgs e)
        {
            bool present = game.CheckPlayerInventory("Bow");
            if (present == true)
            {
                game.Equip("Bow");
            }

            swordPictureBox.BorderStyle = BorderStyle.None;
            bowPictureBox.BorderStyle = BorderStyle.Fixed3D;
            macePictureBox.BorderStyle = BorderStyle.None;
            bluePotionPictureBox.BorderStyle = BorderStyle.None;
            redPotionPictureBox.BorderStyle = BorderStyle.None;
        }

        private void macePictureBox_Click(object sender, EventArgs e)
        {
            bool present = game.CheckPlayerInventory("Mace");
            if (present == true)
            {
                game.Equip("Mace");
            }

            swordPictureBox.BorderStyle = BorderStyle.None;
            bowPictureBox.BorderStyle = BorderStyle.None;
            macePictureBox.BorderStyle = BorderStyle.Fixed3D;
            bluePotionPictureBox.BorderStyle = BorderStyle.None;
            redPotionPictureBox.BorderStyle = BorderStyle.None;
        }

        private void bluePotionPictureBox_Click(object sender, EventArgs e)
        {
            bool present = game.CheckPlayerInventory("Blue Potion");
            if (present == true)
            {
                game.Equip("Blue Potion");
            }

            swordPictureBox.BorderStyle = BorderStyle.None;
            bowPictureBox.BorderStyle = BorderStyle.None;
            macePictureBox.BorderStyle = BorderStyle.None;
            bluePotionPictureBox.BorderStyle = BorderStyle.Fixed3D;
            redPotionPictureBox.BorderStyle = BorderStyle.None;
        }

        private void redPotionPictureBox_Click(object sender, EventArgs e)
        {
            bool present = game.CheckPlayerInventory("Red Potion");
            if (present == true)
            {
                game.Equip("Red Potion");
            }

            swordPictureBox.BorderStyle = BorderStyle.None;
            bowPictureBox.BorderStyle = BorderStyle.None;
            macePictureBox.BorderStyle = BorderStyle.None;
            bluePotionPictureBox.BorderStyle = BorderStyle.None;
            redPotionPictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void upMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void leftMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void rightMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void downMoveButton_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void upAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void leftAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void rightAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void downAttackButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void bPotionPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playerBox_Click(object sender, EventArgs e)
        {

        }
    }

    class Game
    {
        public IEnumerable<Enemy> Enemies { get; private set; }
        public Weapon WeaponInRoom { get; private set; }
        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }
        private int level = 0;
        public int Level { get { return level; } }
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this,
              new Point(boundaries.Left + 10, boundaries.Top + 70));
        }
        public void Move(Direction direction, Random random)
        {
            player.Move(direction);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }
        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }
        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }
        public void Attack(Direction direction, Random random)
        {
            player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
                enemy.Move(random);
        }
        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left +
              random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                  boundaries.Top +
              random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        // Had to fill this method up.
        public void NewLevel(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this, GetRandomLocation(random)),
                    };
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;

                case 2:
                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    if(CheckPlayerInventory("Blue Potion") == false)
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;

                case 3:

                    Enemies = new List<Enemy>()
                    {
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;

                case 4:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                    };
                    if (CheckPlayerInventory("Bow") == false)
                    {
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    }
                    else
                    {
                        if (CheckPlayerInventory("Blue Potion") == false)
                            WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    break;

                case 5:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };

                    if (CheckPlayerInventory("Red Potion") == false)
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));

                    break;

                case 6:

                    Enemies = new List<Enemy>()
                    {
                        new Ghost(this,GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };

                    
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));

                    break;

                case 7:
                    Enemies = new List<Enemy>()
                    {
                        new Bat(this,GetRandomLocation(random)),
                        new Ghost(this, GetRandomLocation(random)),
                        new Ghoul(this, GetRandomLocation(random)),
                    };
                    if (CheckPlayerInventory("Mace") == false)
                    {
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    }
                    else
                    {
                        if (CheckPlayerInventory("Red Potion") == false)
                            WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    break;

                case 8:
                    Application.Exit();
                    break;
            }
        }
    }

    enum Direction
    {
        Left,
        Up,
        Right,
        Down,
    }

}
