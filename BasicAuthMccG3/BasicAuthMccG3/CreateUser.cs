namespace BasicAuthMccG3
{
    public class CreateUser
    {
        public static int InputIndex { get; set; }
        public static int Limite { get; set; }

        public CreateUser()
        {
            InputIndex = 0;
            Limite = 1;
            InputOptions();
        }
        public CreateUser(int inputIndex, int limite)
        {
            InputIndex = inputIndex;
            Limite = limite;
            InputOptions();
        }



    }
}