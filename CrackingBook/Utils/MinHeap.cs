using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingBook.Utils
{
    public class MinHeap
    {
        public MinHeap()
        {

        }

        public int size = 0;
        int Capacity = 10;
        private int[] arr = new int[10];

        private int LeftChildIndex(int index) {
            return index * 2 + 1;
        }

        private void Swap(int leftIndex, int rightIndex) {
            var temp = arr[leftIndex];
            arr[leftIndex] = arr[rightIndex];
            arr[rightIndex] = temp;
        }

        private int RightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        private int ParentIndex(int index)
        {
            return (index -2)/2;
        }

        public int peek() {
            if (this.size < 0)
                throw new InvalidOperationException();
            return arr[0];
        }

        public int poll()
        {
            if (this.size < 0)
                throw new InvalidOperationException();
            var item = arr[0];
            size--;
            Swap(0, size);
            HeapifyDown();           
            return item;
        }

        public int push(int item)
        {
            if (this.size < 0)
                throw new InvalidOperationException();
            arr[size] = item;
            size++;
            HeapifyUp();
            return item;
        }


        public void HeapifyDown() {
            var index = 0;
            while (LeftChildIndex(index) < size) {
                int leftIndex = LeftChildIndex(index);
                int rightIndex = RightChildIndex(index);
                int smalledIndex = leftIndex;
                if (rightIndex < size && arr[leftIndex] > arr[rightIndex])
                {
                    smalledIndex = rightIndex;
                }
                if (arr[index] == arr[smalledIndex])
                {
                    break;
                }
                else {
                    Swap(index, smalledIndex);
                    index = smalledIndex;
                }
            }
        }

        public void HeapifyUp()
        {
            var index = size - 1;
            while (ParentIndex(index) >= 0 && arr[index] < arr[ParentIndex(index)]) {
                Swap(ParentIndex(index), index);
                index = ParentIndex(index);
            }
        }
    }
}
