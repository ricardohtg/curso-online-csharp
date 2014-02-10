using System;
using System.Threading;

namespace Ex1
{
    public class PessoaFisica : Pessoa
    {
        private string cpf;
        private string rg;

        public PessoaFisica(string nome)
        {
            this.setNome(nome);
        }

        public void setCPF(string s)
        {
            this.cpf = s;
        }

        public void setNascimento(int i)
        {
            this.setAno(i);
        }

        public void setRG(string s)
        {
            this.rg = s;
        }


        public int getIdade()
        {
            return DateTime.Now.Year - this.getAno();
        }

        public object EhPessoaFisica()
        {
            return true;
        }

        public object getCPF()
        {
            return this.cpf;
        }

        public static bool ValidaCPF(object cpf)
        {
            if (!cpf.Equals(string.Empty))
            {
                return true;
            }

            return false;
        }
    }
}