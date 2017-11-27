using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommadInterfaces {
    public class Command<T1> {
        public Func<string> Name;
        public Action<T1> Execute;
		public Func<Data> MyData;

        public void OnExecute(T1 _data_01)
        {
            Execute(_data_01);
        }
    }

    public class Command<T1, T2>
    {
        public Func<string> Name;
        public Action<T1, T2> Execute;
        public Func<Data> MyData;

        public void OnExecute(T1 _data_01, T2 _data_02)
        {
            Execute(_data_01, _data_02);
        }
    }

    public class Command<T1, T2, T3>
    {
        public Func<string> Name;
        public Action<T1, T2, T3> Execute;
        public Func<Data> MyData;

        public void OnExecute(T1 _data_01, T2 _data_02, T3 _data_03)
        {
            Execute(_data_01, _data_02, _data_03);
        }
    }

    public class Command<T1, T2, T3, T4> {
        public Func<string> Name;
        public Action<T1, T2, T3, T4> Execute;
        public Func<Data> MyData;

        public void OnExecute(T1 _data_01, T2 _data_02, T3 _data_03, T4 _data_04)
        {
            Execute(_data_01, _data_02, _data_03, _data_04);
        }
    }

    public class Command<T1, T2, T3, T4, T5> {
        public Func<string> Name;
        public Action<T1, T2, T3, T4, T5> Execute;
        public Func<Data> MyData;

        public void OnExecute(T1 _data_01, T2 _data_02, T3 _data_03, T4 _data_04, T5 _data_05)
        {
            Execute(_data_01, _data_02, _data_03, _data_04, _data_05);
        }
    }
}
