using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.StackInArray
{
    class StackInArray
    {
        private int _top = -1;
        private int[] _array = null;
        public StackInArray(int size)
        {
            this._array = new int[size];
        }

        public void Push(int value)
        {
            this._array[this._top] = value;
            this._top++;
        }

        public void Pop()
        {
            if (this._top > 0)
            {
                this._top--;
            }
        }


    }
}
