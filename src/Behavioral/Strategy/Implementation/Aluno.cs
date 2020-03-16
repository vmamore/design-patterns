namespace Strategy.Implementation
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Nota { get; set; }

        public override string ToString()
        {
            return $"{Nome} - Nota: {Nota}";
        }
    }
}
