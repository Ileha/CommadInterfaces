using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommadInterfaces.Exceptions;

namespace CommadInterfaces
{
    public class CommandArray {
        private Dictionary<string, Command> Repository;

        public CommandArray() {
            Repository = new Dictionary<string, Command>();
        }

        public void AddCommand(Action<Command> commad_config) {
            Command for_add = new Command();
            commad_config.Invoke(for_add);
			object curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, params object[] arguments) {
            Command exe;
            try {
                exe = Repository[name];
            }
            catch (Exception err) {
                throw new CommandNotFound(name);
            }
			if (exe.ArgumentsCount() > arguments.Length) {
				throw new ArgumentCountExeption(exe.ArgumentsCount());
			}
            exe.OnExecute(arguments);
        }
    }
}
