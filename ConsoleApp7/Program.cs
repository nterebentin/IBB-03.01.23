using System.Collections;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable tbl = new DataTable();
            tbl.ColumnsCount = 2;
            DataRow r = tbl.CreateRow();
            try
            {
                r.AddValue(300, "Nursen");
            }
            catch (Çüş e)
            {
                Console.WriteLine(e.Message);

            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
        }
    }
    class DataTable : IEnumerable<DataRow>, IEnumerator<DataRow>
    {

        public int ColumnsCount { get; set; }

        public List<DataRow> rows = new List<DataRow>();
        public DataRow CreateRow()
        {
            DataRow r = new DataRow(ColumnsCount);
            rows.Add(r);
            return r;
        }

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
            if (index < rows.Count - 1)
            {
                index++;
                return true;
            }
            else
            { return false; }
        }

        public void Reset()
        {
            index = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class DataRow : IEnumerable, IEnumerator
    {

        List<object> values;
        private int _colCount;
        public DataRow(int colCount)
        {
            _colCount = colCount;
            values = new List<object>(colCount);
        }

        public void AddValue(int columnIndex, object o)
        {
            if (columnIndex > _colCount)
            {
                throw new Çüş("Abartma");
            }
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
            if (index < values.Count - 1)
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
    class Çüş : Exception
    {
        public Çüş(string mesaj) : base(mesaj)
        {
        }
    }
    class YokDeve : Çüş
    {
        public YokDeve(string mesaj) : base(mesaj)
        {
        }
    }
}


