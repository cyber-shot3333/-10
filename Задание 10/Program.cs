using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
           static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов:");
            int grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд:");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(grad, min, sec);
            angle.Result();
            angle.ToRadians();
            Console.WriteLine("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
    class Angle
    {
        private int grad;
        private int min;
        private int sec;
        #region Свойства
        public int Grad
        {
            set
            {
                if (value >= 0 && value < 360)
                {
                    grad = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return grad;
            }
        }
        public int Min
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Неверно задано значение");
                }
            }
            get
            {
                return sec;
            }
        }
        #endregion
        public Angle(int grad, int min, int sec)
        {
            Grad = grad;
            Min = min;
            Sec = sec;
        }
        public void Result()
        {
            Console.WriteLine("Заданный угол = {0} градусов {1} минут {2} секунд", Grad, Min, Sec);
        }
        public void ToRadians()
        {
            double radian = ((Grad * Math.PI) / 180) + ((Min * Math.PI) / (180 * 60) + ((Sec * Math.PI) / (180 * 3600)));
            Console.WriteLine("Угол в радианах = {0}", radian);
        }
    }
}