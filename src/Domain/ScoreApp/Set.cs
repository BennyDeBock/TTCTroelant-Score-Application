using System;
namespace Domain.ScoreApp
{
    public class Set
    {
        private Point point1;
        private Point point2;


        public Set(uint point1, uint point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public bool ValidateSet()
        {
            // Check that at least one of the points is 11 or higher
            if (point1 > 11 || point2 > 11)
            {
                // Score is higher than 11, check if there is a 2 point difference
                if (point1 - point2 == 2 || point2 - point1 == 2)
                {
                    return true;
                }

                return false;
            }
            else if (point1 == 11 ^ point2 == 11)
            {
                if (point1 - point2 >= 2 || point2 - point1 >= 2)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
