using System;
using Aula.Source;
using Aula.Controller;

namespace Aula {
    public class Program {
        private string[] parameters = new string[] { };
        private string[] MenuOptions = new string[] {
            "Novo Custo",
            "Verificar Saldo",
            "Verificar Gastos",
            "Entrada de Valor",
            "Verificar Media",
            "Sair"
        };

        public Program() {}
        public Program(string[] parameters): this() {
            this.parameters = parameters;
        }

        public void Run() {
            int option = 0;

            do {
                try
                {
                    for (int x = 0; x < this.MenuOptions.Length; x++)
                        Console.WriteLine($"| {x + 1} | {Util.CompleteString(30, this.MenuOptions[x])}");

                    option = Util.ReadIntTerminal();
                    MenuController.Instance().Run(option);
                }
                catch (System.Exception error)
                { Console.WriteLine(error.Message); }
            } while(option != (this.MenuOptions.Length));
        }

        public static Program Instance() {
            return new Program();
        }

        public static Program Instance(string[] arguments) {
            return new Program(arguments);
        }
        // ponto de acesso da aplicação
        public static void Main(string[] arguments) {
            Program.Instance(arguments).Run();
        }
    }
}