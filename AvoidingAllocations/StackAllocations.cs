using System; 

namespace AvoidingAllocations 
{
    public static class AllocationMethods 
    {
        public static void AllocateSomeStuff(int limit)
        {
            var messages = new Message[limit];
            for (int i = 0; i < limit; i++)
            {
                messages[i] = new Message(i);
            }
        }
        
        public static unsafe void AllocateSomeStuffOnStack(int limit)
        {
            Message* messages = stackalloc Message[limit];
            for (int i = 0; i < limit; i++)
            {
                messages[i] = new Message(i);
            }
        }

        public static void AllocateSomeStuffOnStackWithSpan(int limit)
        {
            Span<Message> messages = stackalloc Message[limit];
            for (int i = 0; i < limit; i++)
            {
                messages[i] = new Message(i);
            }
        }

    }

    /// This will only work if the containing struct contains only value types
    public struct Message 
    {
        private readonly int _message;

        public Message(int message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return $"My message size is is {_message}";
        }
    }
}
