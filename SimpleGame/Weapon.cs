using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    abstract class Weapon : Mover
    {
        public bool PickedUp { get; private set; }
        public Weapon(Game game, Point location) : base(game, location)
        {
            PickedUp = false;
        }
        public void PickUpWeapon() { PickedUp = true; }
        public abstract string Name { get; }
        public abstract void Attack(Direction direction, Random random);
        protected bool DamageEnemy(Direction direction, int radius,
                                   int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, distance))
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }
    }

    internal class Sword : Weapon
    {
        public Sword(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Sword"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
            if (DamageEnemy(direction, 10, 3, random) == false)
                if (DamageEnemy(direction + 1, 10, 3, random) == false)
                    DamageEnemy(direction - 1, 10, 3, random);
        }
    }

    class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here

            DamageEnemy(direction, 30, 1, random);
        }
    }

    class Mace : Weapon
    {
        public Mace(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Mace"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
            DamageEnemy(0, 30, 1, random);
            DamageEnemy((Direction)1, 30, 1, random);
            DamageEnemy((Direction)2, 30, 1, random);
            DamageEnemy((Direction)3, 30, 1, random);
        }
    }

    class RedPotion : Weapon, IPotion
    {
        public RedPotion(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Red Potion"; } }
        public bool Used { get; set; }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
            game.IncreasePlayerHealth(10, random);
        }
    }

    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Blue Potion"; } }
        public bool Used { get; set; }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
            game.IncreasePlayerHealth(5, random);
        }
    }

    interface IPotion
    {
        bool Used { get; set; }
    }

}
