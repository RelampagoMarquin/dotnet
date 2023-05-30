// See https://aka.ms/new-console-template for more information
static void Main(){
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Informe seu peso: ");
    float peso = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe sua altura: ");
    float altura = float.Parse(Console.ReadLine());

    float imc = peso/(altura*altura);
    Console.WriteLine(nome + " , seu IMC é: " + imc);
    
}