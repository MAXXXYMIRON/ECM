using System;
using System.IO;

namespace CashWorking
{
    class MainMemory
    {
        readonly FileStream RAM = new FileStream("Memory.ini", FileMode.Create);
        int CountSegments,
            CountLines,
            CountElements;
        
        public MainMemory(int countSegments, int countLines, int countElements)
        {
            Random values = new Random();
            CountSegments = countSegments;
            CountLines = countLines;
            CountElements = countElements;

            //10 - блоков
            for (int i = 0; i < CountSegments; i++)
            {
                RAM.WriteByte(10);

                //10 - строк
                for (int j = 0; j < CountLines; j++)
                {
                    //4 - элемента
                    for (int k = 0; k < CountElements; k++)
                    {
                        RAM.WriteByte((byte)values.Next(48, 58));
                    }
                    RAM.WriteByte(10);
                }
            }
        }

        void Positioning(int segment, int line)
        {
            segment--;
            line--;

            //Позиция каретки с учетом размеров
            RAM.Position = (segment + 1) + //Отступы м\у сегментами
                (segment * (CountLines * (CountElements + 1))) +  //Пропуск эл. до нужного сегмента
                (line * ((CountElements + 1))); //Пропуск эл. до нужной строки
        }

        //Cчитать строку line в сегменте segment
        public char[] GetLine(int segment, int line)
        {
            char[] temp = new char[CountElements];
            Positioning(segment, line);

            for (int i = 0; i < CountElements; i++)
            {
                temp[i] = (char)RAM.ReadByte();
            }

            return temp;
        }

        //Записать строку temp в строку line в сегменте segment
        public void SetLine(int segment, int line, char[] temp)
        {
            Positioning(segment, line);

            for (int i = 0; i < CountElements; i++)
            {
                RAM.WriteByte((byte)temp[i]);
            }
        }
    }   
}
