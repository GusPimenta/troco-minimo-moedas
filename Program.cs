namespace Troco
{
    class Program
    {
        static void Main(string[] args)
        {
            int centavos,reais,cm,r1,c50,c25,c10,c5,c1;
            decimal preco,pago,troco,cents;
            bool sucesso;
            Console.WriteLine("Digite o preço do produto:");
            sucesso = decimal.TryParse(Console.ReadLine(), out preco);
            if (sucesso==false){
                    Console.WriteLine("Erro, o valor digitado não pode ser computado");
                Environment.Exit(0);
            }
            Console.WriteLine("Digite o valor pago:");
            sucesso = decimal.TryParse(Console.ReadLine(), out pago);
            if (sucesso==false){
                    Console.WriteLine("Erro, o valor digitado não pode ser computado");
                Environment.Exit(0);
            }
            troco = pago-preco;
            reais = (int)(troco);
            cents =((troco)-reais)*100;
            centavos = (int)cents;
            cm = centavos;
            r1 = (int)reais;
            c50 = 0;
            c25 = 0;
            c10 = 0;
            c5 = 0;
            c1 = 0;
            while (cm>0)
            {
                if (cm>=50){
                    cm=cm-50;
                    c50=c50+1;
                }
                if (cm>=25 && cm<50){
                    cm=cm-25;
                    c25=c25+1;
                }
                if (cm>=10 && cm<25){
                    cm=cm-10;
                    c10=c10+1;
                }
                if (cm>=5 && cm<10){
                    cm=cm-5;
                    c5=c5+1;
                }
                if (cm>=1 && cm<5){
                    cm=cm-1;
                    c1=c1+1;
                }
            }
            Console.Clear();
            if (centavos>0){
                Console.WriteLine("O preço do produto foi R$" + preco + " e o valor que foi pago foi de R$" + pago + " então o troco foi de R$" + reais + "," + centavos);
            }
            else{
                Console.WriteLine("O preço do produto foi R$" + preco + " e o valor que foi pago foi de R$" + pago + " então o troco foi de R$" + reais);
            }
            Console.WriteLine("Foram utilizadas:");
            if (r1>0){
                if(r1>1){
                    Console.WriteLine(r1 + " moedas de 1 real");
                }
                else{
                    Console.WriteLine(r1 + " moeda de 1 real");
                }
            }
            if (c50>0){
                if(c50>1){
                    Console.WriteLine(c50 + " moedas de 50 centavos");
                }
                else{
                    Console.WriteLine(c50 + " moeda de 50 centavos");
                }
            }
            if (c25>0){
                if(c25>1){
                    Console.WriteLine(c25 + " moedas de 25 centavos");
                }
                else{
                    Console.WriteLine(c25 + " moeda de 25 centavos");
                }
            }
            if (c10>0){
                if(c10>1){
                    Console.WriteLine(c10 + " moedas de 10 centavos");
                }
                else{
                    Console.WriteLine(c10 + " moeda de 10 centavos");
                }
            }
            if (c5>0){
                if(c5>1){
                    Console.WriteLine(c5 + " moedas de 5 centavos");
                }
                else{
                    Console.WriteLine(c5 + " moeda de 5 centavos");
                }
            }
            if (c1>0){
                if(c1>1){
                    Console.WriteLine(c1 + " moedas de 1 centavo");
                }
                else{
                    Console.WriteLine(c1 + " moeda de 1 centavo");
                }
            }
        }
    }
}
