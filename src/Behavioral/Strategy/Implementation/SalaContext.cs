using System.Collections.Generic;

namespace Strategy.Implementation
{
    public class SalaContext
    {
        public OrdenacaoStrategy Strategy { get; }

        public SalaContext(OrdenacaoStrategy strategy)
        {
            Strategy = strategy;
        }

        public List<Aluno> Ordernar(List<Aluno> alunos)
        {
            return Strategy.Ordernar(alunos);
        }
    }
}
