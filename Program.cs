using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // Teste com a classe Nokia
        Nokia nokia = new Nokia("123456789", "Nokia Modelo", "123456789012345", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Teste com a classe Iphone
        Iphone iphone = new Iphone("987654321", "iPhone Modelo", "987654321098765", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
