using Strategy.Idea;
using Strategy.Implementation;
using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // IDEA
            new Context(new ConcreteStrategyA()).Method();

            new Context(new ConcreteStrategyB()).Method();

            new Context(new ConcreteStrategyC()).Method();

            // IMPLEMENTATION

            var alunos = new List<Aluno>
            {
                new Aluno
                {
                    Nome = "André",
                    Nota = 5
                },
                new Aluno
                {
                    Nome = "João",
                    Nota = 10
                },
                new Aluno
                {
                    Nome = "Beatriz",
                    Nota = 8
                },
            };

            var alunosOrdenadosPorMaiorNota = new SalaContext(new OrdernacaoDeAlunosPorMaiorNota()).Ordernar(alunos);

            var alunosOrdenadosPorNome = new SalaContext(new OrdernacaoDeAlunosPorNomeAlfabeticamente()).Ordernar(alunos);

            foreach(var alunoMaiorNota in alunosOrdenadosPorMaiorNota)
                Console.WriteLine(alunoMaiorNota);

            Console.WriteLine();

            foreach (var alunoOrdemAlfabetica in alunosOrdenadosPorNome)
                Console.WriteLine(alunoOrdemAlfabetica);
        }
    }
}
