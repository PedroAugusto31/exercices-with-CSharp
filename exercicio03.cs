using System;
using System.Collections.Generic;

namespace exerciciosCsharp2
{
    public class exercicio03
    {
        public static void main3() {
            
            //tresVetores();
            //cumprimentar("Marcelo");
            //anosEmDias(1);
            //horasDeTrabalho(150, 40.5f);
            //mises(2);
            //maiorOuIgual(0, 0);
            //estaEntre(11, 10, 100, false);
            //multiplicacaoManual(5, 1);
            //repetindoArray("código", 2);
            /*int [] notas = {1, 2, 3, 4, 5};
            calcuMedia(notas);
            */
            //areaDoTriangulo(7, 9);
            int [] teste = {5, -15, 50, 3};
            //menorNumeroArray(teste);
            //sorteio(2);
            quantidadePalavras("Sou foda programando");
            //semVogal("Coder");
        }

        public static void tresVetores(){
            int [] vetorInt = {3, 4, 9};
            String [] vetorString = {"Pedro", "Marcelo", "Wilsooooooooooooon"};
            float [] vetorFloat = {2.5f, 6.2f, 4f};

            String resultado = concat(vetorInt, vetorString, vetorFloat);
            Console.WriteLine(resultado);
        }

        public static String concat(int [] a, String [] b, float [] c){

            String concatenacao = a.ToString() + b + c.ToString();

            return concatenacao;
        }

        public static void duasStrings(){
            String string1 = "batata";
            String string2 = "bata";

            
            char [] vetorChar = string1.ToCharArray();
            char [] vetorChar2 = string2.ToCharArray();

        }

        public static void unirArray(){

            int[] arrayPilha = {1, 2, 3, 4, 5};
            int[] arrayAdiciona = {6, 7, 8, 9, 10};

            //int [] lul = arrayPilha + arrayAdiciona;

        }

        int[] arrayInt = {2,3,4,5};
        public static void funcao1(int[] vetor, int multiplyer){
            int[] iraaa = {};
            
            for(int i = 0; i < vetor.Length; i++) {
                iraaa[i] = vetor[i] * multiplyer;
            }
        }

        public static void cumprimentar(String nome){
            Console.WriteLine("Olá, " + nome + "!");
        }

        public static void anosEmDias(int anos){
            int dias = anos * 365;
            Console.WriteLine("Deu " + dias + " em dias");
        }

        public static void horasDeTrabalho(int horas, float moneyPerHour){
            float salario = horas * moneyPerHour;

            Console.WriteLine("Salário igual a R$ " + salario);

        }

        public static void meses(int mes) {
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

        public static void maiorOuIgual(int num1, int num2) {
            if(num1 >= num2){
                Console.WriteLine(true);
            } else{
                Console.WriteLine(false);
            }
        }

        public static void estaEntre(int numero, int minimo, int maximo, bool inclusivo){
            if(inclusivo == true){
                if(numero >= minimo && numero <= maximo){
                    Console.WriteLine(true);
                } else{
                    Console.WriteLine(false);
                }
            } else{
                if(numero > minimo && numero < maximo){
                    Console.WriteLine(true);
                } else{
                    Console.WriteLine(false);
                }
            }
        }
        //Função que multiplica sem o operador de multiplação
        public static void multiplicacaoManual(int numero, int multi){
            if(numero >= 0 && multi >= 0){
            int issoAi = numero;
            for(int i = 1; i < multi; i++){
                
                numero = numero + issoAi;
            }
            Console.WriteLine(numero);
         }
       }

       public static void repetindoArray(String nome, int vezesQueRepete){

           String [] arrayQueRepete = new string[vezesQueRepete];
           
           for(int i = 0; i < vezesQueRepete; i++){
               arrayQueRepete[i] = nome;
               Console.WriteLine(arrayQueRepete[i] + i);
           }
       }

        public static void maisRepetido(int vezesRepetido){

            Console.WriteLine("código");
        }

        public static void calcuMedia(int [] notas){
            int notaFinal = 0;

            for(int i = 0; i < notas.Length; i++){
                notaFinal += notas[i];
            }
            int resultado = notaFinal / notas.Length;
            Console.WriteLine(resultado);
        }

         public static void areaDoTriangulo(float baseTri, float altura){
            float area = baseTri * altura / 2;

             Console.WriteLine(area.ToString("F2"));
         }

         public static void menorNumeroArray(int [] numeros){
             int menorNumero = numeros[0];

             for(int i = 0; i < numeros.Length; i++){
                 if(numeros[i] < menorNumero){
                     menorNumero = numeros[i];
                 }
             }
             Console.WriteLine(menorNumero);
         }

         public static void sorteio(int numero){
             Random aleatorio = new Random();
             int sorteio = aleatorio.Next(1, 10);
            
            if(numero == sorteio){
             Console.WriteLine("Você acertou o número sorteado, " + sorteio);
            } else {
                Console.WriteLine("Você errou o número sorteado, o número era " + sorteio);
            }
         }

          public static void quantidadePalavras(String frase){
              String [] fraseSeparada = frase.Split(" ");

              Console.WriteLine(fraseSeparada.Length);
          }

          public static void semVogal(String frase){
              char[] fraseCharArray = frase.ToCharArray();
              char [] novoArray = {};
                
              Console.WriteLine(fraseCharArray);
              
          }
    }
}