using System;

namespace Dict
{
    public class MyDictionary<K,V>
    {
        K[] Keys;
        V[] Values;
        public MyDictionary()
        {   
            Keys = new K[0];
            Values = new V[0];            
        }
        public void Add(K a, V b)
        {   
            if (a == null)
            {
                throw new ArgumentNullException("Anahtar null olamaz!");
            }
            for (int i = 0; i < Keys.Length; i++)
            {
                if (Keys[i].Equals(a))
                {
                    throw new ArgumentException("Daha önceden girilen bir anahtar tekrar girilemez!");
                }
            }            
            K[] temp_K = Keys;
            V[] temp_V = Values;
            Keys = new K[Keys.Length + 1];
            Values = new V[Values.Length + 1];
            for (var i = 0; i < temp_K.Length; i++)
            {
                Keys[i] = temp_K[i];
                Values[i] = temp_V[i];
            }
            Keys[Keys.Length - 1] = a;
            Values[Values.Length - 1] = b;
        }
        public V Get(K key)
        {
            for (int i = 0 ; i < Keys.Length ; i++)
            {
                if (Keys[i].Equals(key))
                {
                    return Values[i];
                }
            }
            throw new ArgumentException("Böyle bir anahtat yok!");
        }
    }
}
