using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Program
    {
        static IList<MenuItem> menuItems;
        static void Main(string[] args){
            IAulaItem itemSelecionado;
            menuItems = GetMenuItems();

            while (true){
                ImprimirMenuItems(menuItems);
                var opcao = Console.ReadLine();

                int.TryParse(opcao, out int valorOpcao);/*tenta converter o valor para um inteiro, se não conseguir retorna false*/

                if (valorOpcao == 0)
                {
                    break;
                }

                if (valorOpcao > menuItems.Count)
                {
                    break;
                }

                itemSelecionado = Executar(valorOpcao);
                Console.ReadKey();
            }
        }

        private static IAulaItem Executar(int valorOpcao){
            IAulaItem itemSelecionado;
            MenuItem menuItem = menuItems[valorOpcao - 1];
            Type tipoClasse = menuItem.TipoClasse;
            itemSelecionado = (IAulaItem)Activator.CreateInstance(tipoClasse);

            Console.WriteLine();
            string titulo = $"EXECUTANDO: {menuItem.Titulo}";
            Console.WriteLine(titulo);
            Console.WriteLine(new string('=', titulo.Length));

            itemSelecionado.Executar();
            Console.WriteLine();
            Console.WriteLine("Tecle algo para continuar...");
            return itemSelecionado;
        }

        private static void ImprimirMenuItems(IList<MenuItem> menuItems){
            int i = 1;
            Console.WriteLine("SELECIONE UMA OPÇÃO");
            Console.WriteLine("===================");
            Console.WriteLine("0 - Sair");
            foreach (var menuItem in menuItems)
            {
                Console.WriteLine((i++).ToString() + " - " + menuItem.Titulo);
            }
        }

        private static IList<MenuItem> GetMenuItems(){
            return new List<MenuItem>{
                new MenuItem("Tipos de Valor", typeof(TiposDeValor)), 
                new MenuItem("Tipos Inteiro", typeof(TiposInteiros)), 
                new MenuItem("Tipos de Ponto Flutuante", typeof(PontoFlutuante)), 
                new MenuItem("Decimal", typeof(Decimal)), 
                new MenuItem("Booleanos", typeof(Booleanos)) 
            };
        }
    } 
}

