using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace Dashboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //Informações padrões:
            string loja = "Tip-ti"; // Nome da loja
            int vendas = 0; // Número de vendas do dia
            double valorvendido = 0.00; // Valor total de vendas do dia
            //COMIDAS
            string comida1 = "X-Tudo"; //COMIDA 1
            string comida2 = $"{loja}Cheddar"; //COMIDA 2 (empõe o nome da sua loja)
            string comida3 = "X-Salada"; //COMIDA 3
            string comida4 = "X-Burguer"; //COMIDA 4
            string comida5 = "X-Egg"; //COMIDA 5
            //BEBIDAS
            string bebida1 = "Suco de laranja"; //BEBIDA 1
            string bebida2 = "Fanta uva"; //BEBIDA2
            string bebida3 = "Guaraná"; //BEBIDA3
            string bebida4 = "Suco de morango"; //BEBIDA4
            string bebida5 = "Água"; //BEBIDA5
            //VALORES DAS COMIDAS
            double valorcomida1 = 23.99;
            double valorcomida2 = 17.99;
            double valorcomida3 = 13.99;
            double valorcomida4 = 11.99;
            double valorcomida5 = 15.99;
            //VALORES DAS BEBIDAS
            double valorbebida1 = 7.99;
            double valorbebida2 = 4.99;
            double valorbebida3 = 4.99;
            double valorbebida4 = 7.99;
            double valorbebida5 = 4.99;
            //ESTOQUE DE COMIDAS
            int stockcomida1 = 5;
            int stockcomida2 = 3;
            int stockcomida3 = 2;
            int stockcomida4 = 1;
            int stockcomida5 = 7;
            //ESTOQUE DAS BEBIDAS
            int stockbebida1 = 7;
            int stockbebida2 = 3;
            int stockbebida3 = 6;
            int stockbebida4 = 9;
            int stockbebida5 = 10;
            //CLIENTES
            string cliente1 = "Arthur Moraes";
            string cliente2 = "Janne Holmes";
            string cliente3 = "Manuela lemos";
            string cliente4 = "Raissa Cardoso";
            //VENDEDORES
            int funcionarios = 1;

            //TITULOS DA PAGINA 
            string tituloinicio = "Central de vendas";

            //CODIGO COMPLETO + TITULO
            Console.Title = $"{tituloinicio} - {loja}";
            Console.WriteLine($"Olá, seja-bem vindo ao painel da loja {loja} ");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.Clear();
            Inicio:
            Console.WriteLine("O Que você deseja fazer?");
            Console.WriteLine("1. Entrar no sistema de funcionário");
            Console.WriteLine("3. Sair");
            Console.WriteLine();
            Console.Write("Digite aqui:"); int escolha = int.Parse(Console.ReadLine());
            if (escolha == 3)
            {
                Console.Clear();

            }
            if (escolha == 1)
            {
                Console.Clear();
                Console.WriteLine("Entrando no sistema...");
                Thread.Sleep(3000);
                Console.WriteLine("Preencha as seguintes informações:");
                Console.Write("Nome:"); string nome = Console.ReadLine();
                Console.Write("Sobrenome:"); string sobrenome = (Console.ReadLine());
                Console.Write("Idade:"); int idade = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Armazenando dados de {nome}...");
                Thread.Sleep(2000);
                Console.WriteLine($"Certo! {nome} tem {idade} anos.");
                Thread.Sleep(3000);
                Console.WriteLine($"Vinculação de dados concluída!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine($"Olá, {nome!}, vamos finalizar seu catálogo na loja {loja} para que você possa começar a vender.");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine($"{loja} não contrata qualquer um, então, nos responda a primeira pergunta:");
                Console.WriteLine();
                //FORMA COMO VAI ATENDER:
                Console.WriteLine($"Qual a melhor forma de você atender seus clientes na loja {loja}? (Em poucas palavras!)");
                Console.Write("Bom.. eu vou:"); string formadeatender = Console.ReadLine();
                Thread.Sleep(2000);
                Console.Clear();
                if (idade < 18)
                {
                    //REPROVADO
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Infelizmente, você foi reprovado na entrevista de serviço da loja {loja}.");
                    Console.WriteLine("Tente novamente outra hora.");
                    Thread.Sleep(90000);
                }
                else
                {
                    //APROVADO
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"Parabéns {nome} {sobrenome}! Você está Aprovado na entrevista de serviço da loja {loja} e já pode iniciar suas vendas!");
                    Thread.Sleep(5000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                //PAINEL DE VENDAS
                PainelDeVendas:
                    Console.Clear();
                    Console.WriteLine($"Painel de vendas da loja {loja}!");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine($"Informações:");
                    Console.WriteLine();
                    Console.WriteLine($"Vendas hoje: {vendas} ");
                    Console.WriteLine($"Valor vendido em produtos: R$ {valorvendido} ");
                    Console.WriteLine($"Total de funcionários trabalhando em {loja}: {funcionarios} ");
                    Console.WriteLine();
                    Console.WriteLine("Comidas:");
                    Console.WriteLine($"Estoque de {comida1}: {stockcomida1}");
                    Console.WriteLine($"Estoque de {comida2}: {stockcomida2}");
                    Console.WriteLine($"Estoque de {comida3}: {stockcomida3}");
                    Console.WriteLine($"Estoque de {comida4}: {stockcomida4}");
                    Console.WriteLine($"Estoque de {comida5}: {stockcomida5}");
                    Console.WriteLine();
                    Console.WriteLine("Bebidas:");
                    Console.WriteLine($"Estoque de {bebida1}: {stockbebida1}");
                    Console.WriteLine($"Estoque de {bebida2}: {stockbebida2}");
                    Console.WriteLine($"Estoque de {bebida3}: {stockbebida3}");
                    Console.WriteLine($"Estoque de {bebida4}: {stockbebida4}");
                    Console.WriteLine($"Estoque de {bebida5}: {stockbebida5}");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("O Que você deseja fazer?");
                    Console.WriteLine();
                    Console.WriteLine("1. Alterar estoque de comidas/bebidas ");
                    Console.WriteLine("2. Alterar valores das comidas/bebidas ");
                    Console.WriteLine("3. Mudar nome das comidas/bebidas");
                    Console.WriteLine("4. Realizar vendas de comidas/bebidas");
                    Console.WriteLine("5. Alterar nome da loja");
                    Console.WriteLine("6. Comprar funcionários para a empresa");
                    Console.WriteLine();
                    int escolha2 = int.Parse(Console.ReadLine());
                    //SELECIONANDO PRODUTO
                    if (escolha2 == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual produto você deseja adicionar estoque?");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("COMIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"1. {comida1}");
                        Console.WriteLine($"2. {comida2}");
                        Console.WriteLine($"3. {comida3}");
                        Console.WriteLine($"4. {comida4}");
                        Console.WriteLine($"5. {comida5}");
                        Console.WriteLine();
                        Console.WriteLine("BEBIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"6. {bebida1}");
                        Console.WriteLine($"7. {bebida2}");
                        Console.WriteLine($"8. {bebida3}");
                        Console.WriteLine($"9. {bebida4}");
                        Console.WriteLine($"10. {bebida5}");
                        Console.WriteLine();
                        Console.Write("Produto N:"); int escolhaestoque = int.Parse(Console.ReadLine());
                        //ADICIONANDO ESTOQUE NA ESCOLHA
                        if (escolhaestoque == 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {comida1}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockcomida1}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {comida1}:"); stockcomida1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida1} tem {stockcomida1} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {comida2}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockcomida2}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {comida2}:"); stockcomida2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida2} tem {stockcomida2} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 3)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {comida3}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockcomida3}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {comida3}:"); stockcomida3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida3} tem {stockcomida3} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 4)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {comida4}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockcomida4}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {comida4}:"); stockcomida4 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida4} tem {stockcomida4} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 5)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {comida5}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockcomida5}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {comida5}:"); stockcomida5 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida5} tem {stockcomida5} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 6)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {bebida1}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockbebida1}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {bebida1}:"); stockbebida1 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida1} tem {stockbebida1} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 7)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {bebida2}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockbebida2}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {bebida2}:"); stockbebida2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida2} tem {stockbebida2} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 8)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {bebida3}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockbebida3}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {bebida3}:"); stockbebida3 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida3} tem {stockbebida3} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 9)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {bebida4}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockbebida4}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {bebida4}:"); stockbebida4 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida4} tem {stockbebida4} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhaestoque == 10)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual a quantidade que você deseja deixar em {bebida5}?");
                            Console.WriteLine();
                            Console.WriteLine($"Quantidade atual: {stockbebida5}");
                            Console.WriteLine();
                            Console.Write($"Quantidade de stock em {bebida5}:"); stockbebida5 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida5} tem {stockbebida5} em seu estoque!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                    }
                    if (escolha2 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Veja abaixo a tabela de valores de cada coisa produto e escolha qual alterar de acordo com a numeração:");
                        Console.WriteLine("COMIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"1. {comida1} : {valorcomida1}");
                        Console.WriteLine($"2. {comida2} : {valorcomida2}");
                        Console.WriteLine($"3. {comida3} : {valorcomida3}");
                        Console.WriteLine($"4. {comida4} : {valorcomida4}");
                        Console.WriteLine($"5. {comida5} : {valorcomida5}");
                        Console.WriteLine();
                        Console.WriteLine("BEBIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"6. {bebida1} : {valorbebida1}");
                        Console.WriteLine($"7. {bebida2} : {valorbebida2}");
                        Console.WriteLine($"8. {bebida3} : {valorbebida3}");
                        Console.WriteLine($"9. {bebida4} : {valorbebida4}");
                        Console.WriteLine($"10.{bebida5} : {valorbebida5}");
                        Console.WriteLine();
                        Console.Write("Produto N:"); double escolhavalor = double.Parse(Console.ReadLine());
                        if (escolhavalor == 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {comida1}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorcomida1 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida1} tem {valorcomida1} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {comida2}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorcomida2 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida2} tem {valorcomida2} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 3)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {comida3}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorcomida3 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida3} tem {valorcomida3} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 4)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {comida4}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorcomida4 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida4} tem {valorcomida4} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 5)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {comida5}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorcomida5 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {comida5} tem {valorcomida5} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 6)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {bebida1}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorbebida1 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida1} tem {valorbebida1} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 7)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {bebida2}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorbebida2 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida2} tem {valorbebida2} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 8)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {bebida3}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorbebida3 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida3} tem {valorbebida3} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 9)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {bebida4}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorbebida4 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida4} tem {valorbebida4} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhavalor == 10)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o valor que você deseja em {bebida5}?");
                            Console.WriteLine();
                            Console.Write($"Valor:"); valorbebida5 = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine($"Agora {bebida5} tem {valorbebida5} como valor.");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }

                    }
                    if (escolha2 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Veja abaixo a tabela de nomes e valores dos produtos.");
                        Console.WriteLine("COMIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"1. {comida1} : {valorcomida1}");
                        Console.WriteLine($"2. {comida2} : {valorcomida2}");
                        Console.WriteLine($"3. {comida3} : {valorcomida3}");
                        Console.WriteLine($"4. {comida4} : {valorcomida4}");
                        Console.WriteLine($"5. {comida5} : {valorcomida5}");
                        Console.WriteLine();
                        Console.WriteLine("BEBIDAS:");
                        Console.WriteLine();
                        Console.WriteLine($"6. {bebida1} : {valorbebida1}");
                        Console.WriteLine($"7. {bebida2} : {valorbebida2}");
                        Console.WriteLine($"8. {bebida3} : {valorbebida3}");
                        Console.WriteLine($"9. {bebida4} : {valorbebida4}");
                        Console.WriteLine($"10.{bebida5} : {valorbebida5}");
                        Console.WriteLine();
                        Console.Write("Produto N:"); int escolhanome = int.Parse(Console.ReadLine());
                        if (escolhanome == 1)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {comida1}?");
                            Console.Clear();
                            Console.Write("Nome:"); comida1 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {comida1}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {comida2}?");
                            Console.Clear();
                            Console.Write("Nome:"); comida2 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {comida1}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 3)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {comida3}?");
                            Console.Clear();
                            Console.Write("Nome:"); comida3 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {comida3}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 4)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {comida4}?");
                            Console.Clear();
                            Console.Write("Nome:"); comida4 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {comida4}");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 5)
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {comida5}?");
                            Console.Clear();
                            Console.Write("Nome:"); comida5 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {comida5}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 6) //BEBIDAS NOME1
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {bebida1}?");
                            Console.Clear();
                            Console.Write("Nome:"); bebida1 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {bebida1}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 7) //BEBIDAS NOME2
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {bebida2}?");
                            Console.Clear();
                            Console.Write("Nome:"); bebida2 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {bebida2}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 8) //BEBIDAS NOME3
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {bebida3}?");
                            Console.Clear();
                            Console.Write("Nome:"); bebida3 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {bebida3}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 9) //BEBIDAS NOME4
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {bebida4}?");
                            Console.Clear();
                            Console.Write("Nome:"); bebida4 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {bebida4}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                        if (escolhanome == 10) //BEBIDAS NOME4
                        {
                            Console.Clear();
                            Console.WriteLine($"Qual o nome que você deseja em {bebida5}?");
                            Console.Clear();
                            Console.Write("Nome:"); bebida5 = Console.ReadLine();
                            Console.WriteLine($"Agora o produto se chama {bebida5}!");
                            Thread.Sleep(2000);
                            goto PainelDeVendas;
                        }
                    }
                    if (escolha2 == 4)
                    {
                        Console.Clear();
                        Console.WriteLine($"{nome}: Vamos realizar algumas vendas...");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Escolha com qual cliente falar:");
                        Console.WriteLine();
                        Console.WriteLine($"1. {cliente1}");
                        Console.WriteLine($"2. {cliente2}");
                        Console.WriteLine($"3. {cliente3}");
                        Console.WriteLine($"4. {cliente4}");
                        int escolhavendas1 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (escolhavendas1 == 1)
                        {
                            Console.WriteLine($"{nome}: Olá {cliente1}, o que você deseja aqui na {loja}?");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{cliente1}: Eu acho que hoje vou querer {comida3}, acompanhado de {bebida4}");
                            //VERIFICANDO SE TEM ESTOQUE
                            if (stockcomida3 < 1)
                            {
                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {comida3}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            if (stockbebida4 < 1)
                            {

                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {bebida4}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                Console.WriteLine($"{nome}: Ok, você poderia efetuar o pagamento por favor?");
                                Thread.Sleep(2000);
                                double valorvendacliente = valorcomida3 + valorbebida4;
                                Console.WriteLine($"{cliente1}: Pronto, lhe enviei o pagamento no valor de R$ {valorvendacliente}.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                Thread.Sleep(2000);
                                int valortotaldevendasdodia = vendas + 1;
                                Console.WriteLine($"Vendas -> {vendas} agora é {valortotaldevendasdodia}.");
                                double valorvendidododia = valorvendido + valorvendacliente;
                                Console.WriteLine($"Valor das vendas -> {valorvendido} agora é {valorvendidododia}.");
                                vendas = valortotaldevendasdodia;
                                valorvendido = valorvendidododia;
                                stockbebida4 = stockbebida4 - 1;
                                stockcomida3 = stockcomida3 - 1;
                                Thread.Sleep(5000);
                                goto PainelDeVendas;
                            }
                        }
                        if (escolhavendas1 == 2)
                        {
                            Console.WriteLine($"{nome}: Olá {cliente2}, o que você deseja aqui na {loja}?");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{cliente2}: Eu acho que hoje vou querer {comida1}, acompanhado de {bebida5}");
                            //VERIFICANDO SE TEM ESTOQUE
                            if (stockcomida1 < 1)
                            {
                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {comida1}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            if (stockbebida5 < 1)
                            {

                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {bebida5}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                Console.WriteLine($"{nome}: Ok, você poderia efetuar o pagamento por favor?");
                                Thread.Sleep(2000);
                                double valorvendacliente = valorcomida1 + valorbebida5;
                                Console.WriteLine($"{cliente1}: Pronto, lhe enviei o pagamento no valor de R$ {valorvendacliente}.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                int valortotaldevendasdodia = vendas + 1;
                                Console.WriteLine($"Vendas -> {vendas} agora é {valortotaldevendasdodia}.");
                                double valorvendidododia = valorvendido + valorvendacliente;
                                Console.WriteLine($"Valor das vendas -> {valorvendido} agora é {valorvendidododia}.");
                                vendas = valortotaldevendasdodia;
                                valorvendido = valorvendidododia;
                                stockbebida5 = stockbebida5 - 1;
                                stockcomida1 = stockcomida1 - 1;
                                Thread.Sleep(5000);
                                goto PainelDeVendas;
                            }
                        }
                        if (escolhavendas1 == 3)
                        {
                            Console.WriteLine($"{nome}: Olá {cliente3}, o que você deseja aqui na {loja}?");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{cliente3}: Eu acho que hoje vou querer {comida2}, acompanhado de {bebida1}");
                            //VERIFICANDO SE TEM ESTOQUE
                            if (stockcomida2 < 1)
                            {
                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {comida2}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            if (stockbebida1 < 1)
                            {

                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {bebida1}.");
                                Thread.Sleep(2000);
                                goto PainelDeVendas;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                Console.WriteLine($"{nome}: Ok, você poderia efetuar o pagamento por favor?");
                                Thread.Sleep(2000);
                                double valorvendacliente = valorcomida2 + valorbebida1;
                                Console.WriteLine($"{cliente1}: Pronto, lhe enviei o pagamento no valor de R$ {valorvendacliente}.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                int valortotaldevendasdodia = vendas + 1;
                                Console.WriteLine($"Vendas -> {vendas} agora é {valortotaldevendasdodia}.");
                                double valorvendidododia = valorvendido + valorvendacliente;
                                Console.WriteLine($"Valor das vendas -> {valorvendido} agora é {valorvendidododia}.");
                                vendas = valortotaldevendasdodia;
                                valorvendido = valorvendidododia;
                                stockbebida1 = stockbebida1 - 1;
                                stockcomida2 = stockcomida2 - 1;
                                Thread.Sleep(5000);
                                goto PainelDeVendas;
                            }
                        }
                        if (escolhavendas1 == 4)
                        {
                            Console.WriteLine($"{nome}: Olá {cliente4}, o que você deseja aqui na {loja}?");
                            Thread.Sleep(2000);
                            Console.WriteLine($"{cliente4}: Eu acho que hoje vou querer {comida5}, acompanhado de {bebida3}.");
                            //VERIFICANDO SE TEM ESTOQUE
                            if (stockcomida5 < 1)
                            {
                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {comida5}.");
                                Thread.Sleep(3000);
                                goto PainelDeVendas;
                            }
                            if (stockbebida3 < 1)
                            {

                                Console.WriteLine($"{nome}: Sentimos muito, mas não temos mais estoque de {bebida3}.");
                                Thread.Sleep(3000);
                                goto PainelDeVendas;
                            }
                            else
                            {
                                Thread.Sleep(2000);
                                Console.WriteLine($"{nome}: Ok, você poderia efetuar o pagamento por favor?");
                                Thread.Sleep(2000);
                                double valorvendacliente = valorcomida5 + valorbebida3;
                                Console.WriteLine($"{cliente4}: Pronto, lhe enviei o pagamento no valor de R$ {valorvendacliente}.");
                                Thread.Sleep(2000);
                                Console.Clear();
                                int valortotaldevendasdodia = vendas + 1;
                                Console.WriteLine($"Vendas -> {vendas} agora é {valortotaldevendasdodia}.");
                                double valorvendidododia = valorvendido + valorvendacliente;
                                Console.WriteLine($"Valor das vendas -> {valorvendido} agora é {valorvendidododia}.");
                                vendas = valortotaldevendasdodia;
                                valorvendido = valorvendidododia;
                                stockbebida3 = stockbebida3 - 1;
                                stockcomida5 = stockcomida5 - 1;
                                Thread.Sleep(5000);
                                goto PainelDeVendas;
                            }
                        }
;

                    }
                    if (escolha2 == 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Qual será o novo nome da loja?");
                        Console.WriteLine();
                        Console.Write("Novo nome:"); loja = Console.ReadLine();
                        Console.Title = $"{tituloinicio} - {loja}";
                        goto PainelDeVendas;
                    }
                    if (escolha2 == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Você quer comprar um funcionário por R$ 50,00? Digite um número maior que 1 para confirmar a compra, e 0 para cancelar.");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("Confirmar:"); int confirmar  = int.Parse(Console.ReadLine());
                        if (confirmar < 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Compra cancelada.");
                            Thread.Sleep(4000);
                            goto PainelDeVendas;
                        }
                        else
                        {
                            Console.Clear();
                            if (valorvendido < 50)
                            {
                                Console.Clear();
                                double valorquefalta = 50 - valorvendido;
                                Console.WriteLine($"Dinheiro em vendas insuficiente. Faltam R$ {valorquefalta} para você adquirir funcionários.");
                                Thread.Sleep(4000);
                                goto PainelDeVendas;
                            }
                            else
                            {
                                valorvendido = valorvendido - 50;
                                Console.Clear();
                                funcionarios = funcionarios + 1;
                                Console.WriteLine($"Você adquiriu 1 funcionário, agora você tem {funcionarios}!");
                                Thread.Sleep(5000);
                                goto PainelDeVendas;
                            }
                        }
                    }

                }



            }
        }
    }
}