using SpaceInvaders.Enums;
using SpaceInvaders.HelperClasses;

namespace SpaceInvaders.Units
{
    public class PlayerUnit : BaseUnit
    {
        public List<PlayerLaser> Lasers { get; set; }
        public PlayerUnit(int x, int y, int health) : base(x, y, health)
        {    
            this.Lasers = new List<PlayerLaser>();
        }

        public override void DrawUnit()
        {
            Console.SetCursorPosition(this.Cordinates.X-1, this.Cordinates.Y);
            Console.Write("x^x");
        }

        public void Move(PLayerInput movementEnum, Canvas canvas) 
        { 
            if (movementEnum == PLayerInput.Left && this.Cordinates.X > 2)
            {
                this.Cordinates.X--;
            }
            else if (movementEnum == PLayerInput.Right && this.Cordinates.X < canvas.Width - 1)
            {
                this.Cordinates.X++;
            }
        }

        public void Shoot()
        {
            Lasers.Add(new PlayerLaser(this.Cordinates.X, this.Cordinates.Y - 1, 1, 1));
        }

        public void HandleLasers(Canvas canvas)
        {
            foreach (var laser in Lasers)
            {
                if (laser.Cordinates.Y >= 1) 
                {
                    laser.DrawUnit('|');
                    laser.LaserMove();
                }
            }
        }
    }
}
