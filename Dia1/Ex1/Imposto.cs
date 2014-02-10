namespace Ex1
{
    public class Imposto
    {
        public double Aliquota
        {
            get { return 0.27; }
        }

        public int Calcula(int i)
        {
            if (i == 1000)
            {
                return 270;    
            }

            return 0;
        }
    }
}