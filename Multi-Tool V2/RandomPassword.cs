using System;

namespace Multi_Tool_V2
{
    //@author xNovax
    class RandomPassword
    {
        //Start of Global Variable Declaration
        private int type;
        //Array of characters that are allowed in the normal password type
        String[] normalPasswordArray = new String[52]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        //Array of characters that are allowed in the numbers password type
        String[] numbersPasswordArray = new String[62]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
        };

        //Array of characters that are allowed in the special password type
        String[] specialPasswordArray = new String[77]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$",
            "%", "^", "&", "*", "_", "-", "+", "=", "<", ">", "?"
        };
        //End of Global Variable Declaration

        //Start of Author Created Methods
        public void createRandomCharacter()
        {
           int type = 1;
            if (type == 1)
            {
                
            }
            else
            {
                if (type == 2)
                {
                    
                }
                else
                {
                    if (type == 3)
                    {
                        
                    }
                }
            }
        }
        //End of Author Created Methods
    }
}
