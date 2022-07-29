using System;
using System.IO;


namespace CursoCSharp.Api {
    class ExemploFileInfo {

        public static void ExcluirSeExistir(params string [] caminhos) {
            foreach(var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_Destino.txt".ParseHome();
            var caminhocopia = @"~/arq_Copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhocopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhocopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
