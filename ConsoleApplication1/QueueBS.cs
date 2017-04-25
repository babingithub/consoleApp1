using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    //public class QueueBS<T> where T: Type
    public class QueueBS
    {
        public int[] data;
        int size;
        //int itemCounts = 0;
        int front = -1;
        int rear = -1;
        public QueueBS(int len)
        {
            size = len;
            data = new int[size];

            //itemCounts = 0;
        }

        public bool IsEmpty()
        {
            return (front == -1 && rear == -1);
        }

        public bool IsFull()
        {
            return rear == size - 1;
        }

        public int Enqueue(int val)
        {

            if ((rear + 1) % size == front)
            {
                return -2;
            }
            else if (IsEmpty())
            {
                rear = 0;
                //front = 0;
            }
            else
            {
                rear = (rear + 1) % size;
            }

            data[rear] = val;

            return rear;
            //if (!IsFull())
            //{
            //    //data[itemCounts] = val;
            //    //itemCounts++;
            //    //data[back++ % size] = val;
            //}
            //else
            //    return size - 1;

            //return itemCounts;

        }

        public int Dequeue()
        {

            if (IsEmpty())
            {
                return -2;
            }
            else if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                front = (front + 1) % size;
            }
           
            var val = data[front];
            data[front] = 0;
            return val;
            //if (!IsEmpty())
            //{

            //    var returnVal = data[0];
            //    itemCounts--;//return data[++front % size];
            //    return returnVal;
            //}
            //else
            //    return -1;
        }

        public int FrontVal()
        {
            return data[front];
        }

        public int RearVal()
        {
            return data[rear];
        }
    }
}
