namespace Ex1
{
    public class PessoaJuridica : Pessoa
    {
        private Endereco endereco;
        private string cnpj;

        public PessoaJuridica(string nome, string cnpj)
        {
            this.setNome(nome);
            this.setCNPJ(cnpj);
        }

        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

        public void setCNPJ(string cnpj)
        {
            this.cnpj = cnpj;
        }

        public object getCNPJ()
        {
            return cnpj;
        }

        public static bool ValidaCNPJ(object cnpj)
        {
            if (!cnpj.Equals(string.Empty))
            {
                return true;
            }

            return false;
        }
    }
}