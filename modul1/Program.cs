using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul1
{
    // Інтерфейс для тварин
    interface IAnimal
    {
        string GetName();
        double GetRequiredArea();
        double GetRequiredTemperature();
    }

    // Клас для зебр
    class Zebra : IAnimal
    {
        public string GetName()
        {
            return "Зебра";
        }

        public double GetRequiredArea()
        {
            return 15 * 3;
        }

        public double GetRequiredTemperature()
        {
            return 25;
        }
    }

    // Клас для бегемотів
    class Hippo : IAnimal
    {
        public string GetName()
        {
            return "Бегемот";
        }

        public double GetRequiredArea()
        {
            return 6 * 7;
        }

        public double GetRequiredTemperature()
        {
            return 25;
        }
    }

    // Клас для змій
    class Snake : IAnimal
    {
        public string GetName()
        {
            return "Змія";
        }

        public double GetRequiredArea()
        {
            return 3 * 4;
        }

        public double GetRequiredTemperature()
        {
            return 35;
        }
    }
}
