namespace MorseCode {
    internal class Program {
        private static void Main(string[] args) {
            Morse morse = new();
            Console.WriteLine(morse.Encode("chello world"));
            Console.WriteLine(morse.Encode("Budiž k ničemu"));
            Console.WriteLine(morse.Encode("Běží liška k Táboru, nese pytel zázvoru"));
        }
    }
}