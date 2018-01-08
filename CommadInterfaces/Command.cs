using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadInterfaces {
	public delegate void DCommand(params object[] arguments);

    public class Command {
        public Func<string> Name;
        public DCommand Execute;
		public Func<object> MyData;
		public Func<int> ArgumentsCount;

        public void OnExecute(params object[] arguments) {
            Execute(arguments);
        }

		public void SetData(object data) {
			MyData = () => data;
		}

		public T GetCommandData<T>() {
			object data = MyData();
			if (data is T) {
				return (T)data;
			}
			else {
				throw new TypeAccessException();
			}
		}
    }
}
