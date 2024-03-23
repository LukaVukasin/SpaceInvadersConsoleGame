namespace SpaceInvaders.HelperClasses
{
    public class PlayerLaser : LaserBase
    {
        public PlayerLaser(int x, int y, int damage, int updateTurn) : base(x, y, damage, updateTurn) 
        {         
        }

        public override void LaserMove()
        {
            this.Cordinates.Y--;
        }
    }
}
