using System;

namespace EpamPracticeTask2
{
    /// <summary>
    /// Class for Rectangle
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Property for peak of rectangle
        /// </summary>
        public Point Point { get; set; }
        /// <summary>
        /// Property for heigth
        /// </summary>
        public int Height { get; }
        /// <summary>
        /// property for width
        /// </summary>
        public int Width { get; }
        /// <summary>
        /// Constructor for creating new instance of Rectangle
        /// </summary>
        /// <param name="point">peak of rectangle</param>
        /// <param name="heigth">Heigth of rectangle</param>
        /// <param name="width">width of rectangle</param>
        public Rectangle(Point point, int width, int heigth)
        {

            if (heigth < 0 || width < 0)
                throw new ArgumentException();
            Point = point;
            Height = heigth;
            Width = width;
        }
        /// <summary>
        /// Method for changing size of rectangle
        /// </summary>
        /// <param name="addwidth">Change width</param>
        /// <param name="addheight">Change height</param>
        /// <returns>new rectangle with changing coordinates</returns>
        public Rectangle ChangeSize(int addwidth, int addheight)
        {
            return new Rectangle(Point, Height + addheight, Width + addwidth);
        }
        /// <summary>
        /// Methods for movving rectangle
        /// </summary>
        /// <param name="moveX">move for acis X</param>
        /// <param name="moveY">move for acis Y</param>
        /// <returns>return new rectangle with movving coordinates</returns>
        public Rectangle Move(int moveX, int moveY)
        {
            return  new Rectangle(new Point(Point.X + moveX, Point.Y + moveY), Height, Width );
        }
        /// <summary>
        /// Method for finding peaks od rectangle
        /// </summary>
        /// <returns>Array of peaksof rectangle</returns>
        public Point[] GetPoints()
        {
            var points = new Point[4];
            points[0] = Point;
            points[2] = new Point(Point.X + Width, Point.Y +Height);
            points[1] = new Point(points[0].X, points[2].Y);
            points[3] = new Point(points[2].X, points[0].Y);
            return points;
        }
        /// <summary>
        /// Method that represents instance of class to string
        /// </summary>
        /// <returns>string that represents instance of class</returns>
        public override string ToString()
        {
            var points = GetPoints();
            return
                $"The coordinates of rectangle are:\t{points[0].ToString()}\t{points[1].ToString()}\t{points[2].ToString()}\t{points[3].ToString()}";
        }
    }
}