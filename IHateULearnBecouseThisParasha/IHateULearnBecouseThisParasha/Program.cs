using System;

namespace Names
{
    internal static class HeatmapTask
    {
        private static string[] ArrayCount(int s, int p, string[] a)
        {
            /*for (int i = 0; i < s; i++)
                a[i] = (i + p).ToString();*/
            int i =0;
            while (true)
            {
                a[i] = (i+p).ToString();
            }

            return a;
        }

        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {

            string[] month = new string[12];
            string[] day = new string[30];
            double[,] birthCount = new double[30, 12];

            ArrayCount(30, 2, day);
            ArrayCount(12, 1, month);

            foreach (var guy in names)
                if (guy.BirthDate.Day != 1)
                    birthCount[guy.BirthDate.Day - 2, guy.BirthDate.Month - 1]++;

            return new HeatmapData(
            "Тепловая карта",
            birthCount,
            day,
            month);
        }
    }
}