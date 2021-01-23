using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keyItems;
        TValue[] valueItems;
        //constructor
        public MyDictionary()
        {
            keyItems = new TKey[0];
            valueItems = new TValue[0];
        }
        public void Add(TKey keys, TValue values)
        {
            TKey[] tempKeys = keyItems;
            TValue[] tempValues = valueItems;
           
            keyItems = new TKey[keyItems.Length + 1];
            valueItems = new TValue[valueItems.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
               keyItems[i] = tempKeys[i];
            }
            keyItems[keyItems.Length - 1] = keys;

            for (int i = 0; i < tempValues.Length; i++)
            {             
                valueItems[i] = tempValues[i];
            }            
            valueItems[valueItems.Length - 1] = values;           
        }
        public int Count
        {
            get { return keyItems.Length; }
        }
        
        public TKey[] Keys
        {
            get { return keyItems; }
        }

        public TValue[] Values
        {
            get { return valueItems; }
        }
    }
    }
