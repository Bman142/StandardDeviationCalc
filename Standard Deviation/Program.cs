using System;

class Program
{
    static int Main()
    {
        data data = GetBellCurve(1, 10);

        Console.Write("Min: " + data.Min.ToString() + "\n");
        Console.Write("Max: " + data.Max.ToString() + "\n");
        Console.Write("Mean: " + data.Mean.ToString() + "\n");
        Console.Write("Standard Dev.: " + data.StandardDeviation.ToString() + "\n");

        Dictionary<int, float> curveData = new Dictionary<int, float>();

        for (int i = 1; i <= 10; i++) 
        {
            double tmp = (1 / (data.StandardDeviation * (Math.Sqrt(2 * Math.PI)))) * Math.Exp(-0.5 * Math.Pow(((i - data.Mean) / data.StandardDeviation),2));
            curveData.Add(i, (float)tmp);
        }

        foreach(var item in curveData){
            Console.Write("{0},{1}\n", item.Key, item.Value);
        }


        return 0;
    }

    static data GetBellCurve(float min, float max)
    {
        data output = new data();

        output.Min = min;
        output.Max = max;

        output.StandardDeviation = (((max - min) / 2) / 3);
        output.Mean = max - 3 * output.StandardDeviation;

        return output;


    }



    struct data
    {
        public float Mean;
        public float StandardDeviation;
        public float Max;
        public float Min;
    }

}
