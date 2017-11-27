using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommadInterfaces.Exceptions;

namespace CommadInterfaces
{
    public class CommandArray<T1> {
        private Dictionary<string, Command<T1>> Repository;

        public CommandArray() {
            Repository = new Dictionary<string, Command<T1>>();
        }

        public void AddCommand(Action<Command<T1>> commad_config) {
            Command<T1> for_add = new Command<T1>();
            commad_config.Invoke(for_add);
			Data curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, T1 arguments) {
            Command<T1> exe;
            try {
                exe = Repository[name];
            }
            catch (Exception err) {
                throw new CommandNotFound(name);
            }
            exe.OnExecute(arguments);
        }
    }

    public class CommandArray<T1,T2>
    {
        private Dictionary<string, Command<T1, T2>> Repository;

        public CommandArray()
        {
            Repository = new Dictionary<string, Command<T1, T2>>();
        }

        public void AddCommand(Action<Command<T1, T2>> commad_config)
        {
            Command<T1, T2> for_add = new Command<T1, T2>();
            commad_config.Invoke(for_add);
            Data curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, T1 argument_01, T2 argument_02)
        {
            Command<T1,T2> exe;
            try
            {
                exe = Repository[name];
            }
            catch (Exception err)
            {
                throw new CommandNotFound(name);
            }
            exe.OnExecute(argument_01, argument_02);
        }
    }

    public class CommandArray<T1, T2, T3>
    {
        private Dictionary<string, Command<T1, T2, T3>> Repository;

        public CommandArray()
        {
            Repository = new Dictionary<string, Command<T1, T2, T3>>();
        }

        public void AddCommand(Action<Command<T1, T2, T3>> commad_config)
        {
            Command<T1, T2, T3> for_add = new Command<T1, T2, T3>();
            commad_config.Invoke(for_add);
            Data curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, T1 argument_01, T2 argument_02, T3 argument_03)
        {
            Command<T1, T2, T3> exe;
            try
            {
                exe = Repository[name];
            }
            catch (Exception err)
            {
                throw new CommandNotFound(name);
            }
            exe.OnExecute(argument_01, argument_02, argument_03);
        }
    }

    public class CommandArray<T1, T2, T3, T4>
    {
        private Dictionary<string, Command<T1, T2, T3, T4>> Repository;

        public CommandArray()
        {
            Repository = new Dictionary<string, Command<T1, T2, T3, T4>>();
        }

        public void AddCommand(Action<Command<T1, T2, T3, T4>> commad_config)
        {
            Command<T1, T2, T3, T4> for_add = new Command<T1, T2, T3, T4>();
            commad_config.Invoke(for_add);
            Data curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, T1 argument_01, T2 argument_02, T3 argument_03, T4 argument_04)
        {
            Command<T1, T2, T3, T4> exe;
            try
            {
                exe = Repository[name];
            }
            catch (Exception err)
            {
                throw new CommandNotFound(name);
            }
            exe.OnExecute(argument_01, argument_02, argument_03, argument_04);
        }
    }

    public class CommandArray<T1, T2, T3, T4, T5>
    {
        private Dictionary<string, Command<T1, T2, T3, T4, T5>> Repository;

        public CommandArray()
        {
            Repository = new Dictionary<string, Command<T1, T2, T3, T4, T5>>();
        }

        public void AddCommand(Action<Command<T1, T2, T3, T4, T5>> commad_config)
        {
            Command<T1, T2, T3, T4, T5> for_add = new Command<T1, T2, T3, T4, T5>();
            commad_config.Invoke(for_add);
            Data curr_data = for_add.MyData.Invoke();
            for_add.MyData = () => curr_data;
            Repository.Add(for_add.Name.Invoke(), for_add);
        }

        public void Execute(string name, T1 argument_01, T2 argument_02, T3 argument_03, T4 argument_04, T5 argument_05)
        {
            Command<T1, T2, T3, T4, T5> exe;
            try
            {
                exe = Repository[name];
            }
            catch (Exception err)
            {
                throw new CommandNotFound(name);
            }
            exe.OnExecute(argument_01, argument_02, argument_03, argument_04, argument_05);
        }
    }
}
