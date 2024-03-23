namespace SpaceInvaders
{
    public class Canvas
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Canvas(int width, int height)
        {
            this.Height = height;
            this.Width = width;
        }

        public void DrawCanvas() 
        {
            Console.Clear();
            for (int i = 1; i <= this.Height; i++)
            { 
                string boxLine = "";
                if (i == 1 || i == this.Height)
                {
                    boxLine = "+" + new string('-', this.Width) + "+\n";
                }
                else
                {
                    boxLine = "|" + new string(' ', this.Width) + "|\n";
                }

                Console.Write(boxLine);
            }
        }
    }
}
