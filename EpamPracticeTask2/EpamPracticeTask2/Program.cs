using System;

namespace EpamPracticeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectangle = new Rectangle(new Point(2, 3), 3, 4);
            var secondRectangle = new Rectangle(new Point(1, 1), 3, 2);
            var rectangleOperation = new RectangleOperations();
            Console.WriteLine($"First rectangle:\n{firstRectangle.ToString()}");
            Console.WriteLine($"Second rectangle:\n{secondRectangle.ToString()}");
            //Changing size
            var newfirstRectangle = firstRectangle.ChangeSize(3, -1);
            Console.WriteLine($"Change size of first rectangle:\n{newfirstRectangle.ToString()}");

            //Movving
            var newsecondRectangle = secondRectangle.Move(2, 2);
            Console.WriteLine($"Moving second rectangle:\n{newsecondRectangle.ToString()}");

            //creating new which contains two
            try
            {
                var newbigRectangle = rectangleOperation.HasTwoRectangle(firstRectangle, secondRectangle);
                Console.WriteLine($"Rectangle which contains two rectangles:\n{newbigRectangle.ToString()}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            //intersection
            try
            {
                var newintersectRentangle = rectangleOperation.Intercetion(firstRectangle, secondRectangle);
                Console.WriteLine($"Intersetion :\n{newintersectRentangle.ToString()}");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message + e.Source);
            }

            Console.ReadLine();
        }
    }
}
