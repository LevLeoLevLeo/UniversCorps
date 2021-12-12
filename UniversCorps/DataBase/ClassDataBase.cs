using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversCorps.DataBase
{
    class ClassDataBase
    {

        public static UniversClassFundEntities UniversClassFundEntities; //Сущность базы данных

        /// <summary>
        /// Выбранный корпус
        /// </summary>
        public static Corps CurrentCorpus;

        /// <summary>
        /// Выбранная комната
        /// </summary>
        public static UniClassFundCorps CurrentRoom; //Выбранное помещение

    }
}
