namespace SpaceInvaders.HelperClasses
{
    public abstract class LaserBase
    {
        public Cordinates Cordinates { get; set; }
        public int Damage { get; set; }
        public int UpdateTurn { get; set; }

        public LaserBase(int x, int y, int damage, int updateTurn)
        {
            this.Cordinates = new Cordinates(x, y);
            this.Damage = damage;
            UpdateTurn = updateTurn;
        }

        public void DrawUnit(char laserChar)
        {
            Console.SetCursorPosition(this.Cordinates.X, this.Cordinates.Y);
            Console.Write(laserChar);
        }

        public abstract void LaserMove(); 
    }
}
