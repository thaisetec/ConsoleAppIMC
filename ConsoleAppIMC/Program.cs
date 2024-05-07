using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string[] nome = new string[5];
                double[] peso = new double[5];
                double[] altura = new double[5];
                double[] imc = new double[5];
                int acimapeso = 0;
            int saud = 0;

               
                for (int i = 0; i < 5; i++)
                {
                Console.WriteLine($"Digite o nome da {i+1} pessoa:");
                nome[i] = Console.ReadLine();

                Console.WriteLine($"Digite o peso da {i + 1} pessoa:");
                peso[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Digite a altura da {i + 1}  pessoa:");
                altura[i]= Convert.ToDouble(Console.ReadLine());


                }



            for (int i = 0; i <= 5; i++)
            {
                Console.ReadKey();
                Console.WriteLine($"Nome: " + nome[i]);
            Console.WriteLine($"Peso: " + peso[i]);
            Console.WriteLine($"Altura: " + altura[i]);
            Console.WriteLine($"IMC:" + (peso[i] / (altura[i] * altura[i])));

               if ((peso[i] / (altura[i] * (altura[i]))) < 18.5) { Console.WriteLine("abaixo do peso ideal");saud++; }
               else if ((peso[i] / (altura[i] * altura[i])) < 24.9) { Console.WriteLine("peso ideal");saud++; }
               else if ((peso[i] / (altura[i] * altura[i])) < 29.9) { Console.WriteLine("levemente acima do peso ideal");acimapeso++; }
               else if ((peso[i] / (altura[i] * altura[i])) < 34.9) { Console.WriteLine("obesidade I"); acimapeso++; }
               else if ((peso[i] / (altura[i] * altura[i])) < 39.9) { Console.WriteLine("obesidade II"); acimapeso++; }
               else Console.WriteLine("obesidade III");acimapeso++;
            }
            double Acimapeso = 0;
            double normal = 0;
            Acimapeso = 100 * (acimapeso / 5);
            normal = 100 * (saud / 5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("a porcentagem de pessoas acima do peso é de" + Acimapeso);
                Console.WriteLine("a porcentagem de pessoas com o peso indicado é de" + normal);
            }
            Console.ReadKey();


            }
        }
    }

    

