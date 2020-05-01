namespace CashWorking
{
    class Controller
    {
        public static MainMemory MainMemo;
        public static Cash L;
        public bool FromCash;

        int CountLines;

        public Controller(int countSegments, int countLines, int countElements)
        {
            CountLines = countLines;
            MainMemo = new MainMemory(countSegments, countLines, countElements);
            L = new Cash(countLines, countElements);
        }

        //i - сегмент
        //j - строка
        //k - смещение
        public char this[int i, int j, int k]
        {
            get
            {
                DirectMaping(i, j);
                return L[j, k];
            }
            set
            {
                DirectMaping(i, j);
                L[j, k] = value;
            }
        }

        //Проверяет на совпадение требуемый и текущий теги строки
        void DirectMaping(int i, int j)
        {
            FromCash = true;
            if (i != L.GetTag(j))
            {
                FromCash = false;

                if (L.GetTag(j) != -1)
                    MainMemo.SetLine(L.GetTag(j), j, L[j]);
                
                L[j] = MainMemo.GetLine(i, j);
                L.SetTag(j, i);
            }
        }

        //Записать из кэша все данные в память
        //и очистить теги
        public void ClearCash()
        {
            for (int i = 1; i <= CountLines; i++)
            {
                MainMemo.SetLine(L.GetTag(i), i, L[i]);
                L.SetTag(i, -1);
            }
        }
    }
}
