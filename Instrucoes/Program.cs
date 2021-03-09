using System;
using System.IO;

namespace Instrucoes
{
    class Program
    {
    	static void Declaracoes()
    	{
    		/// declaracao da variavel a, sem atribuição de valor (OBS: TODAS VARIAVEIS INT SEM ATRIBUIÇAO DE VALOR POSSUEM O VALOR 0, POREM SEU USO É IMPOSSIBILITADO)
    		int a;
    		/// declaracao e atribuicao de valores em duas variaveis do mesmo tipo na mesma linha
    		int b = 2, c = 3;
    		/// declaracao de constante
    		const int d = 4;
    		/// atribuicao de valor na var a
    		a = 1;
    		/// alteracao do vaor da var a
    		a = 2;
    		/// apresenacao da soma de todas variaveis
    		Console.WriteLine(a + b + c + d);
    	}

    	/// criacao de um metodo com retorno vazio que recebe um array string como argumento
    	static void InstrucaoIf(string[] args)
    	{
    		/// verificacao se o array eh igual a zero
    		if (args.Length == 0)
    		{
    			Console.WriteLine("0 argumentos");
    		}
    		/// veriicacao se o array eh igual a um
    		else if (args.Length == 1)
    		{
    			Console.WriteLine("1 argumento");
    		}
    		/// caso todas as verificacoes derem False apresenta o real numero de argumentos do array
    		else
    		{
    			Console.WriteLine($"{args.Length} argumentos");
    		}
    	}

    	static void InstrucaoSwitch(string[] args)
    	{
    		int numeroDeArgumentos = args.Length;
    		switch (numeroDeArgumentos)
    		{
    			// verifica se a var eh zero
    			case 0:
    				Console.WriteLine("Nenhum argumento");
    				// caso entre neste caso realiza tudo e sai do SWITCH
    				break;
    			// verifica se a var eh 1
    			case 1:
    				Console.WriteLine("Um argumento");
    				break;
    			// imprime a quantidade de args
    			default:
    				Console.WriteLine("{0} argumentos", numeroDeArgumentos);
    				break;
    		}
    	}

    	static void InstrucaoWhile(string[] args)
    	{
    		int i = 0;
    		// enquanto I for menor q o numero de argumetnos...
    		while (i < args.Length)
    		{
    			// ... imprime cada argumento
    			Console.WriteLine(args[i]);
    			// adiciona + 1 ao I
    			i++;
    		}
    	}

    	static void InstrucaoDo()
    	{
    		string texto;
    		// parecido com a instrucao while, entretanto ele sempre irá executar ao menos uma vez antes de verificar a condicao
    		do
    		{
    			// le uma linha no console
    			texto = Console.ReadLine();
    			Console.WriteLine($"Você escreveu: '{texto}'");
    		} while (!string.IsNullOrEmpty(texto)); // verifica se a string eh nula ou vazia
    	}

        static void InstrucaoFor(string[] args)
        {
            // enquanto i for menor que o tamanho dos argumentos...
            for (int i = 0; i < args.Length; i++)
            {
                // imprima tal argumento
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            // para cada string s em args...
            foreach (string s in args)
            {
                // imprima s
                Console.WriteLine(s);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            // executa para sempre...
            while (true)
            {
                string s = Console.ReadLine();

                // ate s for nulo ou vazio
                if (string.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }

        static void InstrucaoContinue(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {   
                // caso o argumento inicie com /, va para o proximo item
                if (args[i].StartsWith("/"))
                    continue;

                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn()
        {
            // metodo aninhado
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(5, 7));
            Console.WriteLine(Somar(9, 8));

            return;
        }

        static void InstrucaoTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double a, double b)
            {
                // caso o denominador seja zero, lanca uma excecao
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }

                return a / b;
            }

            try
            {
                // caso o numero de argumentos seja menor que dois
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe dois números!");
                }

                // declara duas variaveis e modifica o tipo delas
                double a = double.Parse(args[0]);
                double b = double.Parse(args[1]);

                Console.WriteLine(Dividir(a, b));
            }

            // pega a excecao invalid e trata ela
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            // pega qualquer outra excecao que tenha ocorrido e trata ela
            catch (Exception e)
            {
                Console.WriteLine($"Erro genérico: {e.Message}");
            }

            // executa ao final de tudo
            finally
            {
                Console.WriteLine();
            }
        }

        // usado geralmente para ao termino do using destruir os objetos criados
        static void IntrucaoUsing()
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Linha 1");
            }
        }

    	static void ImprimeArgs(string[] args)
    	{
    		/// imprime a primeira variavel do array args
    		Console.WriteLine($"{args[0]}");

    		/// para cada variavel no array args imprima ela
    		foreach (string arg in args)
    		{
    			Console.WriteLine($"{arg}");
    		}
    	}

    	static void ArraysMultidimensionais()
    	{
    		/// criacao de um array multidimensional
    		int[,] posicoes = {{2, 1}, {4, 3}, {7, 1}};

    		/// ira imprimir cada sub elemento do array separadamente
    		foreach (int posicao in posicoes)
    		{
    			Console.WriteLine("{0}", posicao);
    		}
    		/// output: 2\n1\n4\n3\n7\n1\n
    	}

        static void Main(string[] args)
        {
        	//string[] a = {};
        	//InstrucaoDo();
        	//ArraysMultidimensionais();
        	//ImprimeArgs(args);
        	//InstrucaoIf(args);
        	//Declaracoes();
            //Console.WriteLine("Nothing to present!");
            //IntrucaoUsing();
            
        }
    }
}
