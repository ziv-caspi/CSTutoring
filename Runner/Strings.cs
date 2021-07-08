namespace Runner
{
    public class Strings
    {
        /// <summary>
        /// Returns How many times the second string appears in the first string
        /// </summary>
        public static int CountSubStringRepeats(string first, string second) {
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