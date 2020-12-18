using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui vai o código do programa
            // C# é uma linguagem case sensitive

            // declarar as variaveis
            float nota1, nota2, nota3, media;
            string nomeCompleto;

            // entrada de dados
            Console.WriteLine("Digite o nome do aluno");
            nomeCompleto = Console.ReadLine();
            Console.Write("Digite a primeira nota: ");
            nota1 = float.Parse (Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            nota2 = float.Parse(Console.ReadLine());
            
            Console.Write("Digite a terceira nota: ");
            nota3 = float.Parse(Console.ReadLine());    

            // Processamento
            media = (nota1+nota2+nota3)/3;

            // Exibir o resultado
            if(media>5){
                // valor verdadeiro
                Console.WriteLine("O aluno "+nomeCompleto+" está aprovado com a média de: "+media);
            }else{
                // Valor falso
                Console.WriteLine("O aluno está reprovado com a media de:"+media);                
            }
         }
    }
}
