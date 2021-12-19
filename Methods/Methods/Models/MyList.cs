using System;
using System.Collections.Generic;
using System.Text;

namespace Methods.Models
{
    class MyList<T>
    {
        #region AddMethod
        static int counter = -1;
        public T[] arr;

        public MyList()
        {
            arr = new T[0];

        }
        public void Add(T param)
        {
            counter++;
            if (counter % 10 == 0)
            {
                Array.Resize<T>(ref arr, arr.Length + 10);
            }


            arr[counter] = param;

        }
        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void Length()
        {
            Console.WriteLine(arr.Length);
        }
        #endregion
        #region AddRangeMethod
        //public void AddRange(int[] arr)
        //{
        //    int[] rangearr = new int[arr.Length];
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        rangearr[i] = arr[i];
        //    }
        //    foreach (var item in rangearr)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        #endregion
        #region FindMethod
       
        #endregion
    }
}
