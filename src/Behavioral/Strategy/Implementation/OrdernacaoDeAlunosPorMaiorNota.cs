using System.Collections.Generic;
using System.Linq;

namespace Strategy.Implementation
{
    public class OrdernacaoDeAlunosPorMaiorNota : OrdenacaoStrategy
    {
        public override List<Aluno> Ordernar(List<Aluno> alunos) => alunos.OrderByDescending (a => a.Nota).ToList();
    }
}
