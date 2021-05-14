using System;
using System.Collections.Generic;

namespace exerciciosCsharp2
{
    public class exercicio03
    {
        public static void main3() {
            
            cumprimentar("Marcelo");
            anosEmDias(1);
            horasDeTrabalho(150, 40.5f);
            mesesDoAno(2);
            maiorOuIgual(0, 0);
            multiplicacaoManual(5, 1);
            repetindoArray("código", 2);
            areaDoTriangulo(7, 9);
            sorteio(2);
            quantidadePalavras("Mensagem de teste");
        }

        // Returns a greeting message with the String(name)
        public static void cumprimentar(String nome){
            Console.WriteLine("Olá, " + nome + "!");
        }

        // Converts years in days
        public static void anosEmDias(int anos){
            int dias = anos * 365;
            Console.WriteLine("Deu " + dias + " em dias");
        }

        // Calculates the salary of an employee
        public static void horasDeTrabalho(int horas, float dinheiroPorHora){
            float salario = horas * dinheiroPorHora;

            Console.WriteLine("Salário igual a R$ " + salario);
        }

        // Returns the month according to the number on the parameter
        public static void mesesDoAno(int mes) {
            switch(mes){
        case 1: Console.WriteLine("janeiro");
        break;
        case 2: Console.WriteLine("fevereiro");
        break;
        case 3: Console.WriteLine("março");
        break;
        case 4: Console.WriteLine("abril");
        break;
        case 5: Console.WriteLine("maio");
        break;
        case 6: Console.WriteLine("junho");
        break;
        case 7: Console.WriteLine("julho");
        break;
        case 8: Console.WriteLine("agosto");
        break;
        case 9: Console.WriteLine("setembro");
        break;
        case 10: Console.WriteLine("outubro");
        break;
        case 11: Console.WriteLine("novembro");
        break;
        case 12: Console.WriteLine("dezembro");
        break;
            }
        }

        // Returns true or false if the first number is greater or equal to the second one
        public static void maiorOuIgual(int num1, int num2) {
            if(num1 >= num2){
                Console.WriteLine(true);
            } else{
                Console.WriteLine(false);
            }
        }

        // Function that multiplies a number without the multiply operator
        public static void multiplicacaoManual(int numero, int multi){
            if(numero >= 0 && multi >= 0){
            int issoAi = numero;
            for(int i = 1; i < multi; i++){
                
                numero = numero + issoAi;
            }
            Console.WriteLine(numero);
         }
       }

        // This function prints the String(nome) how many times you put in the parameter
        public static void repetindoArray(String nome, int vezesQueRepete){

           String [] arrayQueRepete = new string[vezesQueRepete];
           
           for(int i = 0; i < vezesQueRepete; i++){
               arrayQueRepete[i] = nome;
               Console.WriteLine(arrayQueRepete[i]);
           }
       }

        // Calculates the area of a triangle
         public static void areaDoTriangulo(float baseTri, float altura){
            float area = baseTri * altura / 2;

             Console.WriteLine(area.ToString("F2"));
         }

        // This function gets the number, and makes a random number, if the number you putted is the same as the random one, it'll print that you hitted it
         public static void sorteio(int numero){
             Random aleatorio = new Random();
             int sorteio = aleatorio.Next(1, 10);
            
            if(numero == sorteio){
             Console.WriteLine("Você acertou o número sorteado, " + sorteio);
            } else {
                Console.WriteLine("Você errou o número sorteado, o número era " + sorteio);
            }
         }

        // This function splits the phrase and returns the number of word in it
          public static void quantidadePalavras(String frase){
              String [] fraseSeparada = frase.Split(" ");

              Console.WriteLine(fraseSeparada.Length);
            }
      }
}