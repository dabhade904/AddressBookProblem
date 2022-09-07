using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDb
{
    public class AddressBookException:Exception
    {

        public enum ExceptionType
        {
            INVALID_DATA,
            INVALID_ROWS,
            INVALID_CONNECTIONS,
            INVALID_FIELDS
        }
        ExceptionType type;
        public AddressBookException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }

    }
}
