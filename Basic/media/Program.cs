namespace Media {
    class Media{
        static void Main(){
            Console.WriteLine("Informe o primeiro valor: ");
            float v1 =  float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            
            float m = (v1 + v2)/2;
            Console.WriteLine("A media é: " + m);
    
        }
    }
}
