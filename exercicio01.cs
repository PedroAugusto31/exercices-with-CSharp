using System;

namespace exerciciosCsharp2 
{
    public class exercicio01
    {
        public static void Main(String [] args){
        //fatorial(6);
        //vendaCarro("hatch");
        //calculadora(8, " % ", 5);
        //planosMassa(1700, "A");
        //planosMassa(1700, "B");
        //planosMassa(1700, "C");
        //deZeroADez(8);
        //menuLanchonete(100, 3);
        programaNotas(179);
        }

        // This function gets the number and returns the factorial result of it.
        // Example: valor(value) = 5, return: 120.

        public static void fatorial(int valor){
            int resultadoFatorial = valor;

            for(int i = 1; i < valor; i++){
                resultadoFatorial = resultadoFatorial * i;
            }

            Console.WriteLine(resultadoFatorial);
        }

        // This function gets a string that would be an car order, if your order is the hacth model, you'll get it
        // Otherwise, it will return a question like "Wouldn't you prefer this model?".
        public static void vendaCarro(String pedido) {

            switch(pedido){
                case "hatch":
                Console.WriteLine("Compra efetuada com sucesso");
                break;
                case "sedan":
                Console.WriteLine("Tem certeza que não prefere este modelo?");
                break;
                case "motocicletas":
                Console.WriteLine("Tem certeza que não prefere este modelo?");
                break;
                case "caminhonetes":
                Console.WriteLine("Tem certeza que não prefere este modelo?");
                break;
                default:
                Console.WriteLine("Erro");
                break;
            }
        }

        // This function is a manual calculator, instead of returning just the result, it will result the whole calculation
        public static void calculadora(int num1, String operation, int num2) {

            switch(operation){
                case " + ":
                int sum = num1 + num2;
                Console.WriteLine(num1 + " + " + num2 + " = " + sum);
                break;
                 case " - ":
                int minum = num1 - num2;
                Console.WriteLine(num1 + " - " + num2 + " = " + minum);
                break;
                 case " * ":
                int mult = num1 * num2;
                Console.WriteLine(num1 + " * " + num2 + " = " + mult);
                break;
                 case " / ":
                int division = num1 / num2;
                Console.WriteLine(num1 + " / " + num2 + " = " + division);
                break;
                case " % ":
                int divisionRest = num1 % num2;
                Console.WriteLine(num1 + " % " + num2 + " = " + divisionRest);
                break;
            }
        }

        // This function will return the salary increase depending on which plan the employee choosed
        public static void planosMassa(int salario, String plano) {

            switch(plano) {
                
                case "A":
                float aumentoPlanoA = salario * 0.1f;
                float novoSalarioPlanoA = salario + aumentoPlanoA;
                // Return message: The new salary is: (newSalaryPlanA), the last line of each case returns the same message.
                Console.WriteLine("O novo salário ficou: " + novoSalarioPlanoA);
                break;

                case "B":
                float aumentoPlanoB = salario * 0.15f;
                float novoSalarioB = salario + aumentoPlanoB;
                Console.WriteLine("O novo salário ficou: " + novoSalarioB);
                break;

                case "C":
                float aumentoPlanoC = salario * 0.20f;
                float novoSalarioC = salario + aumentoPlanoC;
                Console.WriteLine("O novo salário ficou: " + novoSalarioC);
                break;
            }
        }

        // This function returns a number from 0 to 10 in full 
        public static void deZeroADez(int num) {

            switch(num){
                case 0:
                Console.WriteLine("zero");
                break;

                case 1:
                Console.WriteLine("um");
                break;

                case 2:
                Console.WriteLine("dois");
                break;

                case 3:
                Console.WriteLine("três");
                break;

                case 4:
                Console.WriteLine("quatro");
                break;

                case 5:
                Console.WriteLine("cinco");
                break;

                case 6:
                Console.WriteLine("seis");
                break;

                case 7:
                Console.WriteLine("sete");
                break;

                case 8:
                Console.WriteLine("oito");
                break;

                case 9:
                Console.WriteLine("nove");
                break;

                case 10:
                Console.WriteLine("dez");
                break;

                default: 
                Console.WriteLine("Número fora do alcance");
                break;
            }
        }

        // This function is like a diner menu, you ask your order(codigo or code), then you ask how much of it you want(quant)
        public static void menuLanchonete(int codigo, int quant) {

            switch(codigo){
            // Depending on the order you choosed, it will return you bill
                case 100:
                float contaHot = quant * 3.0f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Cachorros quentes, certo? A conta deu R$ " + contaHot);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Cachorro quente, certo? A conta deu R$ " + contaHot);
                }
                break;
                case 200:
                float contaHam = quant * 4.0f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Hambúrgueres, certo? A conta deu R$ " + contaHam);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Hambúrguer, certo? A conta deu R$ " + contaHam);
                }
                break;

                case 300:

                float contaCheese = quant * 5.5f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Cachorros quentes, certo? A conta deu R$ " + contaCheese);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Cachorro quente, certo? A conta deu R$ " + contaCheese);
                }
                break;

                case 400:

                float contaBauru = quant * 7.5f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Cachorros quentes, certo? A conta deu R$ " + contaBauru);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Cachorro quente, certo? A conta deu R$ " + contaBauru);
                }
                break;

                case 500:

                float contaRefri = quant * 3.5f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Cachorros quentes, certo? A conta deu R$ " + contaRefri);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Cachorro quente, certo? A conta deu R$ " + contaRefri);
                }
                break;

                case 600:

                float contaSuco = quant * 2.8f;
                if(quant > 1) {
                    Console.WriteLine("Foram " + quant + " Cachorros quentes, certo? A conta deu R$ " + contaSuco);
                } else{
                    Console.WriteLine("Foi apenas " + quant + " Cachorro quente, certo? A conta deu R$ " + contaSuco);
                }
                break;

                default:
                Console.WriteLine("Não temos esse item no menu");
                break;
            }
        }

        // This method gets a number(valor or value), then it will return how many bills will be needed to get to this number
        public static void programaNotas(int valor) {

            int quantCem = 0;
            int quantCinquenta = 0;
            int quantVinteCinco = 0;
            int quantDez = 0;
            int quantCinco = 0;
            int quantUm = 0;
            int newValor = 0;
            while(valor >= 100) {
                quantCem++;
                newValor = valor - 100;
                valor = newValor;
            }
            while(valor >= 50) {
                quantCinquenta++;
                newValor = valor - 50;
                valor = newValor;
            }
            while(valor >= 25) {
                quantVinteCinco++;
                newValor = valor - 25;
                valor = newValor;
            }
            while(valor >= 10) {
                quantDez++;
                newValor = valor - 10;
                valor = newValor;
            }
            while(valor >= 5) {
                quantCinco++;
                newValor = valor - 5;
                valor = newValor;
            }
            while(valor >= 1) {
                quantUm++;
                newValor = valor - 1;
                valor = newValor;
            }
            // valor = 179, Return: It was needed 1 $100 bill(s), 1 $50 bill(s), 1 $25 bill(s), 0 $10 bill(s), 0 $5 bill(s) and 4 $1 bill(s).
            Console.WriteLine("Deu(deram) " + quantCem + " nota(s) de 100 reais, \n" + quantCinquenta + " nota(s) de 50 reais,\n" + quantVinteCinco + " nota(s) de 25 reais,");
            Console.WriteLine(quantDez + " nota(s) de 10 reais, \n" + quantCinco + " nota(s) de 5 reais \n" + "E deu(deram) " + quantUm + " nota(s) de 1 real");
            
        }
    }
}