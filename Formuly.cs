using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_Lav
{
    public class Formuly
    {
        /// <summary>
        /// Формула z1 = (cos(α) - cos(β))^2 - (sin(α) - sin(β))^2
        /// </summary>
        /// <param name="a"> Угол α в радианах </param>
        /// <param name="b"> Угол β в радианах </param>
        /// <returns> Результат формулы </returns>
        public static double Form1(double a, double b)
        {
            double a1 = Formuly.ToRad(a);
            double b1 = Formuly.ToRad(b);
            double cosa = Math.Cos(a1);
            double cosb = Math.Cos(b1);
            double sina = Math.Sin(a1);
            double sinb = Math.Sin(b1);
            double braser1 = Math.Pow(cosa - cosb, 2);
            double braser2 = Math.Pow(sina - sinb, 2);
            double z = braser1 - braser2;
            double z1 = Math.Round(z, 3); //округление до 3 знаков после запятой
            return z1;
        }

        /// <summary>
        /// Формула z2 = -4sin^2((α-β)/2) * cos(α + β)
        /// </summary>
        /// <param name="a"> Угол α в радианах </param>
        /// <param name="b"> Угол β в радианах </param>
        /// <returns> Результат формулы </returns>
        public static double Form2(double a, double b)
        {
            double braser1 = Formuly.ToRad((a - b) / 2);
            double sin = Math.Pow(Math.Sin(braser1), 2) * (-4);
            double cos = Math.Cos(Formuly.ToRad(a + b));
            double z = sin * cos;
            double z1 = Math.Round(z, 3); //округление до 3 знаков после запятой
            return z1;
        }

        /// <summary>
        /// Перевод угла из градусов в радианы
        /// </summary>
        /// <param name="angle"> Угол в градусах </param>
        /// <returns> Угол в радианах </returns>
        public static double ToRad(double angle)
        {
            return angle * Math.PI / 180.0;
        }
    }
}
