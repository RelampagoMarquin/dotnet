namespace Produto {
    class Produto{
        static void Main(){
            Console.WriteLine("Nome do produto: ");
            string prod =  Console.ReadLine();

            Console.WriteLine("Informe o valor do produto: ");
            float prodValor =  float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor do desconto em porcentagem: ");
            float desconto = float.Parse(Console.ReadLine());
            
            float pVDescont = prodValor * (1 - (desconto/100));
            Console.WriteLine("nome do produto: " + prod + " Valor: " + prodValor + " Desconto: " + desconto + "% Valor Final: " + pVDescont + "R$");
    
        }
    }
}