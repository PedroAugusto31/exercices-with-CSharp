using System;
using System.Collections.Generic;

namespace exerciciosCsharp2
{
    public class exercicio02
    {

        public static void main2() {

            planoDeSaude(61);
            jurosMes(100, 4);
           helloWorldWhile();
           deUmACinquenta();
           umACem();
           arrayParesEImpares();
          taxaDeAltura(130f, 4f, 150f, 2f);
          intervaloDezEVinte();
          int [] testArray = {10, 8, 6};
          maiorEMenor(testArray);
          menorQueZero(testArray);
          mediaAritmetica(testArray);
        }

        // This function is like a health care plan, the plan depends on the age(idade) of the person who will get this plan
        public static void planoDeSaude(int idade) {

            int valorAPagar;
            int valorPadrao = 100;
            if(idade < 10) {
                valorAPagar = valorPadrao + 80;
                Console.WriteLine("O conveniado deverá pagar R$ " + valorAPagar);
            }
            else if(idade >= 10 && idade <= 30) {
                valorAPagar = valorPadrao + 50;
                Console.WriteLine("O conveniado deverá pagar R$ " + valorAPagar);
            }
            else if(idade > 30 && idade <= 60){
                valorAPagar = valorPadrao + 95;
                Console.WriteLine("O conveniado deverá pagar R$ " + valorAPagar);
            }
            else if(idade > 60) {
                valorAPagar = valorPadrao + 130;
                Console.WriteLine("O conveniado deverá pagar R$ " + valorAPagar);
            }
        }

        // This function gets a inicial capital, then a simple fee calculation is made
        public static void jurosMes(int capitalInicial, int tempo) {

            float juros = 0.05f;
            int atraso = tempo - 1;
            double quaseTotal = capitalInicial * (1 + juros);
            double total = Math.Pow(quaseTotal, atraso);
            Console.WriteLine("O total deu R$ " + total);
        }

        // This function prints "Hello, world!" 11 times
        public static void helloWorldWhile(){
            int arrayEven =0;
            while(arrayEven < 11){
                arrayEven++;
                Console.WriteLine("Hello, World!");
            }
        }

        // It prints the numbers from 1 to 50
        public static void deUmACinquenta(){

            int cu = 0;
            while(cu < 50) {
                cu++;
                Console.WriteLine(cu);
            }
        }

        // This one prints the even numbers from 1 to 100
        public static void umACem() {

            int numberToPrint = 0;
            while(numberToPrint < 100){
                numberToPrint++;
                if(numberToPrint % 2 == 0) {
                    Console.WriteLine(numberToPrint);
                }
            }
        }

        // This function gets the height and the growth rate, and returns if the first child will become bigger than the second one or the opposite
        public static void taxaDeAltura(float alturaA, float taxaCrescimentoA, float alturaB, float taxaCrescimentoB){
            int anosTotais = 0;
           

            if(alturaA > alturaB){
               if(taxaCrescimentoA > taxaCrescimentoB) {
                   Console.WriteLine("Não vai passar nunca");
               }
               else {
               
               while(alturaB <= alturaA){
                   alturaB += taxaCrescimentoB;
                   alturaA += taxaCrescimentoA;
                   anosTotais++;
                }
                Console.WriteLine("A criança A ficou com " + alturaA + " Cm e a criança B ficou com " + alturaB + " Cm em " + anosTotais + " anos");
               }
            } else{
                if(taxaCrescimentoB > taxaCrescimentoA) {
                    Console.WriteLine("Não vai passar nunca, segundo caso");
                } else{
                    
                while(alturaA <= alturaB){
                   alturaB += taxaCrescimentoB;
                   alturaA += taxaCrescimentoA;
                   anosTotais++;
                 }
                Console.WriteLine("A criança A ficou com " + alturaA + "Cm e a criança B ficou com " + alturaB + "Cm em " + anosTotais + " anos, segundo caso");
                }
                
            }
        }

        // This function counts the number of even and odd numbers of the specific array
         public static void arrayParesEImpares() {
            int[] arrayEven = {2, 5, 4, 33, 38};
            int par = 0;
            int impar = 0;
            for(int i = 0; i < arrayEven.Length; i++) {
                if(arrayEven[i] % 2 == 0) {
                    par++;
                } else{
                    impar++;
                }
            }
            Console.WriteLine(par + " pares");
            Console.WriteLine(impar + " ímpares");
        }

        // This function will return if the number in the array is greater than 10 and less than 20
        public static void intervaloDezEVinte(){
            int [] intervalo = {2, 15, 4, 17, 20};

            for(int i = 0; i < intervalo.Length; i++){
                if(intervalo[i] >= 10 && intervalo[i] <= 20) {
                    Console.WriteLine("O número " + intervalo[i] + " está dentro do intervalo");
                } else {
                    Console.WriteLine("O número " + intervalo[i] + " está fora do intervalo");
                }
            }
        }

        // This function returns the biggest and the lowest number of the array
        public static void maiorEMenor(int [] arrayMaiorOuMenor){
            int maiorNumero = arrayMaiorOuMenor[0];
            int menorNumero = arrayMaiorOuMenor[0];
            for(int i = 0; i < arrayMaiorOuMenor.Length; i++) {
                    if(arrayMaiorOuMenor[i] > maiorNumero){
                        maiorNumero = arrayMaiorOuMenor[i];
                    }
                    else if(arrayMaiorOuMenor[i] < menorNumero){
                        menorNumero = arrayMaiorOuMenor[i];
                    }
            }
            Console.WriteLine("O maior número foi: " + maiorNumero + " o menor número foi: " + menorNumero);
        }

        // This function gets the elements of an array and count how many of them are less than zero
        public static void menorQueZero(int [] arrayMenor){

            int negativados = 0;
            for(int i = 0; i < arrayMenor.Length; i++) {
                if(arrayMenor[i] < 0) {
                    negativados++;
                }
            }
            Console.WriteLine(negativados);
        }

        // This function sums all the numbers of the array, then makes the arithmetic average
        public static void mediaAritmetica(int [] notas) {

            int soma = 0;

            for(int i = 0; i < notas.Length; i++) {
                soma += notas[i];
            }
            int resultado = soma / notas.Length;
            Console.WriteLine(resultado);
        }
    }

}