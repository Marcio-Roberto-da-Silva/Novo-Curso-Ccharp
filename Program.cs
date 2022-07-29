﻿using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

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
                { "Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar },
                { "Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                { "Estrutura For Each - Estruturas de Controle", EstruturaForEach.Executar },
                { "Usando Break - Estruturas de Controle", UsandoBreak.Executar },

                //Classes e Métodos
                { "Membros - Classes e Métodos", Membros.Executar },
                 { "Construtores - Classes e Métodos", Construtores.Executar },
                 { "Métodos com Retorno - Classes e Métodos", MetodosComRetorno.Executar },
                 { "Métodos Estáticos- Classes e Métodos", MetodosEstaticos.Executar },
                 { "Atributos Estáticos- Classes e Métodos", AtributosEstaticos.Executar },
                 { "Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                 { "Params - Classes e Métodos", Params.Executar },
                 { "Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                 { "GetSet - Classes e Métodos", GetSet.Executar },
                 { "Props - Classes e Métodos", Props.Executar },
                 { "Readonly - Classes e Métodos", Readonly.Executar },
                 { "Exemplo Enum - Classes e Métodos", ExemploEnum.Executar },
                 { "Struct - Classes e Métodos", ExemploStruct.Executar },
                 { "Struct Vs Classes - Classes e Métodos", StructVsClasse.Executar },
                 { "Valor Vs Referências - Classes e Métodos", ValorVsReferencia.Executar },
                 { "Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                 { "Parâmetro Padrão - Classes e Métodos", ParametroPadrao.Executar },

                 // Coleções
                 { "Array - Coleções", Colecoes.Array.Executar },
                 { "List - Coleções", Colecoes.ColecoesList.Executar },
                 { "Array List - Coleções", Colecoes.ColecoesArrayList.Executar },
                 { "Set - Coleções", ColecoesSet.Executar },
                 { "Queue - Coleções", ColecoesQueue.Executar },
                 { "Igualdade - Coleções", Igualdade.Executar },
                 { "Stack - Coleções", ColecoesStack.Executar },
                 { "Dictionary - Coleções", ColecoesDictionary.Executar },

                 // OO
                 { "Herança - OO ", Heranca.Executar },
                 { "Construtor This - OO ", ConstrutorThis.Executar },
                 { "Encapsulamento - OO ", OO. Encapsulamento.Executar },
                 { "Polimorfismo - OO ", Polimorfismo.Executar },
                 { "Abstract - OO ", Abstract.Executar },
                 { "Interface - OO ", Interface.Executar },
                 { "Sealed - OO ", Sealed.Executar },

                // Métodos E Funções
                 { "Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar },
                 { "Lambdas com Delegate - Métodos & Funções", LambdasDelegate.Executar },
                 { "Usando Delegates - Métodos & Funções", UsandoDelegates.Executar },
                 { "Delegates como funções Anonima - Métodos & Funções", DelegateFunAnonima.Executar },
                 { "Delegates como Parâmetros - Métodos & Funções", DelegatesComParametros.Executar },
                 { "Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar },

                 //Exceções
                 { "Primeira Exceções - Exceções", PrimeiraExcecao.Executar },
                  { "Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                  //Api
                  { "Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar },
                  { "Lendo Arquivos - Usando API", LendoArquivos.Executar },
                  { "Exemplo FileInfo - Usando API", ExemploFileInfo.Executar },
                  { "Diretórios - Usando API", Diretorios.Executar },
                  { "Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar },
                  { "Exemplo Path - Usando API", ExemploPath.Executar },
                  { "Exemplo DateTime - Usando API", ExemploDateTime.Executar },
                  { "Exemplo TimeSpan - Usando API", ExemplotimeSpan.Executar },

                  //Tópicos Avançados
                  { "LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                  { "LINQ #02 - Tópicos Avançados", LINQ2.Executar },
                  { "Nullables - Tópicos Avançados", Nullables.Executar },
                  { "Dynamics - Tópicos Avançados", Dynamics.Executar },
                  { "Genericos - Tópicos Avançados", Genericos.Executar },

            }) ;

            central.SelecionarEExecutar();
        }
    }
}