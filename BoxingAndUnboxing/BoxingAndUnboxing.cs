using System;
using System.Collections.Generic;
using System.Linq;

namespace BoxingAndUnboxing 
{
    public interface IMessageProvider
    {
        string GetMessage();
    }

    public struct MessageProvider : IMessageProvider
    {
        public string GetMessage()
        {
            return "Hello World!";
        }
    }

    public static class BoxingMethods 
    {
        //Box struct 
        //Allocate to heap 
        //Call method 
        public static string UnpackMessage(IMessageProvider provider)
        {
            return provider.GetMessage();
        }

        public static string UnpackMessageGeneric<T>(T data) where T : IMessageProvider 
        {
            return data.GetMessage();
        }

        //JIT COMPILED PSEUDOCODE
        //public static string UnpackMessage1(MessageProvider prov){ return prov.GetMessage();}

        public static string UnpackMessageGenericRef<T>(ref T data) where T : IMessageProvider 
        {
            return data.GetMessage();
        }   
    }
}