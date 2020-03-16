using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementation
{
    public abstract class OrdenacaoStrategy
    {
        public abstract List<Aluno> Ordernar(List<Aluno> alunos);
    }
}
