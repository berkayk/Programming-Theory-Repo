using System.Collections.Generic;
using UnityEngine;

namespace ExtensionMethods
{
    public static class Helpers
    {
        public static bool RandomBool()
        {
            int randomValue = Random.Range(0, 100);
            return randomValue < 50;
        }
        
        public static GameObject PickRandom(this List<GameObject> list)
        {
            if (list.Count < 1)
                return null;
            
            int index = Random.Range(0, list.Count);
            
            return list[index];
        }
    }
}
