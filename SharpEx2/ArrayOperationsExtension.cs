using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SharpEx2
{

    public class ArrayOperations : IEnumerable<int>
    {
        private readonly int[] _array;

        public ArrayOperations()
        {

        }

        public ArrayOperations(int[] oArray)
        {
            _array = oArray;
        }

        public int[] Array
        {
            get;
            set;
        }

        public IEnumerator GetEnumerator()
        {
            return _array.GetEnumerator();
        }

        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            //throw new NotImplementedException();
            foreach (int item in _array)
            {
                yield return item;
            }
        }
    }
    public static class ArrayOperationsExtensions
    {
        public static IEnumerable<int> CollectEven(this ArrayOperations array)
        {
            return array.Where(t => t % 2 == 0);
        }
    }
}
