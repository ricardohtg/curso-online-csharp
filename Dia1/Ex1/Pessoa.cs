namespace Ex1
{
    public class Pessoa
    {
        private string nome;
        private int ano;

        internal void setNome(string p)
        {
            nome = p;
        }

        internal void setAno(int p)
        {
            ano = p;
        }

        internal int getAno()
        {
            return ano;
        }

        public object getNome()
        {
            return nome;
        }
    }
}