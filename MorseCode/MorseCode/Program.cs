namespace MorseCode {
    internal class Program {
        private static void Main(string[] args) {
            Morse morse = new();
            Console.WriteLine(morse.Encode("chello world"));
            Console.WriteLine(morse.Encode("Budiž k ničemu"));
            Console.WriteLine(morse.Encode("Běží liška k Táboru, nese pytel zázvoru"));
            Console.WriteLine(morse.Encode("Šílená čivava"));
            Console.WriteLine(morse.Encode("1234567890"));
            
            Console.WriteLine(morse.Decode("----/...././.-./.-"));
            Console.WriteLine(morse.Decode("-.../..-/-../..--././--"));
            Console.WriteLine(morse.Decode("-----/.----/.-./.-/--..."));
        }
    }
}