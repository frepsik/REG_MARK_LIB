namespace REG_MARK_LIB
{
    public class Mark
    {
        List<char> seriaLetter;
        public Mark() 
        {

            SeriaLetter = new List<char>
            {
                'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х',
                'A', 'B', 'E', 'K', 'M', 'H', 'O', 'P', 'C', 'T', 'X'
            };
        }

        public List<char> SeriaLetter { get => seriaLetter; set => seriaLetter = value; }

        /// <summary>
        /// Метод проверяет номерной знак, на возможность существования
        /// </summary>
        /// <param name="mark">Номерной знак</param>
        /// <returns>Существует/не существует</returns>
        public Boolean CheckMark(String mark)
        {
            if (mark is null)
            {
                return false;
            }
            int counter = 0;
            char[] arraySymbols = mark.ToCharArray();   
            int length = mark.Length;
            
            if (length != 8)
            {
                return false;
            }

            char symbol;
            for (int i = 0; i < length; i++)
            {
                symbol = arraySymbols[i];
                if (i > 0 && i < 4)
                {
                    if (!(int.TryParse(symbol.ToString(), out int number) && (number >= 0)))
                    {
                        return false;
                    }
                }
                else if (i == 0 || (i > 3 && i < 6))
                {
                    bool exists = SeriaLetter.Contains(symbol);
                    if (!exists)
                    {
                        return false;
                    }                    
                }
                else
                {
                    
                    if (!(int.TryParse(symbol.ToString(), out int number) && (number >= 0)))
                    {
                        return false;
                    }
                    if (number == 0)
                    {
                        counter++;
                    }
                    if (counter == 2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
