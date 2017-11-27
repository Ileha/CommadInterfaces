using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadInterfaces.Exceptions
{
    public class CommandNotFound : Exception {
        private string Message;

        public CommandNotFound(string comand_name) : base("comand " + comand_name + " was not found") {
            Message = "comand " + comand_name + " was not found";
        }

        public override string ToString() {
            return Message;
        }
    }
}
