using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTrust.RnD
{
    public static class Utility
    {
        public static bool  isAnEnglishWord(string word)
        {
            NetSpell.SpellChecker.Dictionary.WordDictionary oDict = new NetSpell.SpellChecker.Dictionary.WordDictionary();

            oDict.DictionaryFile = "en-US.dic";
            //load and initialize the dictionary 
            oDict.Initialize();
            string txtWords = word;
            NetSpell.SpellChecker.Spelling oSpell = new NetSpell.SpellChecker.Spelling();

            oSpell.Dictionary = oDict;
            char[] chDelims = { ' ', '\n', '\t', '\r' };
            foreach (string s in txtWords.Split(chDelims))
            {
                if (s.Length > 0 && oSpell.TestWord(s))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
