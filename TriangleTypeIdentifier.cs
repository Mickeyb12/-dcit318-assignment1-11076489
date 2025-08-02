namespace TriangleTypeIdentifier
{
    public class TriangleTypeIdentifier
    {
        public string IdentifyTriangleType(double side1, double side2, double side3)
        {
            if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side2 + side3 <= side1))
                return "Invalid triangle. The sum of any two sides must be greatere than the third.";

            if (side1 == side2 && side2 == side3)
                return "Equilateral triangle";
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                return "Isosceles triangle";
            else
                return "Scalene triangle";
        }
    }
}