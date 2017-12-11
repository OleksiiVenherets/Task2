using System;

namespace EpamPracticeTask2
{
    /// <summary>
    /// Class for rectangles oerations
    /// </summary>
    public class RectangleOperations
    {
        /// <summary>
        /// Finding a new rectangles whisc is intersection of two
        /// </summary>
        /// <param name="firstRectangle">first rectangle</param>
        /// <param name="secondRectangle">second rectangle</param>
        /// <returns>return the ne new rectangle which is intersection</returns>
        public Rectangle Intercetion(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle == null || secondRectangle == null)
                throw new ArgumentNullException();
            var firstPoints = firstRectangle.GetPoints();
            var secondPoints = secondRectangle.GetPoints();


            var a1 = Math.Min(firstPoints[3].X, secondPoints[3].X);
            var a2 = Math.Max(firstPoints[0].X, secondPoints[0].X);
            var b1 = Math.Min(firstPoints[0].Y, secondPoints[0].Y);
            var b2 = Math.Min(firstPoints[1].Y, secondPoints[1].Y);

            return new Rectangle(new Point(a2, b1),  b2 - b1, a1 - a2);
        }
        /// <summary>
        /// Methods for finding rectangle that contains two rectangles
        /// </summary>
        /// <param name="firstRectangle">first rectangle</param>
        /// <param name="secondRectangle">second rectangle</param>
        /// <returns>new rectangle which has two rectangles</returns>
        public Rectangle HasTwoRectangle(Rectangle firstRectangle, Rectangle secondRectangle)
        {
            if (firstRectangle == null || secondRectangle == null)
                throw new ArgumentNullException();
            var firstPoints = firstRectangle.GetPoints();
            var secondPoints = secondRectangle.GetPoints();
            int a1 = firstPoints[0].X < secondPoints[0].X ? firstPoints[0].X : secondPoints[0].X;
            int b1 = firstPoints[0].Y < secondPoints[0].Y ? firstPoints[0].Y : secondPoints[0].Y;
            int a2 = firstPoints[2].X > secondPoints[2].X ? firstPoints[2].X : secondPoints[2].X;
            int b2 = firstPoints[2].Y > secondPoints[2].Y ? firstPoints[2].Y : secondPoints[2].Y;

            return new Rectangle(new Point(a1, b1),  a2-a1, b2 - b1);

        }
    }
}