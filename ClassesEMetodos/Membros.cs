using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            // Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoconsole();
            sicrano.Zerar();
            sicrano.ApresentarNoconsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDofulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDofulano.Length);
            Console.WriteLine(apresentacaoDofulano);

        }
    }
}
