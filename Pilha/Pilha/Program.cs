using System;

namespace Pilha
{
    class Program
    {
        static void Main()
        {
            var Pilha = new Queue();
            
            Pilha.StackUp(1);
            Pilha.StackUp(10);
            Pilha.StackUp(100);

            Console.WriteLine(Pilha.UnStack());
            Console.WriteLine(Pilha.UnStack());
            Console.WriteLine(Pilha.UnStack());
        }
    }
}
