using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_1
{
    /// <summary>
    /// Класс "Человек"
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string firstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string lastName;

        /// <summary>
        /// Возраст
        /// </summary>
        public int age;
        
        /// <summary>
        /// Метода вывода информации о человеке на консоль
        /// </summary>
        public void Output()
        {
            Console.WriteLine($"Имя: {firstName}\tФамилия: {lastName}\tВозраст: {age}");
        }
    }
}
