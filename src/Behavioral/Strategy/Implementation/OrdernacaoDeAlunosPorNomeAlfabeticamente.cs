using System.Collections.Generic;
using System.Linq;

namespace Strategy.Implementation
{
    public class OrdernacaoDeAlunosPorNomeAlfabeticamente : OrdenacaoStrategy
    {
        public override List<Aluno> Ordernar(List<Aluno> alunos) => alunos.OrderBy(a => a.Nota).ToList();
    }
}
