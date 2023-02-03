using Quête_de_Dragon;

namespace Project_CSharp
{
    internal class Program
    {
        //set
        public static int winWidth = 110;
        public static int winHeight = 35;
        static void Main(string[] args)
        {
            Console.SetWindowSize(winWidth, winHeight);
            Console.CursorVisible = false;
            Game game= new Game();
            game.PlayGame();
        }
    }
}