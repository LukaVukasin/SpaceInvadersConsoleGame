using SpaceInvaders.HelperClasses;

namespace SpaceInvaders.Units
{
    public abstract class BaseUnit
    {
        public Cordinates Cordinates { get; set; }
        public int Health { get; set; }

        public BaseUnit(int x, int y, int health)
        {
            this.Cordinates = new Cordinates(x, y);
            this.Health = health;
        }

        public abstract void DrawUnit();
    }
}
