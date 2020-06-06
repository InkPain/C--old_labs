using System;
using System.Collections.Generic;
using System.Text;

namespace InkPain.Planner.Consol
{
    /// <summary>
    /// Запись в ежедневник
    /// </summary>
    struct PlannerRecord
    {
        #region поля

        /// <summary>
        /// поле ID
        /// </summary>
        private int id;
        /// <summary>
        /// поле дата
        /// </summary>
        private DateTime dateCreate;
        /// <summary>
        /// поле страна
        /// </summary>
        private string land;
        /// <summary>
        /// поле ip
        /// </summary>
        private string ip;
        /// <summary>
        /// поле порт
        /// </summary>
        private string port;
        /// <summary>
        /// поле использование
        /// </summary>
        private bool checkBox;

        #endregion

        #region Свойства

        /// <summary>
        /// ID Записи
        /// </summary>
        public int Id { get { return this.id; } set { this.id = value; } }

        /// <summary>
        /// Дата создания записи
        /// </summary>
        public DateTime DateCreate { get { return this.dateCreate; } set { this.dateCreate = value; } }

        /// <summary>
        /// Страна прокси
        /// </summary>
        public string Land { get { return this.land; } set { this.land = value; } }

        /// <summary>
        /// Ip прокси
        /// </summary>
        public string Ip { get { return this.ip; } set { this.ip = value; } }

        /// <summary>
        /// Порт прокси
        /// </summary>
        public string Port { get { return this.port; } set { this.port = value; } }

        /// <summary>
        /// Значение указывающие на то использовалась ли прокси
        /// </summary>
        public bool CheckBox { get { return this.checkBox; } set { this.checkBox = value; } }

        #endregion

        #region Конструкторы

        /// <summary>
        /// Конструктор создание записи
        /// </summary>
        /// <param name="Id">Id записи</param>
        /// <param name="DateCreate">Дата создания записи</param>
        /// <param name="Land">Страна прокси</param>
        /// <param name="Ip">Ip прокси</param>
        /// <param name="Port">порт прокси</param>
        /// <param name="CheckBox">была ли использована</param>
        public PlannerRecord(int Id, DateTime DateCreate, string Land, string Ip, string Port, int CheckBox)
        {
            
            this.id = Id;
            this.dateCreate = DateCreate;
            this.land = Land;
            this.ip = Ip;
            this.port = Port;
            if (CheckBox < 1)
            {
                this.checkBox = false;
            }
            else
            {
                this.checkBox = true;
            }
        }

        public PlannerRecord(int Id, DateTime DateCreate, string Land, string Ip, string Port) :
            this(Id, DateCreate, Land, Ip, Port, 0)
        {

        }

        public PlannerRecord(int Id, DateTime DateCreate, string Land, string Ip) :
            this(Id, DateCreate, Land, Ip, "null", 0)
        {

        }

        public PlannerRecord(int Id, DateTime DateCreate, string Land) :
            this(Id, DateCreate, Land, "null", "null", 0)
        {

        }

        public PlannerRecord(int Id, DateTime DateCreate) :
            this(Id, DateCreate, "null", "null", "null", 0)
        {

        }

        public PlannerRecord(int Id) :
            this(Id, new DateTime(0,0,0,0,0,0), "null", "null", "null", 0)
        {

        }

        #endregion

        #region Методы

        /// <summary>
        /// Метод позволяющий вывести запись ежедневника на экран
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return $"{this.Id,4}" +
                $"{this.DateCreate,23:dd.MM.yyyy}" +
                $"{this.Land,20}" +
                $"{this.Ip,23}" +
                $"{this.Port,11}" +
                $"{this.CheckBox,18}";
        }

        #endregion    

    }
}
