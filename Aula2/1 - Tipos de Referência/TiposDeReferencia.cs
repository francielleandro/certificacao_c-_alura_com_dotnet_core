namespace certificacao_csharp_roteiro {
    class TiposDeReferencia : IAulaItem
    {
        public void Executar()
        {
            int idade = 29;
            int copiaIdade = idade;

            Console.WriteLine("int idade = 29;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            idade = 30;

            Console.WriteLine();

            Console.WriteLine("int idade = 30;");
            Console.WriteLine("int copiaIdade = idade;");
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            var cliente1 = new Cliente("Franciel",29);
            var cliente2 = cliente1;


            Console.WriteLine(@"var cliente1 = new Cliente(""Franciel"", 29);");
            Console.WriteLine("var cliente2 = cliente1;");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");

            cliente1.Nome = "Anne";

            Console.WriteLine();
            Console.WriteLine(@"cliente1.Nome = ""Anne"";");
            Console.WriteLine($"cliente1: {cliente1}");
            Console.WriteLine($"cliente2: {cliente2}");


        }    
    }

    class Cliente {

        public string Nome {get; set;}
        public int Idade {get; set;}
        public Cliente(string nome, int idade){
            Nome = nome;
            Idade = idade;
        }

        public override string ToString()
        {
            return $"Nome {Nome}, Idade: {Idade}";
        }

    }
}