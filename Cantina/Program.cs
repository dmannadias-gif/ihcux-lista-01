/*
 Heurísticas Aplicadas:
 #1 Visibilidade do Status: Exibição dos passos do pedido (Passo 1 de 3, etc.)
 #3 Controle e Liberdade: Usuário pode digitar "voltar" ou "cancelar" a qualquer momento
 #9 Ajuda no Reconhecimento de Erros: Mensagens claras e orientativas em entradas inválidas
*/

using System;

class Program
{
    static void Main()
    {
        int codigoProduto = 0;
        int quantidade = 0;
        bool pedidoAtivo = true;

        Console.WriteLine("=== Bem-vindo à Cantina UNA ===");

        // PASSO 1 - Seleção do Produto
        while (pedidoAtivo)
        {
            Console.WriteLine("\n[Passo 1 de 3] Selecione o código do produto (1 a 10)");
            Console.Write("Digite o código do produto ou 'cancelar': ");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado com sucesso.");
                return;
            }

            if (!int.TryParse(entrada, out codigoProduto) || codigoProduto < 1 || codigoProduto > 10)
            {
                Console.WriteLine($"Código '{entrada}' inválido. Os códigos disponíveis vão de 1 a 10. Tente novamente.");
                continue;
            }

            break;
        }

        // PASSO 2 - Quantidade
        while (pedidoAtivo)
        {
            Console.WriteLine("\n[Passo 2 de 3] Informe a quantidade");
            Console.Write("Digite a quantidade ou 'voltar': ");
            string entrada = Console.ReadLine().ToLower();

            if (entrada == "voltar")
            {
                Main(); // volta para o início
                return;
            }

            if (!int.TryParse(entrada, out quantidade) || quantidade <= 0)
            {
                Console.WriteLine("Quantidade inválida. Digite um número maior que zero.");
                continue;
            }

            break;
        }

        // PASSO 3 - Confirmação
        while (pedidoAtivo)
        {
            Console.WriteLine("\n[Passo 3 de 3] Confirmação do Pedido");
            Console.WriteLine($"Produto: {codigoProduto}");
            Console.WriteLine($"Quantidade: {quantidade}");
            Console.Write("Digite 'confirmar', 'voltar' ou 'cancelar': ");

            string entrada = Console.ReadLine().ToLower();

            if (entrada == "confirmar")
            {
                Console.WriteLine("\n✅ Pedido realizado com sucesso! Obrigado.");
                pedidoAtivo = false;
            }
            else if (entrada == "voltar")
            {
                Main();
                return;
            }
            else if (entrada == "cancelar")
            {
                Console.WriteLine("Pedido cancelado.");
                pedidoAtivo = false;
            }
            else
            {
                Console.WriteLine("Comando não reconhecido. Use confirmar, voltar ou cancelar.");
            }
        }
    }
}