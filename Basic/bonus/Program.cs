namespace Bonus {
    class Bonus{
        static void Main(){
            Console.WriteLine("Informe o tempo de serviço: ");
            float servico =  float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor da bonificação: ");
            float valor = float.Parse(Console.ReadLine());
            
            float b = servico*valor;
            Console.WriteLine("O valor da bonificação é: " + b + "R$");
    
        }
    }
}
