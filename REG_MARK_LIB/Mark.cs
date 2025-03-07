namespace REG_MARK_LIB
{
    public class Mark
    {
        List<char> seriaLetterEnglish, seriaLetterRussian;
        List<string> regions;
        Dictionary<char, char> dictonaryRussianAndEnglishLetters;

        /// <summary>
        /// Структура, содержащая переопределение операторов сравнения для регистрационного номера
        /// </summary>
        struct MarkReg()
        {
            public char FirstLetter { get; set; }
            public char SecondLetter { get; set; }
            public char ThirdLetter { get; set; }
            public int Number { get; set; }

            public MarkReg(string mark) : this()
            {
                FirstLetter = mark[0];
                SecondLetter = mark[4];
                ThirdLetter = mark[5];
                Number = int.Parse(mark.Substring(1, 3));
            }


            /// <summary>
            /// Переопределение оператора < для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns>Больше\меньше</returns>
            public static bool operator <(MarkReg mark1, MarkReg mark2)
            {   
                //Проверка на равно, буквы серии и номер
                if (mark1.FirstLetter > mark2.FirstLetter) return false;
                if (mark1.FirstLetter < mark2.FirstLetter) return true;                

                if (mark1.SecondLetter > mark2.SecondLetter) return false;
                if (mark1.SecondLetter < mark2.SecondLetter) return true;

                if (mark1.ThirdLetter > mark2.ThirdLetter) return false;
                if (mark1.ThirdLetter < mark2.ThirdLetter) return true;

                if (mark1.Number > mark2.Number) return false;
                if (mark1.Number < mark2.Number) return true;

                return false;
            }


            /// <summary>
            /// Переопределение оператора > для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns><Больше\меньше/returns>
            public static bool operator >(MarkReg mark1, MarkReg mark2)
            {
                //Проверка на равно, буквы серии и номер
                if (mark1.FirstLetter < mark2.FirstLetter) return false;
                if (mark1.FirstLetter > mark2.FirstLetter) return true;

                if (mark1.SecondLetter < mark2.SecondLetter) return false;
                if (mark1.SecondLetter > mark2.SecondLetter) return true;

                if (mark1.ThirdLetter < mark2.ThirdLetter) return false;
                if (mark1.ThirdLetter > mark2.ThirdLetter) return true;

                if (mark1.Number < mark2.Number) return false;
                if (mark1.Number > mark2.Number) return true;

                return false;
            }

            /// <summary>
            /// Переопределение оператора == для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns>True/False</returns>
            public static bool operator ==(MarkReg mark1, MarkReg mark2)
            {
                return mark1.FirstLetter == mark2.FirstLetter &&
                       mark1.SecondLetter == mark2.SecondLetter &&
                       mark1.ThirdLetter == mark2.ThirdLetter &&
                       mark1.Number == mark2.Number;
            }

            /// <summary>
            /// Переопределение оператора != для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns>True/False</returns>
            public static bool operator !=(MarkReg mark1, MarkReg mark2)
            {
                return !(mark1 == mark2);
            }

            /// <summary>
            /// Переопределение оператора <= для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns>Меньше или равно</returns>
            public static bool operator <=(MarkReg mark1, MarkReg mark2)
            {
                if (mark1 < mark2) return true;

                if (mark1 == mark2) return true;

                return false;
            }

            /// <summary>
            /// Переопределение оператора >= для структуры MarkReg
            /// </summary>
            /// <param name="mark1">Первый номер</param>
            /// <param name="mark2">Второй номер</param>
            /// <returns>Больше или равно</returns>
            public static bool operator >=(MarkReg mark1, MarkReg mark2)
            {
                if (mark1 > mark2) return true;

                if (mark1 == mark2) return true;


                return false;
            }
        }        

        public Mark() 
        {
            SeriaLetterEnglish = new List<char>
            {                
                'A', 'B', 'E', 'K', 'M', 'H', 'O', 'P', 'C', 'T', 'У', 'X'
            };

            SeriaLetterRussian = new List<char>
            {
                'А', 'В', 'Е', 'К', 'М', 'Н', 'О', 'Р', 'С', 'Т', 'У', 'Х'
            };

            DictonaryRussianAndEnglishLetters = new()
            {
                { 'A', 'А' }, { 'B', 'В' }, { 'E', 'Е' }, { 'K', 'К' },
                { 'M', 'М' }, { 'H', 'Н' }, { 'O', 'О' }, { 'P', 'Р' },
                { 'C', 'С' }, { 'T', 'Т' }, { 'Y', 'У' }, { 'X', 'Х' }
            };

            Regions = new List<string>()
            {
                "01", "101", "02", "102", "702", "03", "103", "04", "104", "05", "105", "06", "106", "07", "107",
                "08", "108", "09", "109", "10", "110", "11", "111", "12", "112", "13", "113", "14", "114", "15", "115",
                "16", "116", "716", "17", "117", "18", "118", "19", "119", "21", "121", "22", "122", "23", "93", "123",
                "193", "24", "124", "25", "125", "26", "126", "27", "127", "28", "128", "29", "129", "30", "130", "31",
                "131", "32", "132", "33", "133", "34", "134", "35", "135", "36", "136", "37", "137", "38", "138", "39",
                "139", "40", "140", "41", "141", "42", "142", "43", "143", "44", "144", "45", "145", "46", "146", "47",
                "147", "48", "148", "49", "149", "50", "90", "150", "190", "750", "790", "51", "151", "52", "152", "252",
                "53", "153", "54", "154", "55", "155", "56", "156", "57", "157", "58", "158", "59", "159", "60", "61",
                "161", "761", "62", "162", "63", "163", "763", "64", "164", "65", "165", "66", "96", "196", "67", "167",
                "68", "168", "69", "169", "70", "170", "71", "171", "72", "172", "73", "173", "74", "174", "774", "75",
                "76", "77", "97", "99", "177", "197", "199", "777", "797", "799", "78", "98", "178", "198", "79", "80",
                "180", "81", "181", "82", "83", "84", "184", "85", "185", "86", "186", "87", "88", "94", "89", "92", "95",
                "195", "995"
            };
        }

        
        /// <summary>
        /// Метод, преобразующий английский символ в русский (для учёта случаев, если закидывают латинский символ)
        /// </summary>
        /// <param name="markReg"></param>
        /// <returns></returns>
        private String EnglishToRussianChar(String markReg)
        {
            char[] resultMarkReg = markReg.ToCharArray();
            int length = markReg.Length;
            for (int i = 0; i < length; i++)
            {
                char symbol = resultMarkReg[i];
                if (DictonaryRussianAndEnglishLetters.TryGetValue(symbol, out char russiaLetter))
                {
                    resultMarkReg[i] = russiaLetter;
                }
            }
            return new String(resultMarkReg);
        }

        private List<char> SeriaLetterEnglish { get => seriaLetterEnglish; set => seriaLetterEnglish = value; }
        private List<string> Regions { get => regions; set => regions = value; }
        private List<char> SeriaLetterRussian { get => seriaLetterRussian; set => seriaLetterRussian = value; }
        private Dictionary<char, char> DictonaryRussianAndEnglishLetters { get => dictonaryRussianAndEnglishLetters; set => dictonaryRussianAndEnglishLetters = value; }

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
            string region = string.Empty;

            List<char> allSeriaLetters = new List<char>();
            allSeriaLetters.AddRange(seriaLetterEnglish);
            allSeriaLetters.AddRange(seriaLetterRussian);

            if (!(length == 8 || length == 9))
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
                    bool exists = allSeriaLetters.Contains(symbol);
                    if (!exists)
                    {
                        return false;
                    }                    
                }
                else
                {
                    region += symbol;
                }
            }

            if (!Regions.Contains(region))
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Метод возвращает следующий номер в данной серии или создаёт следующую серию
        /// </summary>
        /// <param name="mark"></param>
        /// <returns>Cледующий номер в данной серии или следующая серия</returns>
        public String GetNextMarkAfter(String mark)
        {
            if (CheckMark(mark))
            {
                char[] arraySymbols = mark.ToCharArray(); 
                char[] personalSeria = { arraySymbols[0], arraySymbols[4], arraySymbols[5] };
                string region = mark.Substring(6);
                if (int.TryParse(mark.Substring(1, 3), out int number))
                {
                    if (number < 999)
                    {
                        number++;
                        return $"{personalSeria[0]}{number:D3}{personalSeria[1]}{personalSeria[2]}{region}";
                    }
                    else
                    {
                        number = 1;
                        for (int i = 2; i >= 0; i--)
                        {

                            int index = SeriaLetterRussian.IndexOf(personalSeria[i]);
                            if (index == -1)
                            {
                                index = SeriaLetterEnglish.IndexOf(personalSeria[i]);
                            }
                            
                            if (index < SeriaLetterRussian.Count - 1)
                            {
                                personalSeria[i] = SeriaLetterRussian[++index];
                                break;
                            }
                            else
                            {
                                personalSeria[i] = 'А';
                            }
                        }
                        return $"{personalSeria[0]}{number:D3}{personalSeria[1]}{personalSeria[2]}{region}";
                    }
                }                
            }
            return string.Empty;
        }




        /// <summary>
        /// Метод определяющий, находится ли следующий номер от переданного в заданном диапазоне номеров
        /// </summary>
        /// <param name="prevMark">Предыдущий номер</param>
        /// <param name="rangeStart">Номер начала диапазона</param>
        /// <param name="rangeEnd">Номер конца диапазона</param>
        /// <returns>Следующий номер в диапазоне</returns>
        public String GetNextMarkAfterInRange(String prevMark, String rangeStart, String rangeEnd)
        {
            
            prevMark = EnglishToRussianChar(prevMark);
            rangeStart = EnglishToRussianChar(rangeStart);
            rangeEnd = EnglishToRussianChar(rangeEnd);
            
            if (CheckMark(prevMark) && CheckMark(rangeStart) && CheckMark(rangeEnd))
            {
                String newMark = GetNextMarkAfter(prevMark);

                MarkReg newMarkReg = new MarkReg(newMark);
                MarkReg rangeStartMarkReg = new MarkReg(rangeStart);
                MarkReg rangeEndMarkReg = new MarkReg(rangeEnd);

                if (newMarkReg > rangeStartMarkReg && newMarkReg < rangeEndMarkReg)
                {
                    return newMark;
                }
            }        

            return "out of stock";
        }


        /// <summary>
        /// Метод, принимает два номера и определяет количество номеров между (включая границы)
        /// </summary>
        /// <param name="mark1">Номер 1</param>
        /// <param name="mark2">Номер 2</param>
        /// <returns>Количетсво возможных номер в диапазоне</returns>
        public int GetCombinationsCountInRange(String mark1, String mark2)
        {
            if (CheckMark(mark1) && CheckMark(mark2))
            {
                mark1 = EnglishToRussianChar(mark1);
                mark2 = EnglishToRussianChar(mark2);
                int counter = 0;
                string start = mark1;
                MarkReg startRegMark = new MarkReg(mark1);
                MarkReg endRegMark = new MarkReg(mark2);
                while (startRegMark <= endRegMark)
                {
                    start = GetNextMarkAfter(start);
                    startRegMark = new MarkReg(start);
                    counter++;
                }
                return counter;
            }
            return 0;
        }
    }
}
