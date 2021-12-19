using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Models
{
    class DataList<T> where T:Person1
    {
        private T[] arr;
        public DataList()
        {
            arr = new T[0];
        }
        public void Add(T data)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = data;
        }
        public void GetAll()
        {
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item.Age);
            }
        }
    }
}
