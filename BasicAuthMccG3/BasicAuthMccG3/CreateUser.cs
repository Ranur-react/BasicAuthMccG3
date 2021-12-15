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
        public static void InputOptions()
        {
            switch (InputIndex)
            {
                case 0:
                    //inputproduk
                    for (int i = 0; i < Limite; i++)
                    {
                        if (Entry())
                        {
                            break;
                        }
                    }
                    ShowUpList(0, "Product List :");
                    break;
                default:
                    //inputjual
                    break;
            }
        }

        public static bool Entry()
        {



        }
}