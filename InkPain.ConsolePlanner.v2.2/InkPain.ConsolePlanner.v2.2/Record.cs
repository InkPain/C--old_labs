using System;
using System.Collections.Generic;
using System.Text;

namespace InkPain.ConsolePlanner.v2._2
{
    struct Record
    {


        #region поля

        /// <summary>
        /// ID
        /// </summary>
        private int id;


        /// <summary>
        /// Страна прокси
        /// </summary>
        private string land;

        /// <summary>
        /// IP прокси
        /// </summary>
        private string ip;

        /// <summary>
        /// порт прокси
        /// </summary>
        private string port;

        /// <summary>
        /// пометки
        /// </summary>
        //private string notes;
        private DateTime date;




        #endregion

        #region свойства

        /// <summary>
        /// Id записи
        /// </summary>
        public int Id { get { return this.id; } set { this.id = value; } }



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
        /// Заметки
        /// </summary>
        //public string Notes { get { return this.notes; } set { this.notes = value; } }
        public DateTime Date { get { return this.date; } set { this.date = value; } }

        #endregion

        #region конструкторы

        /// <summary>
        /// Создание записи
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="DaterCreate"></param>
        /// <param name="Land"></param>
        /// <param name="Ip"></param>
        /// <param name="Port"></param>
        /// <param name="Notes"></param>
        public Record(int Id, DateTime Date, string Land, string Ip, string Port)
        {
            this.id = Id;
            this.date = Date;
            this.land = Land;
            this.ip = Ip;
            this.port = Port;
            //this.notes = Notes;
            
        }

        public Record(int Id, DateTime Date, string Land, string Ip):
            this(Id, Date, Land, Ip, "NULL")
        {

        }
        public Record(int Id, DateTime Date, string Land) :
            this(Id, Date, Land, "NULL", "NULL")
        {

        }
        public Record(int Id, DateTime Date) :
            this(Id, Date, "NULL", "NULL", "NULL")
        {

        }
        #endregion

        #region методы

        public string Print()
        {
            return $"{this.Id,4} " +
                   $"{this.Date,23:dd.MM.yyyy} " +
                   $"{this.Land,18} " +
                   $"{this.Ip,25} " +
                   $"{this.Port,7}";
        }

        #endregion


    }
}
