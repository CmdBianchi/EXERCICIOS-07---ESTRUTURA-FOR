using System;
namespace EXERCICIOS_07___ESTRUTURA_FOR{
    class Program{
        /// -------> START / MAIN 
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Msg();
            Conditional();
        }
        /// -------> FUNCTIONS
        /////////////////////////////////////////////////////////////////////////////////////////////
        static void Msg(){
            Console.WriteLine("Exercício 04 - estrutura repetitiva FOR - Lista de exercícios.");
        }
        //------------------------------------------------------------------------------------------//
        static void Conditional(){
            int n = int.Parse(Console.ReadLine()); //----> Números de casos

              for (int i = 1; i <= n; i++){
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
              }           
        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        /// -------> END
    }
}
