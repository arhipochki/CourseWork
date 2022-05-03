using org.mariuszgromada.math.mxparser;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CourseWork
{
    internal class CalculateModule
    {
        private string function = "";
        /// <summary>
        /// Функция, которая будет использована для расчётов
        /// </summary>
        public string Function { set { function = value; MxFunc = new Function($"f(x) = {function}"); } }
        private Function MxFunc; // Функция для преобразования строчной функции в функцию-код, которую можно будет использовать для рассчётов.

        /// <summary>
        /// Функция, для расчёта Function с конкретным X
        /// </summary>
        private double CalculateFunction(double x)
        {
            // Заменяем запятую на точку при форматировании в строку (т.е. для ру-региона это 1,23 , а для запада это 1.23) 
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            // Получаем выражение с подставленным X
            Expression MxExpression = new Expression($"f({x})", MxFunc);

            return MxExpression.calculate();
        }

        /// <summary>
        /// Функция решения методом Ньютона (Секущих)
        /// </summary>
        /// <param name="X0">Первые две точки</param>
        /// <param name="eps">Точность</param>
        /// <param name="chart">Ссылка на диаграмму</param>
        /// <param name="series">Ссылка на серию данных, в которую будут записаны полученные значения</param>
        /// <param name="filesModule">Ссылка на модуль, через который будет произведена запись данных</param>
        public void NewtomMethod(double[] X0, double eps, Chart chart, Series series, FilesModule filesModule)
        {   
            double x0 = X0[0];
            double x1 = X0[1];
            
            double ansX = Math.Round(x1 - CalculateFunction(x1) / (CalculateFunction(x1) - CalculateFunction(x0)) * (x1 - x0), 6);

            filesModule.SaveInitialData($"{function}, {eps}");
            filesModule.SaveInitialData($"x0: {x0} {CalculateFunction(x0)}");
            filesModule.SaveInitialData($"x1: {x1} {CalculateFunction(x1)}");

            filesModule.SaveToTmp($"ansX: {ansX}, {CalculateFunction(ansX)}");

            series.Points.AddXY(x0, CalculateFunction(x0));
            series.Points.AddXY(x1, CalculateFunction(x1));
            series.Points.AddXY(ansX, CalculateFunction(ansX));

            // Метод Секущих
            while (Math.Abs(ansX - x1) > eps)
            {
                x0 = x1;
                x1 = ansX;
                ansX = Math.Round(x1 - CalculateFunction(x1) / (CalculateFunction(x1) - CalculateFunction(x0)) * (x1 - x0), 6);

                filesModule.SaveToTmp($"x0: {x0}, {CalculateFunction(x0)}");
                filesModule.SaveToTmp($"x1: {x1}, {CalculateFunction(x1)}");
                filesModule.SaveToTmp($"ansX: {ansX}, {CalculateFunction(ansX)}");

                series.Points.AddXY(ansX, CalculateFunction(ansX));
            }
            filesModule.SaveInitialData($"ans: {ansX}, {CalculateFunction(ansX)}");
            
            try
            {
                chart.Series.Add(series);
            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show("Ошибка: набор данных с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
