using System;

namespace Exception_Handling_Exercise.models {
    public class NegativeNumberException : Exception {
        public NegativeNumberException(): base("A negative number was entered") {}
        public NegativeNumberException(string message): base(message){}
    }
}