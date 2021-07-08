namespace Runner
{
    public class Strings
    {
        public static int Exercise10(string first, string second) {
            int repeatsFound = 0;
            int currentStringIndex = 0;
            
            for (int i = 0; i < first.Length; i++) {
                if (first[i] == second[currentStringIndex]) {
                    currentStringIndex++;
                }
                else {
                    currentStringIndex = 0;
                }
			
                if (currentStringIndex == second.Length) {
                    repeatsFound++;
                    currentStringIndex = 0;
                }
            }
		
		
            return repeatsFound;
        }
    }
}