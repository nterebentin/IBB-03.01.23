using System.Collections;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    class DataTable: IEnumerable<DataRow>, IEnumerator<DataRow>
    {

        public int ColumnsCount { get; set; }

        List<DataRow> rows = new List<DataRow>();

        public DataRow Current => rows[index];

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<DataRow> GetEnumerator()
        {
            return this;
        }

        int index = -1;
        public bool MoveNext()
        {
            if (index< rows.Count - 1)
            {
                index++;
                return true;
            }
            else
            { return false; }
        }

        public void Reset()
        {
            index=-1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class DataRow :IEnumerable, IEnumerator
    {

        List<object> values;
        public DataRow(int colCount)
        {
            values = new List<object>(colCount);
        }
      
        public void AddValue(int columnIndex, object o)
        {
            values[columnIndex] = o;
        }
        public object this[int i]
        {
            get { return values[i]; }
        }

       
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        int index = -1;
        public bool MoveNext()
        {
            if(index < values.Count - 1)
            {
                index++;
                return true;
            }
            else { return false; }  
        }
        

        public void Reset()
        {
            index = -1;
        }
        public object Current => values[index];
}
    }
    
