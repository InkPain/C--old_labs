using System;
using System.Collections.Generic;
using System.Text;

namespace InkPain.OOP
{
    /// <summary>
    /// Структура, описывающая рабочего.
    /// </summary>
    struct Worker
    {
        /// <summary>
        /// Должность
        /// </summary>
        public string Position;

        /// <summary>
        /// Зарплата
        /// </summary>
        public uint Salary;

        /// <summary>
        /// Имя
        /// </summary>
        public string Firstname;

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Lastname;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth;

        /// <summary>
        /// Вывод данных о сотруднике
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"Должность: {Position} Зарплата: {Salary} Имя: {Firstname} Фамилия: {Lastname} Дата рождения: {DateOfBirth.ToShortDateString()}";
        }

        /// <summary>
        /// Конструктор создает рабочего.
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Salary"></param>
        /// <param name="Firstname"></param>
        /// <param name="Lastname"></param>
        /// <param name="DateOfBirth"></param>
        public Worker(string Position,
                      uint Salary, 
                      string Firstname, 
                      string Lastname, 
                      DateTime DateOfBirth)
        {
            this.Position = Position;
            this.Salary = Salary;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.DateOfBirth = DateOfBirth;
        }

    }
}
