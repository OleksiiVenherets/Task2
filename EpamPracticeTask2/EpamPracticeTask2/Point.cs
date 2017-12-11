namespace EpamPracticeTask2
{
    public class Point
    {
        /// <summary>
        /// Property for X coordinate
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Propery for Y coordinate
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Constructor for creating new instance of point
        /// </summary>
        /// <param name="x">coodinate x</param>
        /// <param name="y">coordinate y</param>
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Method that represents instance of class to string
        /// </summary>
        /// <returns>string that represents instance of class</returns>
        public override string ToString()
        {
            return " {" + X + ", " + Y + "}";
        }
    }
}