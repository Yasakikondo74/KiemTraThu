using System.ComponentModel.DataAnnotations;

namespace Class1
{
    public class Function
    {
        public static int Divide(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                throw new DivideByZeroException("Can't be divided by Zero");
            }
            return a / b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public string StudentScore(int studentScore)
        {
            if (studentScore <= -1)
            {
                throw new ArgumentException("Điểm học sinh không thể bé hơn điểm thấp nhất");
            }
            else if (studentScore <= 40)
            {
                return "Xếp loại F (Failure!)";
            }
            else if (studentScore <= 60)
            {
                return "Xếp loại D";
            }
            else if (studentScore <= 70)
            {
                return "Xếp loại C";
            }
            else if (studentScore <= 80)
            {
                return "Xếp loại B";
            }
            else if (studentScore <= 100)
            {
                return "Xếp loại A";
            }
            else
            {
                throw new ArgumentException("Điểm học sinh không thể hơn 100");
            }
        }
    }
}
