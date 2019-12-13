using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapeau_Model
{

        public class TableTop //made by Machelle
        {

            int TableId;
            int Seats;
            TableStatus tableStatus;

            public TableTop()
            {
                //an empty constructor is nessecary to use an empty object (NULL)
            }

            public TableTop(int id, int seats, TableStatus status)
            {
                TableId = id;
                Seats = seats;
                tableStatus = status;
            }

            public int GetSeats()
            {
                return Seats;
            }

            public TableStatus GetTableStatus()
            {
                return tableStatus;
            }

            public int GetTableId()
            {
                return TableId;
            }
        }

}
