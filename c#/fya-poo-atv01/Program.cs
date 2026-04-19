using System;

namespace AfyaATV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            Lampada lampada01 = new Lampada("Lux", Tecnologias.LED);

            Console.WriteLine(lampada01.ToString());

            lampada01.Alternar();
            lampada01.AjustarBrilho(20);

            Console.WriteLine(lampada01.ToString());

            Console.WriteLine("=========================================================");
            //2

            CofreDigital cofre = new CofreDigital("Pedro", "1234");

            Console.WriteLine(cofre.Abrir("0000"));
            Console.WriteLine(cofre.Abrir("1111"));
            Console.WriteLine(cofre.Abrir("2222"));

            Console.WriteLine(cofre.Abrir("1234"));

            cofre.ResetarTentativas();

            Console.WriteLine(cofre.Abrir("1234"));

            Console.WriteLine(cofre.AlterarSenha("1234", "9999"));

            cofre.Fechar();

            Console.WriteLine(cofre.Abrir("9999"));

            Console.WriteLine(cofre.ToString());

            Console.WriteLine("=========================================================");

            //3

            ContaCorrente conta = new ContaCorrente(12345, "Pedro");

            Console.WriteLine(conta);

            Console.WriteLine("Depositar 300: " + conta.Depositar(300));
            Console.WriteLine(conta);

            Console.WriteLine("Sacar 200: " + conta.Sacar(200));
            Console.WriteLine(conta);

            Console.WriteLine("Sacar 700 (usa limite): " + conta.Sacar(700));
            Console.WriteLine(conta);

            Console.WriteLine("Status: " + conta.StatusConta);
            Console.WriteLine("Saldo Total: " + conta.SaldoTotal);

            Console.WriteLine("Alterando titular...");
            conta.Titular = "Pedro Silva";
            Console.WriteLine(conta);

            Console.WriteLine("Sacar 1000 (deve falhar): " + conta.Sacar(1000));
            Console.WriteLine(conta);

            Console.WriteLine("=========================================================");

            //4

            Personagem p = new Personagem("Arthas", "Guerreiro");

            Console.WriteLine(p);

            p.ReceberDano(50);
            Console.WriteLine("Após dano: " + p);

            p.Curar(30);
            Console.WriteLine("Após cura: " + p);

            p.SubirNivel();
            Console.WriteLine("Após subir nível: " + p);

            p.ReceberDano(500);
            Console.WriteLine("Após dano fatal: " + p);

            p.Curar(50);
            Console.WriteLine("Tentando curar morto: " + p);

            p.SubirNivel();
            Console.WriteLine("Tentando subir nível morto: " + p);

            p.Ressuscitar();
            Console.WriteLine("Após ressuscitar: " + p);
        }
    }
}