// See https://aka.ms/new-console-template for more information
class test{
   static void Main(){
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Informe seu peso: ");
    float peso = float.Parse(Console.ReadLine());
    Console.WriteLine("Informe sua altura em cm: ");
    float altura = float.Parse(Console.ReadLine());

    float aPorcent = altura/100;
    float imc = peso/(aPorcent * aPorcent);
    Console.WriteLine(nome + ", seu IMC é: " + imc);
    
} 
}
