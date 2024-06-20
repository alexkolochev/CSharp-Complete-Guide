namespace Exercise01
{
    internal class ArrayList<T>
    {
        public T[] ArrList { get; set; }

        public ArrayList()
        {
            ArrList = [];
        }

        public ArrayList(T[] array)
        {
            ArrList = array;
        }

        public void Add(T item)
        {
            var arrayTemp = new T[ArrList.Length + 1];

            if (ArrList.Length > 0)
            {
                Array.Copy(ArrList, arrayTemp, ArrList.Length);
                arrayTemp[arrayTemp.Length - 1] = item;
            }
            else
            {
                arrayTemp[0] = item;
            }

            ArrList = arrayTemp;
        }

        public void Put(T item, int index)
        {
            var arrayTemp = new T[ArrList.Length + 1];
            arrayTemp[index] = item;

            if (index == 0)
            {
                Array.Copy(ArrList, 0, arrayTemp, 1, ArrList.Length);
            }
            else
            {
                Array.Copy(ArrList, 0, arrayTemp, 0, index);
                Array.Copy(ArrList, index, arrayTemp, index + 1, arrayTemp.Length - 1 - index);
            }

            ArrList = arrayTemp;
        }

        public void Remove(T item)
        {
            if (Contains(item))
            {
                if (ArrList.Length == 1)
                {
                    Clear();
                }
                else if (ArrList.Length > 1)
                {
                    int index = IndexOf(item);
                    RemoveAt(index);
                }
            }
        }

        public void RemoveAt(int index)
        {
            var arrayTemp = new T[ArrList.Length - 1];

            if (index == 0)
            {
                Array.Copy(ArrList, 1, arrayTemp, 0, arrayTemp.Length);
            }
            else if (index == ArrList.Length - 1)
            {
                Array.Copy(ArrList, arrayTemp, arrayTemp.Length);
            }
            else
            {
                Array.Copy(ArrList, 0, arrayTemp, 0, index);
                Array.Copy(ArrList, index + 1, arrayTemp, index, arrayTemp.Length - index);
            }

            ArrList = arrayTemp;
        }

        public T GetValue(int index)
        {
            return ArrList[index];
        }

        public int Count()
        {
            return ArrList.Length;
        }

        public void Clear()
        {
            ArrList = [];
        }

        public bool Contains(T item)
        {
            return ArrList.Contains(item);
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < ArrList.Length; ++i)
            {
                if (item is not null && item.Equals(ArrList[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public void PrintList()
        {
            foreach (T item in ArrList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
