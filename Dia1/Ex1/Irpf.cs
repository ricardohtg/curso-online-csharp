using System;

namespace Ex1
{
    public class Irpf : Imposto
    {
        public Irpf(Pessoa pessoa)
        {
            if (!(pessoa is PessoaFisica))
            {
                throw new ArgumentException("Erro!");
            }
        }
    }
}