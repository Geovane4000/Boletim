// Boletim de notas para 5 alunos exibindo quais estão aprovados ou reprovados, considerando a média de 5.0 para aprovação.
﻿using System;
using System.Collections.Generic;

// Define a class to represent a student
class Aluno
{
	public string Nome { get; set; }
	public double Nota { get; set; }
}



class Program
{
	static void Main()
	{
		List<Aluno> alunos = new List<Aluno>();
		for (int i = 0; i < 5; i++)
		{
			Console.WriteLine($"Digite o nome do aluno {i + 1}:");
			string nome = Console.ReadLine();
			Console.WriteLine($"Digite a nota do aluno {nome}:");
			double nota;
			while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
			{
				Console.WriteLine("Nota inválida. Digite uma nota entre 0 e 10:");
			}
			alunos.Add(new Aluno { Nome = nome, Nota = nota });
		}
		Console.WriteLine("\nBoletim de Notas:");
		foreach (var aluno in alunos)
		{
			string status = aluno.Nota >= 5.0 ? "Aprovado" : "Reprovado";
			Console.WriteLine($"{aluno.Nome}: {aluno.Nota} - {status}");
		}
	}
}










