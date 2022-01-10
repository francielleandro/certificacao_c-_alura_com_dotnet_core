namespace certificacao_csharp_roteiro{
    class PontoFlutuante : IAulaItem
    {
        /*
             C#      .NET           Faixa de Valores         Precisão
            ============================================================
            float	  System.Single  ±1.5e−45 to ±3.4e38	 7    dígitos
            double  System.Double  ±5.0e−324 to ±1.7e308	 15-16 dígitos
        */
        public void Executar(){
            float idade = 15;
            Console.WriteLine("idade", idade);
            idade = 15.5f;
            Console.WriteLine($"long.MinValue: {long.MinValue}");
            Console.WriteLine($"long.MaxValue: {long.MaxValue}");
            float massaDaTerra = 5.9736e24f; 
            Console.WriteLine($"massaDaTerra: {massaDaTerra}");
            float numeroPI = 3.14159f;
            Console.WriteLine($"numeroPI: {numeroPI}");
            double numeroMuitoMaior = 6e100;
            Console.WriteLine("double 6e100", numeroMuitoMaior);
            Console.WriteLine();
            Console.WriteLine("Operação com int, float e short");
            int x = 3;
            short y = 5;
            var resultado1 = x * y;
            Console.WriteLine("x * y = {0}", resultado1);
            Console.WriteLine($"O resultado é do tipo: {resultado1.GetType()}");
            float z = 4.5f;
            var resultado2 = (x * y) / z;
            Console.WriteLine("x * y / z = {0}", resultado2);
            Console.WriteLine($"O resultado é do tipo: {resultado2.GetType()}");
        }
    }
}