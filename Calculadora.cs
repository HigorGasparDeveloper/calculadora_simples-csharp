namespace calculadora_simples
{
    class Calculadora
    {
        static void Main(string[] args)
        {
            //para guardar a operação do menu
            int operacao = 0;
            //operações disponíveis no menu
            String[] operacoes = {"Soma","Subtração","Multiplicação", "Divisão", "Sair"};
            //para validar se a operação é válida
            bool operacaoValida = false;
            bool verificaSaida = false;
            //mostrando o menu
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------- Menu ---------------");
            Console.WriteLine("Escolha uma operação: (para realizar com 2 números)");
            Console.WriteLine($"1 - {operacoes[0]}");
            Console.WriteLine($"2 - {operacoes[1]}");
            Console.WriteLine($"3 - {operacoes[2]}");
            Console.WriteLine($"4 - {operacoes[3]}");
            Console.WriteLine($"5 - {operacoes[4]}");
            Console.WriteLine("--------------- Fim ----------------");
            Console.ForegroundColor = ConsoleColor.White;
            //tentando executar o bloco de código
            try
            {
                while (!operacaoValida)
                {
                    operacao = int.Parse(Console.ReadLine());
                    //verificando se digitou uma opção válida
                    if(operacao >= 1 && operacao <= operacoes.Length)
                    {
                        operacaoValida = true;
                    }else
                    {
                        //método para mostrar mensagem de acordo com o tipo
                        showMessage("A", $"A operação {operacao} não é válida. Tente novamente");
                    }
                }


                if(operacao == 5)
                {
                    showMessage("E","Saindo do programa");
                    return;
                }

                //solicitando e armazenando os números
                Console.WriteLine("Forneça o primeiro número:");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Forneça o segundo número:");
                double numero2 = double.Parse(Console.ReadLine());

                //variável para guardar o resultado da operação desejada
                double resultado = 0;

                //verificando a operação desejada para realizar a operação
                switch (operacao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        break;
                    case 2:
                        resultado = numero1 - numero2;
                        break;
                    case 3:
                        resultado = numero1 * numero2;
                        break;
                    default:
                        resultado = numero1 / numero2;
                        break;
                }
                showMessage("S", $"O resultado da operação de {operacoes[operacao - 1]} entre os números {numero1} e {numero2} é: {resultado}");
            }
            catch (FormatException e)
            {
                showMessage("E", $"Erro na entrada de dados: {e.Message}");
                return;
            }
            Console.Read();
        }

        static void showMessage(string type, string message)
        {
            if(type.Equals("E"))
            {
                //mensagem de erro
                Console.ForegroundColor = ConsoleColor.Red;
            }else if(type.Equals("A"))
            {
                //mensagem de alerta
                Console.ForegroundColor = ConsoleColor.Yellow;
            }else
            {
                //mensagem de sucesso
                Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}