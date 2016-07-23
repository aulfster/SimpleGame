using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        public int HitPoints { get; private set; }
        public bool Dead
        {
            get
            {
                if (HitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, int hitPoints)
              : base(game, location) { HitPoints = hitPoints; }
        public abstract void Move(Random random);
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance));
        }
        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }

    class Bat : Enemy
    {
        public Bat(Game game, Point location)
            : base(game, location, 6)
        { }
        public override void Move(Random random)
        {
            // Your code will go here

            if(this.HitPoints >= 1)
            {
                Direction t = Direction.Down;
                Random r = new Random();

                double n = r.NextDouble();

                if (n <= 0.5)
                {
                    t = this.FindPlayerDirection(game.PlayerLocation);
                }
                else
                {
                    int u = r.Next(0, 3);
                    t = (Direction)u;
                }
                base.Move(t, game.Boundaries);
            }

            if(NearPlayer() == true)
            {
                this.Hit(2, random);
            }
        }
    }

    class Ghost : Enemy
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8)
        { }
        public override void Move(Random random)
        {
            // Your code will go here

            if (this.HitPoints >= 1)
            {
                Direction t = Direction.Down;
                Random r = new Random();

                double n = r.NextDouble();

                if (n <= 0.33)
                {
                    t = this.FindPlayerDirection(game.PlayerLocation);
                    base.Move(t, game.Boundaries);
                }
            }

            if (NearPlayer() == true)
            {
                this.Hit(3, random);
            }
        }
    }

    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10)
        { }
        public override void Move(Random random)
        {
            // Your code will go here
            if (this.HitPoints >= 1)
            {
                Direction t = Direction.Down;
                Random r = new Random();

                double n = r.NextDouble();

                if (n <= 0.66)
                {
                    t = this.FindPlayerDirection(game.PlayerLocation);
                    base.Move(t, game.Boundaries);
                }
            }

            if (NearPlayer() == true)
            {
                this.Hit(4, random);
            }

        }
    }
}
