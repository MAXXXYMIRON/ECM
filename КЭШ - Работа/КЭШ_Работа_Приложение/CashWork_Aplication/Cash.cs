namespace CashWorking
{
    class Cash
    {

        (int Tag, int[] Line)[] Page;

        public Cash(int countLines, int countElements)
        {
            Page = new (int Tag, int[] Line)[countLines];
            for (int i = 0; i < Page.Length; i++)
            {
                Page[i].Line = new int[countElements];
                Page[i].Tag = -1;
            }
        }

        //i - строка
        //j - смещение
        //Считать или задать элемент
        public int this[int i, int j]
        {
            get => Page[i - 1].Line[j - 1];
            set => Page[i - 1].Line[j - 1] = value;
        }

        //Считать или задать строку
        public int[] this[int i]
        {
            get => Page[i - 1].Line;
            set => Page[i - 1].Line = value;
        }

        //Работа с тегами
        public int GetTag(int i) => Page[i - 1].Tag;
        public void SetTag(int i, int newTag) => Page[i - 1].Tag = newTag;
    }
}
