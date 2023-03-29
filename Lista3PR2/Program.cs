using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int program;

            Console.WriteLine("escreva o numero do exercicio: ");
            program = int.Parse(Console.ReadLine());

            switch (program)
            {
                case 1:
                    int d;

                    Console.WriteLine("\n" + "exercicio 1 \n");
                    Console.WriteLine("escreva um numero de 1 a 7: ");
                    d = int.Parse(Console.ReadLine());

                    switch (d)
                    {
                        case 1:
                            Console.WriteLine("\n" + "o dia correspondente é domingo \n");
                            break;

                        case 2:
                            Console.WriteLine("\n" + "o dia correspondente é igual à segunda-feira \n");
                            break;
                        case 3:
                            Console.WriteLine("\n" + "o dia correspondente é igual à terça-feira \n");
                            break;
                        case 4:
                            Console.WriteLine("\n" + "o dia correspondente é igual à quarta-feira \n");
                            break;
                        case 5:
                            Console.WriteLine("\n" + "o dia correspondente é igual à quinta-feira \n");
                            break;
                        case 6:
                            Console.WriteLine("\n" + "o dia correspondente é igual à sexta-feira \n");
                            break;
                        case 7:
                            Console.WriteLine("\n" + "o dia correspondente é igual à sábado \n");
                            break;
                        default:
                            Console.WriteLine("\n" + "numero inválido!\n");
                            break;

                    }
                    break;

                case 2:
                    double v, p, vt;

                    Console.WriteLine("\nexercicio 2\n");
                    Console.WriteLine("\nQual o valor da compra? \n");
                    v = double.Parse(Console.ReadLine());
                    Console.WriteLine("\nQual o método de pagamento? \n 1- dinheiro; \n 2- pix; \n 3- cartão de Débito; \n 4- cartão de crédito.\n");
                    p = double.Parse(Console.ReadLine());

                    switch (p)
                    {
                        case 1:
                            vt = v * 0.85;
                            Console.WriteLine("O valor total é igual à: " + vt);
                            break;

                        case 2:
                            vt = v * 0.90;
                            Console.WriteLine("O valor total é igual à: " + vt);
                            break;

                        case 3:
                            vt = v * 1.05;
                            Console.WriteLine("O valor total é igual à: " + vt);
                            break;

                        case 4:
                            vt = v * 1.10;
                            Console.WriteLine("O valor total é igual à: " + vt);
                            break;

                        default:
                            Console.WriteLine("opção invalida!");
                            break;
                    }
                    break;

                case 3:
                    int m;
                    string ab;

                    Console.WriteLine("o ano é bissexto?");
                    ab = Console.ReadLine();

                    if (ab == "sim")
                    {
                        Console.WriteLine("escreva o numero do mês: ");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("o mês é janeiro e ele tem 31 dias");
                                break;
                            case 2:
                                Console.WriteLine("o mês é fevereiro e ele tem 29 dias");
                                break;
                            case 3:
                                Console.WriteLine("o mês é março e ele tem 31 dias");
                                break;
                            case 4:
                                Console.WriteLine("o mês é abril e ele tem 30 dias");
                                break;
                            case 5:
                                Console.WriteLine("o mês é maio e ele tem 31 dias");
                                break;
                            case 6:
                                Console.WriteLine("o mês é junho e ele tem 30 dias");
                                break;
                            case 7:
                                Console.WriteLine("o mês é julho e ele tem 31 dias");
                                break;
                            case 8:
                                Console.WriteLine("o mês é agosto e ele tem 31 dias");
                                break;
                            case 9:
                                Console.WriteLine("o mês é setembro e ele tem 30 dias");
                                break;
                            case 10:
                                Console.WriteLine("o mês é outubro e ele tem 31 dias");
                                break;
                            case 11:
                                Console.WriteLine("o mês é novembro e ele tem 30 dias");
                                break;
                            case 12:
                                Console.WriteLine("o mês é dezembro e ele tem 31 dias");
                                break;
                            default:
                                Console.WriteLine("opção invalida!");
                                break;

                        }
                    }

                    else
                    {
                        Console.WriteLine("escreva o numero do mês: ");
                        m = int.Parse(Console.ReadLine());

                        switch (m)
                        {
                            case 1:
                                Console.WriteLine("o mês é janeiro e ele tem 31 dias");
                                break;
                            case 2:
                                Console.WriteLine("o mês é fevereiro e ele tem 28 dias");
                                break;
                            case 3:
                                Console.WriteLine("o mês é março e ele tem 31 dias");
                                break;
                            case 4:
                                Console.WriteLine("o mês é abril e ele tem 30 dias");
                                break;
                            case 5:
                                Console.WriteLine("o mês é maio e ele tem 31 dias");
                                break;
                            case 6:
                                Console.WriteLine("o mês é junho e ele tem 30 dias");
                                break;
                            case 7:
                                Console.WriteLine("o mês é julho e ele tem 31 dias");
                                break;
                            case 8:
                                Console.WriteLine("o mês é agosto e ele tem 31 dias");
                                break;
                            case 9:
                                Console.WriteLine("o mês é setembro e ele tem 30 dias");
                                break;
                            case 10:
                                Console.WriteLine("o mês é outubro e ele tem 31 dias");
                                break;
                            case 11:
                                Console.WriteLine("o mês é novembro e ele tem 30 dias");
                                break;
                            case 12:
                                Console.WriteLine("o mês é dezembro e ele tem 31 dias");
                                break;
                            default:
                                Console.WriteLine("opção invalida!");
                                break;

                        }
                    }
                    break;

                case 4:
                    int a, b, r;
                    char ca;

                    Console.WriteLine("escreva um valor A: ");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("escreva um valor B: ");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine("escreva uma operação: ");
                    ca = char.Parse(Console.ReadLine());
                    switch (ca)
                    {
                        case '+':
                            Console.WriteLine(a + b);
                            break;

                        case '-':
                            Console.WriteLine(a - b);
                            break;

                        case '*':
                            Console.WriteLine(a * b);
                            break;

                        case '/':
                            Console.WriteLine(a / b);
                            break;

                        default:
                            Console.WriteLine("opção invalida!");
                            break;
                    }

                    break;

                case 5:

                    double c, sa, s, dif;

                    Console.WriteLine("digite o numero de seu cargo: ");
                    c = double.Parse(Console.ReadLine());
                    Console.WriteLine("digite o seu salário: ");
                    sa = double.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 101:
                            s= sa * 1.075;
                            dif = s % sa;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 102:
                            s = sa * 1.097;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 103:
                            s = sa * 1.117;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 204:
                            s = sa * 1.089;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 206:
                            s = sa * 1.1324;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 301:
                            s = sa * 1.104;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;

                        case 302:
                            s = sa * 1.146;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;
                        default:
                            s = sa * 1.435;
                            dif = sa % s;
                            Console.WriteLine("O salário antigo era: R$" + sa + ", o salario novo é: R$" + s + " e a diferença é: R$" + dif);
                            break;
                    }
                    break;

                case 6:
                    double sA, sl, imp;

                    Console.WriteLine("informe o seu salário:");
                    sA = double.Parse(Console.ReadLine());

                    if (sA < 1903.98)
                    {
                        Console.WriteLine("seu salário está isento de imposto");
                    }
                    else if (sA >= 1903.99 && sA <= 2826.65)
                    {
                        sl = sA - sA * 0.075;
                        imp = sA % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else if (sA >= 2826.66 && sA <= 3751.05)
                    {
                        sl = sA - sA * 0.15;
                        imp = sA % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else if (sA >= 3751.06 && sA <= 4664.68)
                    {
                        sl = sA - sA * 0.225;
                        imp = sA % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    else
                    {
                        sl = sA - sA * 0.275;
                        imp = sA % sl;
                        Console.WriteLine("o seu salario liquido é de: R$" + sl + " e o imposto foi de: R$" + imp);
                    }
                    break;


                default:
                    Console.WriteLine("opção invalida!");
                    break;
            }
        }
    }
}