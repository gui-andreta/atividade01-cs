/*
Faça um programa em que o usuario
informa 5 numeros DIFERENTES.
Guarde em um vetor e imprima
a média deles, e informe qual o maior.
 */

internal class Program
{
    private static void Main(string[] args)
    {
        double[] numeros = new double[5];
        double maior, soma, mediaFinal, numero;
        int qtdNumeros;

        soma = 0;
        maior = 0;
        qtdNumeros = 0;

        while (qtdNumeros < 5)
        {
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            // Para não ler numeros que ja existem no vetor;
            if (numeros.Contains(numero))
            {
                continue; 
            }
            else
            {
                numeros[qtdNumeros] = numero;

                //Fazendo a soma para fazer a média;
                soma = numeros[qtdNumeros] + soma;

                //Fazendo o laço avançar para receber os próximos numeros;
                qtdNumeros++;
            }

            //Lógica para decidir qual o maior número do Vetor;
            if (numero > maior)
            {
                maior = numero;
            }
        }


        mediaFinal = soma / qtdNumeros;

        Console.WriteLine("O maior número é: " + maior);

        Console.WriteLine("A média do vetor é: " + mediaFinal);
    }
}