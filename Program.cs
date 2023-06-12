    //By NicholasDev
    
    // Declaração das variáveis
    int secret, kick, attempts = 0;
    int maxAttempts = 7;
    bool win = false;

    // Configuração da cor do console
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine("---- Jogo de Advinha ----");
    Console.ResetColor();

    // Geração de um número secreto aleatório
    Random random = new Random();
    int secret_number = random.Next(1, 101);

    secret = secret_number;

    // Solicitação do palpite do jogador
    Console.WriteLine("Escolha um número para tentar advinhar o número secreto");
    kick = int.Parse(Console.ReadLine()!);

    // Loop principal do jogo
    while (secret != kick && attempts < maxAttempts)
    {
        attempts++;

        // Verifica se o palpite é igual ao número secreto
        if (kick == secret)
        {
            win = true;
        }
        else
        {
            // Verifica se o palpite é maior que o número secreto
            if (kick > secret)
            {
                // Verifica se o palpite está "CONGELANDO" ou "FRIO"
                if (kick - secret > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Está CONGELANDO e o número secreto é menor");
                    Console.ResetColor();
                }
                else if (kick - secret > 20)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Está FRIO e o número secreto é menor");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Está QUENTE...");
                    Console.ResetColor();
                }
            }
            // Caso contrário, o palpite é menor que o número secreto
            else if (kick < secret)
            {
                // Verifica se o palpite está "CONGELANDO" ou "FRIO"
                if (secret - kick > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Está CONGELANDO e o número secreto é maior");
                    Console.ResetColor();
                }
                else if (secret - kick > 20)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Está FRIO e o número secreto é maior");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Está QUENTE...");
                    Console.ResetColor();
                }
            }

            // Verifica se o número máximo de tentativas foi atingido
            if (attempts == maxAttempts)
            {
                Console.Clear();
                Console.WriteLine($"Suas tentativas acabaram. O número secreto era {secret}.");
                Console.ReadLine();
            }

            // Solicitação de um novo palpite do jogador
            Console.WriteLine("Escolha um número para tentar advinhar o número secreto");
            kick = int.Parse(Console.ReadLine()!);
        }
    }

    Console.Clear();

    // Verifica se o jogador acertou o número secreto
    if (win)
    {
        Console.WriteLine($"Parabéns, você acertou o número secreto {secret}!");
    }
