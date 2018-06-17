using System;

namespace UtilityLibraries
{

    /*
     The class library, UtilityLibraries.StringLibrary, 
     contains a method named StartsWithUpper, 
     which returns a Boolean value that indicates 
     whether the current string instance begins with an uppercase character. 
     The Unicode standard distinguishes uppercase characters from lowercase characters. 
     The Char.IsUpper(Char) method returns true if a character is uppercase.
     */
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this String str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return false;

            Char ch = str[0];
            return Char.IsUpper(ch);
        }
    }
}
