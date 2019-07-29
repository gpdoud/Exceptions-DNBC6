using System;

namespace ExceptionsProject {

    class Program {
        static void Main(string[] args) {
            try {
                int answer = Level1.Divide(4, 0);
                Console.WriteLine($"4 / 2 is {answer}");
            } catch (DivideByZeroException) {
                Console.WriteLine("Cannot divide by zero.");
            } catch(Exception ex) {
                Console.WriteLine($"An unknown exception occurred. Message is {ex.Message}");
            }
        }
    }

    class Level1 {
        public static int Divide(int a, int b) {
            int answer = Level2.Divide(a, b);
            return answer;
        }
    }

    class Level2 {
        public static int Divide(int a, int b) {
            int answer = Level3.Divide(a, b);
            return answer;
        }
    }

    class Level3 {
        public static int Divide(int a, int b) {
            throw new ExecutionEngineException("We generated this exception.");
            int answer = a / b;
            return answer;
        }
    }


}
