using Microsoft.Extensions.Logging.Console;

namespace MorseCode; 

public class Morse {
    protected Dictionary<string, string> Slovnik = new() {
        {"a", ".-"}, 
        {"á", ".-"}, 
        {"ą", ".-"},
        {"b", "-..."},
        {"c", "-.-."},
        {"č", "-.-."},
        {"d", "-.."},
        {"ď", "-.."},
        {"e", "."},
        {"é", "."},
        {"ě", "."},
        {"ę", "."},
        {"f", "..-."},
        {"g", "--."},
        {"h", "...."},
        {"ch", "----"},
        {"i", ".."},
        {"í", ".."},
        {"j", ".---"},
        {"k", "-.-"},
        {"l", ".-.."},
        {"m", "--"},
        {"n", "-."},
        {"ň", "-."},
        {"o", "---"},
        {"ó", "---"},
        {"p", ".--."},
        {"q", "--.-"},
        {"r", ".-."},
        {"ř", ".-."},
        {"s", "..."},
        {"š", "..."},
        {"t", "-"},
        {"ť", "-"},
        {"u", "..-"},
        {"ů", "..-"},
        {"ú", "..-"},
        {"v", "...-"},
        {"w", ".--"},
        {"x", "-..-"},
        {"y", "-.--"},
        {"ý", "-.--"},
        {"z", "--.."},
        {"ž", "--.."},
        {"1", ".----"},
        {"2", "..---"},
        {"3", "...--"},
        {"4", "....-"},
        {"5", "....."},
        {"6", "-...."},
        {"7", "--..."},
        {"8", "---.."},
        {"9", "----."},
        {"0", "-----"},
        {" ", "/"}
    };
    
    // predelat š na s, č na c atd.
    

    public string Encode(string text) {
        string zasifrovano = "";
        List<string> znaky = new();
        
        foreach (char znak in text) {
            znaky.Add(znak.ToString().ToLower());
        }

        for (int i = 0; i < znaky.Count; i++) {
            if (znaky[i] == "c" && znaky[i + 1] == "h") {
                znaky[i] = "ch";
                znaky.RemoveAt(i + 1);
            }
            
            if (Slovnik.ContainsKey(znaky[i])) {
                zasifrovano += Slovnik[znaky[i]] + "/";
            }
        }
        
        return zasifrovano;
    }

    public string Decode(string text) {
        string desifrovano = "";
        List<string> znaky = new(); 
        
        foreach (string znak in text.Split("/")) {
            znaky.Add(znak);
        }
       
        for (int i = 0; i < znaky.Count; i++) {
            if (Slovnik.ContainsValue(znaky[i])) {
                desifrovano += Slovnik.FirstOrDefault(x => x.Value == znaky[i]).Key;
            } else {
                desifrovano += "";
            }
        }
        
        return desifrovano;
    }
}