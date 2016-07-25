using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Player : Mover
    {
        
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location) : base(game, location)
        {
            HitPoints = 10;
        }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        // The following to functions need to be filled up by me.

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                // see if the weapon is nearby, and possibly pick it up
                if (this.Nearby(game.WeaponInRoom.Location,10) == true)
                {
                    this.inventory.Add(game.WeaponInRoom);

                    game.WeaponInRoom.PickUpWeapon();
                    if (this.equippedWeapon == null)
                    {
                        this.Equip(game.WeaponInRoom.Name);
                    }
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            // Your code goes here

            if(String.IsNullOrEmpty(this.equippedWeapon.Name) == false)
            {
                if(this.equippedWeapon is IPotion == false)
                    this.equippedWeapon.Attack(direction, random);
                else
                {
                    this.equippedWeapon.Attack(direction, random);
                    this.inventory.Remove(this.equippedWeapon);
                }
            }

        }
    }
}
