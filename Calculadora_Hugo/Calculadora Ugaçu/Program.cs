﻿using System;

namespace CalUgaçu
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Bem vindo, este programa simula uma calculadora"); //Teste
			Alterna();
		}

		private static void Alterna()
		{
			Console.WriteLine("Digite qual das quatro operação deseja deseja");
			string s = Console.ReadLine();

			switch (s.ToLower())            //Converte todos os caracteres da String recebida em minusculos     
			{
				case "adição":
					Adição();
					break;
				case "subtração":
					Subtração();
					break;
				case "multiplicação":
					Multiplicação();
					break;
				case "divisão":
					Divisão();
					break;
				case "porcentagem":
					Porcentagem();
					break;
				case "fibonacci":
					Fibonacci();
					break;
				case "fim":
					break;
				default:
					Console.WriteLine("Erro, digite novamente");
					Alterna();
					break;
			}
		}

		private static void Adição()
		{
			int[] inteiros = new int[3];                                // Posição 0 e 1 são os números inteiros, a 2 é a resposta
			Console.WriteLine("Digite os números para a operação");
			inteiros[0] = Convert.ToInt32(Console.ReadLine());          // Obtem o número inteiro
			inteiros[1] = Convert.ToInt32(Console.ReadLine());          // Obtem o número inteiro
			inteiros[2] = inteiros[0] + inteiros[1];
			Console.WriteLine("Sua resposta " + inteiros[2]);
			Console.WriteLine("Deseja efetuar outra operação?");
			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}

		private static void Subtração()
		{
			int[] inteiros = new int[3];                                        //Posição 0 subtraendo, 1 subtrator e 2 resposta
			Console.WriteLine("Digite os números para a operação, primeiro o subtraendo depois o subtrator");
			inteiros[0] = Convert.ToInt32(Console.ReadLine());                  // Obtem o Subtraendo
			inteiros[1] = Convert.ToInt32(Console.ReadLine());                  // Obtem o Subtrator
			inteiros[2] = inteiros[0] - inteiros[1];
			Console.WriteLine("Sua resposta " + inteiros[2]);
			Console.WriteLine("Deseja efetuar outra operação?");

			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}

		private static void Multiplicação()
		{
			int[] inteiros = new int[3];                                    //Posição 0 e 1 são inteiros, 2 é a resposta
			Console.WriteLine("Digite os números para a operação ");
			inteiros[0] = Convert.ToInt32(Console.ReadLine());              // Obtem o número inteiro
			inteiros[1] = Convert.ToInt32(Console.ReadLine());              // Obtem o número inteiro
			inteiros[2] = inteiros[0] * inteiros[1];
			Console.WriteLine("Sua resposta " + inteiros[2]);
			Console.WriteLine("Deseja efetuar outra operação?");
			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}

		private static void Divisão()
		{
			double[] reais = new double[3];                                 // Posição 0 dividendo, 1 divisor, 3 resposta
			Console.WriteLine("Digite os números para a operação, primeiro o dividendo, depois o divisor ");
			reais[0] = Convert.ToDouble(Console.ReadLine());                //Obtem o número para o Dividendo
			reais[1] = Convert.ToDouble(Console.ReadLine());                //Obtem o número para o Divisor
			while (reais[1] == 0)                                           //Caso o divisor seja zero é pedido um valor válido
			{
				Console.WriteLine("Erro matemático, o divisor deve ser diferente de 0");
				Console.WriteLine("Favor inserir um novo valor para o divisor");
				reais[1] = Convert.ToDouble(Console.ReadLine());
			}
			reais[2] = reais[0] / reais[1];
			Console.WriteLine("Sua resposta " + reais[2]);
			Console.WriteLine("Deseja efetuar outra operação?");
			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}
		private static void Porcentagem()
		{
			double[] reais = new double[3];
			Console.WriteLine("Igite primeiro a porcentagem desejada, depois o número desejado");
			reais[0] = Convert.ToDouble(Console.ReadLine()) / 100;
			reais[1] = Convert.ToDouble(Console.ReadLine());
			reais[2] = reais[0] * reais[1];
			Console.WriteLine("Sua resposta " + reais[2]);
			Console.WriteLine("Deseja efetuar outra operação?");
			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}
		private static void Fibonacci()
		{
			int a, b, c, d, e;
			Console.WriteLine("Digite quantos números da sequência deseja");

			a = 0;
			b = 1;
			d = 0;
			e = Convert.ToInt32(Console.ReadLine());
			do
			{
				Console.WriteLine("Sua resposta " + a);
				c = a + b;
				a = b;
				b = c;
				d++;
			} while (d < e);
			Console.WriteLine("Deseja efetuar outra operação?");
			string s = Console.ReadLine();
			if (s.ToLower() == "sim")
			{
				Alterna();
			}
		}
	}
}
