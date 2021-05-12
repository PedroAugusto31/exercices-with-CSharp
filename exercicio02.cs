using System;
using System.Collections.Generic;

namespace exerciciosCsharp2
{
    public class exercicio02
    {

        public static void main2() {

            //planoDeSaude(61);
            //jurosMes(100, 4);
           //helloWorldWhile();
           //deUmACinquenta();
           //umACem();
           //arrayComPares();
          //taxaDeAltura(130f, 4f, 150f, 2f);
          //interValoPhoda();
          int [] irrrra = {10, 8, 6};
          //maiorEMenor(irrrra);
          //menorQueZero(irrrra);
            mediaAritmetica(irrrra);
        }

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

        public static void jurosMes(int capitalInicial, int tempo) {

            float juros = 0.05f;
            int atraso = tempo - 1;
            double quaseTotal = capitalInicial * (1 + juros);
            double total = Math.Pow(quaseTotal, atraso);
            Console.WriteLine("O total deu R$ " + total);
        }

        public static void helloWorldWhile(){
            int batata =0;
            while(batata < 11){
                batata++;
                Console.WriteLine("Hello, World!");
            }
        }

        public static void deUmACinquenta(){

            int cu = 0;
            while(cu < 50) {
                cu++;
                Console.WriteLine(cu);
            }
        }

        public static void umACem() {

            int cuzcuz = 0;
            while(cuzcuz < 100){
                cuzcuz++;
                if(cuzcuz % 2 == 0) {
                    Console.WriteLine(cuzcuz);
                }
            }
        }

        public static void alturasETaxas(int altura, float taxa) {

        }

        public static void taxaDeAltura(float alturaA, float taxaCrescimentoA, float alturaB, float taxaCrescimentoB){
            int cu2 = 0;
           

            if(alturaA > alturaB){
               if(taxaCrescimentoA >= taxaCrescimentoB) {
                   Console.WriteLine("Não vai passar nunca");
               }
               else {
               cu2 =  batatinhaMassa(alturaB, taxaCrescimentoB, alturaA, taxaCrescimentoA);
               }
                Console.WriteLine("A criança A ficou com " + alturaA + " Cm e a criança B ficou com " + alturaB + " Cm em " + cu2 + " anos");
            } else{
                if(taxaCrescimentoB >= taxaCrescimentoA) {
                    Console.WriteLine("Não vai passar nunca2");
                } else{
                    cu2 = batatinhaMassa(alturaA, taxaCrescimentoA, alturaB, taxaCrescimentoB);
                }
                
                Console.WriteLine("A criança A ficou com " + alturaA + "Cm e a criança B ficou com " + alturaB + "Cm em " + cu2 + " anos2");
            }
        }

        public static int batatinhaMassa(float alturaMenor, float taxaMenor, float alturaMaior, float taxaMaior) {
            int ano = 0;

            while(alturaMenor < alturaMaior) {
                alturaMenor += taxaMenor;
                alturaMaior += taxaMaior;
                ano++;
            }
            return ano;
        }

         public static void arrayComPares() {
            int[] batata = {2, 5, 4, 33, 38};
            int par = 0;
            int impar = 0;
            for(int i = 0; i < batata.Length; i++) {
                if(batata[i] % 2 == 0) {
                    par++;
                } else{
                    impar++;
                }
            }
            Console.WriteLine(par + " pares");
            Console.WriteLine(impar + " ímpares");
        }

        public static void interValoPhoda(){
            int [] intervalo = {2, 15, 4, 17, 20};

            for(int i = 0; i < intervalo.Length; i++){
                if(intervalo[i] >= 10 && intervalo[i] <= 20) {
                    Console.WriteLine("O número " + intervalo[i] + " está dentro do intervalo");
                } else {
                    Console.WriteLine("O número " + intervalo[i] + " está fora do intervalo");
                }
            }
        }

        public static void maiorEMenor(int [] arrayPhoda){
            int maiorNumero = arrayPhoda[0];
            int menorNumero = arrayPhoda[0];
            for(int i = 0; i < arrayPhoda.Length; i++) {
                    if(arrayPhoda[i] > maiorNumero){
                        maiorNumero = arrayPhoda[i];
                    }
                    else if(arrayPhoda[i] < menorNumero){
                        menorNumero = arrayPhoda[i];
                    }
            }
            Console.WriteLine(maiorNumero + " cu " + menorNumero);
        }

        public static void menorQueZero(int [] tomaNoCuu){

            int negativados = 0;
            for(int i = 0; i < tomaNoCuu.Length; i++) {
                if(tomaNoCuu[i] < 0) {
                    negativados++;
                }
            }
            Console.WriteLine(negativados);
        }

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