using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (1) ou Jurídica (2)");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "1")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.Nome = var_nome;
                pf.Endereco = var_endereco;
                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Iformar RG: ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("----------- Pessoa Física ------------");
                Console.WriteLine("Nome ..........: "+ pf.Nome);
                Console.WriteLine("Endereço.......: "+ pf.Endereco);
                Console.WriteLine("CPF............: "+ pf.cpf);
                Console.WriteLine("RG.............: "+ pf.rg);
                Console.WriteLine("Valor de Compra: "+ pf.Valor.ToString("C"));
                Console.WriteLine("Imposto........: "+ pf.Valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar..: "+ pf.Valor_total.ToString("C"));
            }else if(var_tipo == "2")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.Nome = var_nome;
                pj.Endereco = var_endereco;
                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra: ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("------------- Pessoa Jurídica -------------");
                Console.WriteLine("Nome ..........: "+ pj.Nome);
                Console.WriteLine("Endereço.......: "+ pj.Endereco);
                Console.WriteLine("CNPJ...........: "+ pj.cnpj);
                Console.WriteLine("IE.............: "+ pj.ie);
                Console.WriteLine("Valor de Compra: "+ pj.Valor.ToString("C"));
                Console.WriteLine("Imposto........: "+ pj.Valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar..: "+ pj.Valor_total.ToString("C"));
            }
        }
    }
}