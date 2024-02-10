namespace MorseCode; 

public class Morse {
    private readonly Dictionary<string, string> _slovnik = new() {
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
        {" ", ""}
    };
    
    public List<string> Split(string text) {
        List<string> znaky = new();
        
        foreach (char znak in text) {
            znaky.Add(znak.ToString().ToLower());
        }

        return znaky;
    }

    public List<string> Split(string text, string separator) {
        List<string> znaky = new(); 
        
        foreach (string znak in text.Split(separator)) {
            znaky.Add(znak);
        }

        return znaky;
    }

    public string Encode(string text) {
        string zasifrovano = "";
        List<string> znaky = Split(text);
        
        for (int i = 0; i < znaky.Count; i++) {
            if (znaky[i] == "c" && znaky[i + 1] == "h") {
                znaky[i] = "ch";
                znaky.RemoveAt(i + 1);
            }
            
            if (_slovnik.TryGetValue([znaky[i], out string? value)) {
                zasifrovano += value + "/";
            } else {
                zasifrovano += "";
            }
        }
        
        return zasifrovano;
    }

    public string Decode(string text) {
        string desifrovano = "";
        List<string> znaky = Split(text, "/");
       
        for (int i = 0; i < znaky.Count; i++) {
            if (_slovnik.ContainsValue(znaky[i])) {
                desifrovano += _slovnik.FirstOrDefault(x => x.Value == znaky[i]).Key;
            } else {
                desifrovano += "?"; // tady si muzeme dovolit dat otaznik
            }
        }
        
        return desifrovano;
    }
}
