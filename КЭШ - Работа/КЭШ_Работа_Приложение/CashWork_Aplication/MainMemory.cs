using System;
using System.IO;

namespace CashWorking
{
    class MainMemory
    {
        BinaryWriter Write;
        BinaryReader Read;

        int CountSegments,
            CountLines,
            CountElements;

        public MainMemory(int countSegments, int countLines, int countElements)
        {
            Random values = new Random();
            CountSegments = countSegments;
            CountLines = countLines;
            CountElements = countElements;

            using (Write = new BinaryWriter(new FileStream("Memory.ini", FileMode.Create)))
            {
                //CountSegments - блоков
                for (int i = 0; i < CountSegments; i++)
                {
                    Write.Write((char)10);

                    //CountLines - строк
                    for (int j = 0; j < CountLines; j++)
                    {
                        //CountElements - элементов
                        for (int k = 0; k < CountElements; k++)
                        {
                            Write.Write(values.Next(1000, 9999));
                            Write.Write(' ');
                        }
                        Write.Write((char)10);
                    }
                }
            }
        }

        void Positioning(int segment, int line, IDisposable WriteRead)
        {
            segment--;
            line--;

            int position = (segment + 1) + //Отступы м\у сегментами
                (segment * (CountLines * ((CountElements * 4) + 5))) +  //Пропуск эл. до нужного сегмента
                    (line * ((CountElements * 4) + 5)); //Пропуск эл. до нужной строки 

            //Позиция каретки с учетом размеров
            switch (WriteRead)
            {
                case BinaryWriter writer:
                    writer.BaseStream.Position = position;
                    break;
                case BinaryReader reader:
                    reader.BaseStream.Position = position;
                    break;
            }

        }

        //Cчитать строку line в сегменте segment
        public int[] GetLine(int segment, int line)
        {
            int[] temp = new int[CountElements];

            using (Read = new BinaryReader(new FileStream("Memory.ini", FileMode.Open)))
            {
                Positioning(segment, line, Read);

                for (int i = 0; i < CountElements; i++)
                {
                    temp[i] = Read.ReadInt32();
                    Read.BaseStream.Position++;
                }
            }

            return temp;
        }

        //Записать строку temp в строку line в сегменте segment
        public void SetLine(int segment, int line, int[] temp)
        {
            using (Write = new BinaryWriter(new FileStream("Memory.ini", FileMode.Open)))
            {
                Positioning(segment, line, Write);

                for (int i = 0; i < CountElements; i++)
                {
                    Write.Write(temp[i]);
                    Write.Write(' ');
                }
            }
        }
    }
}