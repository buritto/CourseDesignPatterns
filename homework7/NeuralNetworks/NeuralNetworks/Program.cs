using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuralNetworks
{
    public interface INeural<T>
    {
        T Calculate();
    }

    public interface ISinapse<T>
    {
        INeural<T> Previous { get; set; }
        INeural<T> Next { get; set; }

        T Weight { get; set; }
    }

    public class Sinapse : ISinapse<double>
    {
        public INeural<double> Previous { get; set; }
        public INeural<double> Next { get; set; }
        public double Weight { get; set; }
    }

    public class Neural : INeural<double>
    {
        private List<ISinapse<double>> relationship;
        private Func<double, double, double> NeuralCalculator;

        public Neural(List<ISinapse<double>> relationship, Func<double, double, double> neuralCalculator)
        {
            this.relationship = relationship;
            NeuralCalculator = neuralCalculator;
        }


        public double Calculate()
        {
            if (relationship.Count == 0)
                return NeuralCalculator(0, 0);

            double result = 0;
            foreach (var sinapse in relationship)
            {
                var res = sinapse.Previous.Calculate() * sinapse.Weight;
                result = NeuralCalculator(res, result);
            }

            var a = InvokeSigmoid(result);

            return a;
            return result;
        }

        private double InvokeSigmoid(double valie)
        {
            return 1 / (1 + Math.Pow(Math.E, -1 * valie));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var input1 = new Neural(new List<ISinapse<double>>(), (x, y) => 0);
            var input2 = new Neural(new List<ISinapse<double>>(), (x, y) => 1);

            var i1ToH1 = new Sinapse();
            var i2ToH1 = new Sinapse();

            Func<double, double, double> sum = (x, y) => x + y;

            var h1 = new Neural(new List<ISinapse<double>>() {i1ToH1, i2ToH1}, sum);

            i1ToH1.Next = h1;
            i2ToH1.Next = h1;
            i1ToH1.Weight = 0.45;
            i2ToH1.Weight = -0.12;
            i1ToH1.Previous = input1;
            i2ToH1.Previous = input2;


            var i1ToH2 = new Sinapse();
            var i2ToH2 = new Sinapse();


            var h2 = new Neural(new List<ISinapse<double>>() {i1ToH2, i2ToH2}, sum);

            i1ToH2.Next = h2;
            i2ToH2.Next = h2;
            i1ToH2.Weight = 0.78;
            i2ToH2.Weight = 0.13;
            i1ToH2.Previous = input1;
            i2ToH2.Previous = input2;


            var h1ToO1 = new Sinapse();
            var h2ToO1 = new Sinapse();


            var o1 = new Neural(new List<ISinapse<double>> {h1ToO1, h2ToO1}, sum);

            h1ToO1.Previous = h1;
            h1ToO1.Weight = 1.5;
            h2ToO1.Previous = h2;
            h2ToO1.Weight = -2.3;
            h1ToO1.Next = o1;
            h2ToO1.Next = o1;

            var res = o1.Calculate();
            var error = GetError(res, 1);

            Console.WriteLine($"result = {res} error = {error}");
        }

        private static double GetError(double value, double expected)
        {
            return Math.Pow(expected - value, 2);
        }
    }
}