using System;
using System.Text;

namespace Laba11
{
    public static class DemoRunner
    {
        public static string RunDemo()
        {
            var sb = new StringBuilder();

            try
            {
                IFigure[] figures = new IFigure[8];

                figures[0] = new Square(5);
                figures[1] = new Rectangle(4, 6);
                figures[2] = new Parallelogram(5, 7, 45);
                figures[3] = new Rhombus(6, 60);

                for (int i = 0; i < figures.Length / 2; i++)
                {
                    figures[i + figures.Length / 2] = (IFigure)figures[i].Clone();
                }

                sb.AppendLine("Original array:");
                foreach (var fig in figures)
                    sb.AppendLine(fig.ToString());

                Array.Sort(figures);

                sb.AppendLine("\nSorted array by area:");
                foreach (var fig in figures)
                    sb.AppendLine(fig.ToString());

                sb.AppendLine("\nTesting exception cases:");
                try { var invalid = new Parallelogram(-5, 4, 45); }
                catch (Exception ex) { sb.AppendLine($"Parallelogram: {ex.Message}"); }

                try { var invalid = new Rhombus(5, 200); }
                catch (Exception ex) { sb.AppendLine($"Rhombus: {ex.Message}"); }

            }
            catch (Exception ex)
            {
                sb.AppendLine("Error: " + ex.Message);
            }

            return sb.ToString();
        }
    }
}
