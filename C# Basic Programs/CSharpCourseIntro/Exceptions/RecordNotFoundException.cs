using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string massage):base(massage)
        {

        }
    }
}
