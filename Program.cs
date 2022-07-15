using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Execultar},
                { "Comentários - Fundamentos", Comentarios.Executar },
                { "Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                { "Inferência - Fundamentos", Inferencia.Executar },
                { "Interpolação - Fundamentos", Interpolacao .Executar },
                { "Notação Ponto - Fundamentos", NotacaoPonto .Executar },
                { "Lendo Dados - Fundamentos", LendoDados .Executar },
                { "Formantando Número - Fundamentos", FormantandoNumero .Executar },
                { "Conversões - Fundamentos", Conversoes .Executar },
                { "Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos .Executar },
                { "Operadores Relacionais - Fundamentos", OperadoresRelacionais .Executar },
                { "Operadores Lógicos - Fundamentos", OperadoresLogicos .Executar },
                { "Operadores De Atribuição - Fundamentos", OperadoresDeAtribuicao .Executar },
                { "Operadores Unários - Fundamentos", OperadoresUnarios .Executar },
                { "Operador Ternario - Fundamentos", OperadorTernario.Executar },

                //Estrutura de Controle
                { "Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                { "Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                { "Estrutura If/ElseIf - Estruturas de Controle", EstruturaIfElseIf.Executar },
                { "Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                { "Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },


            }) ;

            central.SelecionarEExecutar();
        }
    }
}