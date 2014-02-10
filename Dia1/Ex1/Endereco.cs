namespace Ex1
{
    public class Endereco
    {
        private string rua;
        private string bairro;
        private int numero;
        private bool ativo;

        public void setRua(string rua)
        {
            this.rua = rua;
        }

        public void setBairro(string bairro)
        {
            this.bairro = bairro;
        }

        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        public void setAtivo(bool ativo)
        {
            this.ativo = ativo;
        }
    }
}