using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadInterfaces.Exceptions
{
    public class CommandDisable : Exception
    {
        private string Message;

        public CommandDisable(string comand_name)
        {
            Message = "comand " + comand_name + " was not found";
        }

        public override string ToString() {
            return Message;
        }
    }
}
