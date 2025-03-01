using REG_MARK_LIB;



Mark mark = new Mark();


//Console.WriteLine(mark.CheckMark("А913АЪ152"));

//Console.WriteLine(mark.GetNextMarkAfter("А999АМ152"));

//Console.WriteLine(mark.GetNextMarkAfterInRange("А913АM152", "А910АМ152", "А913АX152"));
Console.WriteLine(mark.GetCombinationsCountInRange("А913АМ152", "А920АM152"));
