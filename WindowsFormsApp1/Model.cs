using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student1_csharp.Model
{
    public enum AreaType
    {
        Rectangle,
        Trapezoid
    }
    
    public class SingleCount
    {
        public double FUNX2(double x) => x * x;
        public double FUNX3(double x) => x * x * x;
        public double FUNCOSX(double x) => Math.Cos(x);
        public double TrapezoidMethod(Func<double, double> fun)
        {
            double result = 0;
            double dx = (this.X2 - this.X1) / this.N;
            for (int i = 1; i < N; i++) 
                result += fun(this.X1 + i * dx);
            result = (result + (fun(this.X1) + fun(this.X2)) / 2) * dx;
            return result;

        }
        public double RectangleMethod(Func<double, double> fun)
        {
            double result = 0;
            double dx = (this.X2 - this.X1) / this.N;
            for (int i = 1; i < N; i++)
                result += fun(this.X1 + i * dx);
            result *= dx;
            return result;
        }

        public double X1 { get; set; }
        public double X2 { get; set; }
        public int N { get; set; }
        public AreaType AreaType { get; set; }
        public double Area { get; set; }
        public int CalculationNumber { get; set; }
        public int LowestN { get; set; }
        public double MinSquareError { get; set; }
        public SingleCount() { }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.N = n;
            this.AreaType = areaType;
            this.Area = area;
            this.CalculationNumber = calcNumber;
        }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber, int lowestN)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.N = n;
            this.AreaType = areaType;
            this.Area = area;
            this.CalculationNumber = calcNumber;
            this.LowestN = lowestN;

        }
    }

    public class Global
    {
        public List<SingleCount> ListOfSingleCount { get; set; }
        public Global() { }
        public Global(List<SingleCount> list)
        {
            this.ListOfSingleCount = list;
        }
    }
}
