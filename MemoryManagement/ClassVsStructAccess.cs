//TODO DO

using System; 

namespace ClassVsStructAccess 
{
    public class SomeClass 
    {
        public SomeClass(int i)
        {
            prop1 = i;
            prop2 = i;
        }
        public int prop1 {get; set;}
        public int prop2 {get; set;}
    }

    public struct SomeStruct 
    {
        public SomeStruct(int i)
        {
            prop1 = i;
            prop2 = i;   
        }
        public int prop1 {get; set;}
        public int prop2 {get; set;}
    }

    public static class AccessorMethods 
    {
        public static int ClassAccessor(SomeClass[] data, int index)
        {
            return data[index].prop1;
        }

        public static int StructAccessor(SomeStruct[] data, int index)
        {
            return data[index].prop1;
        }
    }
}
