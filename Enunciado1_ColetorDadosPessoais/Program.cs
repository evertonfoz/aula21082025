// Importa o namespace System, que contém funcionalidades básicas como o Console.
// É como o #include <stdio.h> em C.
using System;
// Importa o namespace para lidar com globalização, essencial para converter números com ponto.
using System.Globalization;

// Em C#, todo código executável precisa estar dentro de uma classe.
// Por enquanto, não se preocupe com o que é "class", apenas saiba que nosso código principal
// ficará dentro do método Main.
class Program
{
    // O método Main é o ponto de entrada do nosso programa, assim como em C.
    static void Main(string[] args)
    {
        // --- 1. Declaração de Variáveis ---
        // Em C#, declaramos variáveis de forma parecida com C: tipo nome;
        string primeiroNome;
        int idade;
        float altura;

        // --- 2. Coleta de Dados ---
        // Usamos Console.WriteLine para exibir mensagens ao usuário (similar ao printf).
        Console.WriteLine("--- Coletor de Dados Pessoais ---");

        Console.Write("Digite seu primeiro nome: ");
        // Console.ReadLine() lê a linha inteira que o usuário digita e sempre retorna uma string.
        primeiroNome = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        // Como ReadLine() retorna uma string, precisamos converter ("parse") para um inteiro.
        // O int.Parse() faz exatamente isso. Se o usuário digitar "abc", dará um erro.
        idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua altura em metros (ex: 1.75): ");
        // O mesmo vale para float. Usamos float.Parse().
        // CultureInfo.InvariantCulture é importante para garantir que o ponto "." seja
        // reconhecido como separador decimal, independentemente da configuração do sistema operacional.
        // No Brasil, o padrão é a vírgula ",", o que poderia causar erros.
        altura = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // --- 3. Exibição dos Resultados ---
        // Esta é a "interpolação de strings".
        // O $ no início da string permite que coloquemos variáveis diretamente dentro dela
        // usando chaves {}. É uma forma muito mais limpa e moderna do que o printf de C.
        Console.WriteLine($"\n--- Dados Coletados ---");
        Console.WriteLine($"Olá, {primeiroNome}! Você tem {idade} anos e mede {altura:F2}m de altura.");
        // A formatação :F2 dentro da variável altura significa "formate como um número de
        // ponto flutuante com 2 casas decimais".
    }
}