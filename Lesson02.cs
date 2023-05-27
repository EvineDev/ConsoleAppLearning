namespace ConsoleAppI
{
    public static class Lesson02
    {
        public static void DataClass(string[] args)
        {
            var eple = new EpleDto();

            eple.Weight = 73;

            Console.WriteLine(eple.Weight);
        }

        public static void ServiceClass(string[] args)
        {
            var chess = new Chess();

            //chess.ShowBoard();

            var moverList = new List<string>();

            moverList.Add(chess.ShowMover());
            chess.MakeMove();
            moverList.Add(chess.ShowMover());
            chess.MakeMove();
            moverList.Add(chess.ShowMover());
            chess.MakeMove();
            moverList.Add(chess.ShowMover());

            foreach (var mover in moverList)
            {
                Console.WriteLine(mover);
            }
        }
    }

    public class Chess
    {
        private string activeMover = "White";

        public void ShowBoard()
        {
            Console.WriteLine("XOXOXXOXOX");
        }

        public string ShowMover()
        {
            return activeMover;
        }

        public void MakeMove()
        {
            if (activeMover == "White")
            {
                activeMover = "Black";
            }
            else
            {
                activeMover = "White";
            }
        }
    }

    public class FruitDto
    {
        public FruitDto()
        {
            Banana = new BananaDto();
            Eple = new EpleDto();
        }

        public BananaDto Banana { get; set; }

        public EpleDto Eple { get; set; }
    }

    public class BananaDto
    {
        public int Color { get; set; }

        public int Weight { get; set; }
    }

    public class EpleDto
    {
        public EpleDto()
        {
            Weight = 72;
        }

        public void SetWeight(int weight)
        {
            Weight = weight;
        }

        public int Color { get; set; }

        public int Weight { get; set; }
    }
}
