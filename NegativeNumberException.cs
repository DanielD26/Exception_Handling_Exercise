using System;

namespace Exception_Handling_Exercise {
    public class NegativeNumberException : Exception {
        public NegativeNumberException(): base("A negative number was entered") {}
        public NegativeNumberException(string message): base(message){}
    }
}