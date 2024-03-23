using SpaceInvaders;
using SpaceInvaders.Enums;
using SpaceInvaders.Units;

bool isRunning = true;
var canvas = new Canvas(50, 25);
var player = new PlayerUnit(canvas.Width/2, canvas.Height - 2 , 3);
Console.CursorVisible = false;

Console.SetBufferSize(150, 150);
while (isRunning)
{
    Thread.Sleep(5);
    canvas.DrawCanvas();
    player.DrawUnit();
    player.HandleLasers(canvas);

    var input = ConsoleKey.O;

    if (Console.KeyAvailable == true)
    {
        input = Console.ReadKey(true).Key;
    }
    if (input == ConsoleKey.A)
        player.Move(PLayerInput.Left, canvas);
    else if (input == ConsoleKey.D)
        player.Move(PLayerInput.Right, canvas);
    else if (input == ConsoleKey.W)
        player.Shoot();
}