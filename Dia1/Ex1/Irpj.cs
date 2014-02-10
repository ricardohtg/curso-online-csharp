using System;

namespace Ex1
{
    public class Irpj : Imposto
    {
        public Irpj(Pessoa pj)
        {
            if (!(pj is PessoaJuridica))
            {
                throw new ArgumentException("Erro!");
            }
        }
    }
}