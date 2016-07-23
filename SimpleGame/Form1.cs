﻿using System;
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

        private void Form1_Load(object sender,
                                EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
    
    
        private void UpdateCharacters()
        {
            //throw new NotImplementedException();

            Player.Location = game.PlayerLocation;
        }
    

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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