namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float v)
        {
        this.Valor = v;
        this.Valor_imposto = this.Valor * 20 / 100;
        this.Valor_total = this.Valor + this.Valor_imposto;

        }
    }
} 