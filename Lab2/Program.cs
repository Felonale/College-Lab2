using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        public class Info
        {
            public static void About()
            {
                Console.WriteLine("About Lab\n" +
                    "Copyright © 2022-2022 by\n" +
                    "Felonale(Lapenko Danil)\n" +
                    "Published by Felonale\n" +
                    "https://github.com/Felonale/College-Lab2");
            }
        }
        public class Exercises //Класс для заданий
        {
            public static void First()
            {
                Console.Write("Введите число от 100 до 999: ");
                string numb = Console.ReadLine().Trim(); // Считываем цифру и записываем её в виде строки
                try
                {
                    if (int.Parse(numb) >= 100 && int.Parse(numb) <= 999) //Переводя в тип "int", проверяем на верность условия
                    {
                        switch (numb[0]) //По первому числу выводим соответствующее слово
                        {
                            case '1': Console.Write("Сто "); break;
                            case '2': Console.Write("Двести "); break;
                            case '3': Console.Write("Триста "); break;
                            case '4': Console.Write("Четыреста "); break;
                            case '5': Console.Write("Пятьсот "); break;
                            case '6': Console.Write("Шестьсот "); break;
                            case '7': Console.Write("Семьсот "); break;
                            case '8': Console.Write("Восемьсот "); break;
                            case '9': Console.Write("Девятьсот "); break;
                            default: break;
                        }

                        switch (numb[1])//По второму числу выводим соответствующее слово
                        {
                            case '1': //В русском языке мы говорим не "Сто десять пять", а "Сто пятнадцать"
                                      //здесь проверяется условие, при котором вторая цифра в числе будет единичкой.
                                switch (numb[2])
                                {
                                    case '0': Console.WriteLine("десять"); break;
                                    case '1': Console.WriteLine("одиннадцать"); break;
                                    case '2': Console.WriteLine("двенадцать"); break;
                                    case '3': Console.WriteLine("тринадцать"); break;
                                    case '4': Console.WriteLine("четырнадцать"); break;
                                    case '9': Console.WriteLine("пятнадцать"); break;
                                    case '5': Console.WriteLine("шестнадцать"); break;
                                    case '6': Console.WriteLine("семнадцать"); break;
                                    case '7': Console.WriteLine("восемнадцать"); break;
                                    case '8': Console.WriteLine("девятнадцать"); break;
                                    default: break;
                                }
                                return;
                            case '2': Console.Write("двадцать "); break;
                            case '3': Console.Write("тридцать "); break;
                            case '4': Console.Write("сорок "); break;
                            case '5': Console.Write("пятьдесят "); break;
                            case '6': Console.Write("шестьдесят "); break;
                            case '7': Console.Write("семьдесят "); break;
                            case '8': Console.Write("восемьдесят "); break;
                            case '9': Console.Write("девяносто "); break;
                            default: break;
                        }

                        switch (numb[2]) //По третьему числу выводим соответствующее слово
                        {
                            case '1': Console.Write("один"); break;
                            case '2': Console.Write("два"); break;
                            case '3': Console.Write("три"); break;
                            case '4': Console.Write("четыре"); break;
                            case '5': Console.Write("пять"); break;
                            case '6': Console.Write("шесть"); break;
                            case '7': Console.Write("семь"); break;
                            case '8': Console.Write("восемь"); break;
                            case '9': Console.Write("девять"); break;
                            default: break;
                        }
                    }
                    else
                    {
                        Console.Write("Введено неверное число.");
                    }
                }
                catch
                {
                    Console.WriteLine("Введено не число");
                    return;
                }
                Console.WriteLine("\n");
                
            }
            public static void Second()
            {
                Console.Write("Введете год для определения названия(с 1984 года): ");
                int year;
                try
                {
                    year = int.Parse(Console.ReadLine()) - 1984;
                }
                catch
                {
                    Console.WriteLine("Введен неверный год");
                    return;
                }
                if (year < 0)
                {
                    Console.WriteLine("Введён несуществующий год");
                    return;
                }
                year = year % 60; //Отрезаем остальные цифры и оставляем только нужный период
                Console.Write("Год ");
                switch (year / 12) //Определяем 60-ти летний цикл
                {
                    case 0: Console.Write("зелён"); break;
                    case 1: Console.Write("красн"); break;
                    case 2: Console.Write("жёлт"); break;
                    case 3: Console.Write("бел"); break;
                    case 4: Console.Write("чёрн"); break;
                    default: break;
                }

                switch(year % 12) //Определяем год в 12-ти годах 60-ти летнего цикла
                { //крысы, коровы, тигра, зайца, дракона, змеи, лошади, овцы, обезьяны, курицы, собаки и свиньи.
                    case 0: Console.WriteLine("ой крысы"); break;
                    case 1: Console.WriteLine("ой коровы"); break;
                    case 2: Console.WriteLine("ого тигра"); break;
                    case 3: Console.WriteLine("ого зайца"); break;
                    case 4: Console.WriteLine("ого дракона"); break;
                    case 5: Console.WriteLine("ой змеи"); break;
                    case 6: Console.WriteLine("ой лошади"); break;
                    case 7: Console.WriteLine("ой овцы"); break;
                    case 8: Console.WriteLine("ой обезьяны"); break;
                    case 9: Console.WriteLine("ой курицы"); break;
                    case 10: Console.WriteLine("ой собаки"); break;
                    case 11: Console.WriteLine("ой свиньи"); break;
                    default: break;
                }
            }
            public static void Third()
            {
                Console.InputEncoding = Encoding.GetEncoding(866);

                string alphabetLAT = "abcdefghijklmnopqrstuvwxyz";
                string alphabetRU = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
                Console.Write("Введите текст для Цезарьского шифрования: ");
                string text = Console.ReadLine();
                Console.Write("Введите сдвиг(в виде цифры): ");
                int shift = int.Parse(Console.ReadLine());
                string finaltext = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ' ')
                        finaltext += " ";
                    else if (text.ToLower()[0] >= 'a' && text.ToLower()[0] <= 'z')
                    {
                        if (alphabetLAT.IndexOf(text[i]) != -1) //Если буквы входят в латинский алфавит нижнего регистра
                        {
                            finaltext += alphabetLAT[(alphabetLAT.IndexOf(text[i]) + shift) % alphabetLAT.Length];
                        }
                        else //Если буквы не входят в алфавит нижнего регистра(Буква верхнего регистра), переводим
                        {
                            finaltext += alphabetLAT.ToUpper()[(alphabetLAT.IndexOf(text.ToLower()[i]) + shift) % alphabetLAT.Length];
                        }
                    }
                    else if (text.ToLower()[0] >= 'а' && text.ToLower()[0] <= 'я' || text.ToLower()[0] <= 'ё')
                    {
                        if (alphabetRU.Contains(text[i])) //Если буквы входят в латинский алфавит нижнего регистра
                        {
                            finaltext += alphabetRU[(alphabetRU.IndexOf(text[i]) + shift) % alphabetRU.Length];
                        }
                        else //Если буквы не входят в алфавит нижнего регистра(Буква верхнего регистра), переводим
                        {
                            finaltext += alphabetRU.ToUpper()[(alphabetRU.IndexOf(text.ToLower()[i]) + shift) % alphabetRU.Length];
                        }
                    }
                    else
                    {
                        finaltext += text[i];
                    }
                }
                Console.WriteLine(finaltext);

            }
            static void ShowMatrix(int[,] matrix) //Метод для отображения матрицы
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i,j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            public static void Fourth()
            {
                int[,] matrix9 = new int[9, 9];
                int actualnumber = 1; //Переменная для хранения заполняемого в массив числа
                for (int i = 0; i < matrix9.GetLength(0); i++)
                {
                    if (i % 2 == 0) 
                    {
                        for (int j = 0; j < matrix9.GetLength(1); j++)
                        {
                            matrix9[i, j] = actualnumber; //Заполняем ячейку массива актуальным числом
                            actualnumber++; //Добавляем единичку к актуальному числу
                        }
                    }
                    else //Заполняем каждый нечётный массив в обратном порядке(От последней ячейки к нулевой)
                    {
                        for (int j = matrix9.GetLength(1)-1; j >= 0; j--)
                        {
                            matrix9[i, j] = actualnumber;
                            actualnumber++;
                        }
                    }
                }
                ShowMatrix(matrix9); //Метод для отображения матрицы
            }

            static void FullTwoDimMatrix(int[,] matrix) //Заполнить двумерную матрицу
            {
                Random rand = new Random();
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = rand.Next(-99, 99);
                    }
                }
            }

            public static void Fifth()
            {
                Random random = new Random();
                int[,] FirstMatrix = new int[random.Next(2, 10), random.Next(2, 10)];
                FullTwoDimMatrix(FirstMatrix);
                int[,] SecondMatrix = new int[FirstMatrix.GetLength(1), random.Next(2, 10)]; //Произведение двух матриц выполнимо только в случае, если количество столбцов левой матрицы равно количеству строк правой.
                FullTwoDimMatrix(SecondMatrix);
                
                int sumDiagFirstMatrix = 0; //Сумма диагоналей первой матрицы
                int dimMinFirstMatrix = FirstMatrix.GetLength(0) < FirstMatrix.GetLength(1) ? FirstMatrix.GetLength(0) : FirstMatrix.GetLength(1); //Минимальное измерение первого массива
                for (int i = 0; i < dimMinFirstMatrix; i++)
                {
                    sumDiagFirstMatrix += FirstMatrix[i, i];
                }

                int sumDiagSecondMatrix = 0; //Сумма диагоналей второй матрицы
                int dimMinSecondMatrix = SecondMatrix.GetLength(0) < SecondMatrix.GetLength(1) ? SecondMatrix.GetLength(0) : SecondMatrix.GetLength(1); //Минимальное измерение второго массива
                for (int i = 0; i < dimMinSecondMatrix; i++)
                {
                    sumDiagSecondMatrix += SecondMatrix[i, i];
                }

                //Начало 1 условия
                Console.WriteLine("1 условие: ");
                if (sumDiagFirstMatrix > sumDiagSecondMatrix) //Если сумма элементов главной диагонали 1-ой матрицы больше суммы элементов главной диагонали 2 - ой матрицы
                                                             //то найти произведение этих матриц
                {
                    int[,] ThirdMatrix = new int[FirstMatrix.GetLength(0),SecondMatrix.GetLength(1)]; //Матрица, в которой будут хранится данные после перемножения
                    for (int i = 0; i < ThirdMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < ThirdMatrix.GetLength(1); j++)
                        {
                            ThirdMatrix[i,j] = 0;
                            for (int k = 0; k < FirstMatrix.GetLength(1); k++)
			                {
                                ThirdMatrix[i,j] += FirstMatrix[i, k] * SecondMatrix[k, j]; //Ячейку приравниваем к сумме всех чисел на тех же координатах
                                                                                            //(Пример: C[3,5] = A[3,k] + B[k,5], где k - все ячейки по очереди)
			                }
                        }
                    }

                    Console.WriteLine("Произведение двух матриц:");
                    ShowMatrix(ThirdMatrix);
                }
                else //иначе все положительные элементы исходных матриц заменить на &quot;0&quot;
                {
                    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                        {
                            if (FirstMatrix[i,j] > 0)
                            {
                                FirstMatrix[i, j] = 0;
                            }
                        }
                    }
                    Console.WriteLine("Обе матрицы с нулями, вместо положительных чисел:\n" +
                        "A:");
                    ShowMatrix(FirstMatrix);
                    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                        {
                            if (SecondMatrix[i, j] > 0)
                            {
                                SecondMatrix[i, j] = 0;
                            }
                        }
                    }
                    Console.WriteLine("B:");
                }

                Console.Write("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
                //Конец 1 условия
                //Начало 2 условия
                Console.WriteLine("\n2 условие: ");
                if (sumDiagFirstMatrix < sumDiagSecondMatrix)//если сумма элементов главной диагонали 1-ой матрицы меньше суммы элементов главной диагонали 2 - ой матрицы
                                                            //то исходные матрицы необходимо транспонировать
                {
                    int[,] tempFirstMatrix = new int[FirstMatrix.GetLength(1), FirstMatrix.GetLength(0)]; //Создаём временные матрицы для транспонирования
                    int[,] tempSecondMatrix = new int[SecondMatrix.GetLength(1), SecondMatrix.GetLength(0)];
                    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                        {
                            tempFirstMatrix[j,i] = FirstMatrix[i,j]; //Транспонируем матрицу, перенося результат во временную матрицу
                        }
                    }
                    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                        {
                            tempSecondMatrix[j, i] = SecondMatrix[i, j];
                        }
                    }

                    FirstMatrix = new int[tempFirstMatrix.GetLength(0), tempFirstMatrix.GetLength(1)]; //Изменяем первоначальные матрицы на измерения транспонированных
                    SecondMatrix = new int[tempSecondMatrix.GetLength(0), tempSecondMatrix.GetLength(1)];
                    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                        {
                            FirstMatrix[i, j] = tempFirstMatrix[i, j]; //Добавляем данные из ячеек временных массивов в первоначальные матрицы
                        }
                    }
                    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < SecondMatrix.GetLength(1); j++) 
                        {
                            SecondMatrix[i, j] = tempSecondMatrix[i, j];
                        }
                    }
                    Console.WriteLine("Транспонированные матрицы:\n" +
                        "A:");
                    ShowMatrix(FirstMatrix);
                    Console.WriteLine("B:");
                    ShowMatrix(SecondMatrix);
                }
                else //иначе умножить исходные матрицы на число 5
                {
                    for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                        {
                            FirstMatrix[i, j] *= 5;
                        }
                    }
                    for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                        {
                            SecondMatrix[i, j] *= 5;
                        }
                    }
                    Console.WriteLine("Матрицы, умноженные на 5:\n" +
                        "A:");
                    ShowMatrix(FirstMatrix);
                    Console.WriteLine("B:");
                    ShowMatrix(SecondMatrix);
                }

                Console.Write("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
                //Конец 2 условия
                //Начало 3 условия
                Console.WriteLine("\n3 условие: "); //в исходных матрицах найти максимальные и минимальные элементы и поменять их местами

                // Ниже я попробовал сделать хранение данных о ячейке с максимальным числом через массив. Но в случае, когда у нас есть несколько ячеек, содержащие
                // максимальное число, изменится только первое. В нашем случае это не подходит
                /*int[] maxNum = new int[3] { 0, 0, 0 }; 
                int[] minNum = new int[3] { 0, 0, 0 };*/

                int maxNum = 0; //Создаём переменную, в которой будем хранить максимальное число
                int minNum = 0; //Создаём переменную, в которой будем хранить максимальное число

                //Меняем числа для 1 матрицы
                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                    {
                        maxNum = maxNum < FirstMatrix[i,j] ? FirstMatrix[i,j] : maxNum; //Если проверяемая сейчас ячейка больше, чем максимальное записанное число, вписываем новое значение
                    }
                }
                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                    {
                        minNum = minNum > FirstMatrix[i, j] ? FirstMatrix[i, j] : minNum; //Если проверяемая сейчас ячейка меньше, чем минимальное записанное число, вписываем новое значение
                    }
                }

                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                    {
                        if (FirstMatrix[i, j] == maxNum) //Если проверяемая ячейка - максимальное число, меняем его на минимальное
                        {
                            FirstMatrix[i, j] = minNum;
                        }
                        else if (FirstMatrix[i, j] == minNum)
                        {
                            FirstMatrix[i, j] = maxNum;
                        }
                    }
                }
                Console.WriteLine("Матрицы с изменёнными максимальными и минимальными числами:\n" +
                        $"A (Max: {maxNum}, Min: {minNum}):");
                ShowMatrix(FirstMatrix);

                //Меняем числа для 2 матрицы
                for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        maxNum = maxNum < SecondMatrix[i, j] ? SecondMatrix[i, j] : maxNum; //Если проверяемая сейчас ячейка больше, чем максимальное записанное число, вписываем новое значение
                    }
                }
                for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        minNum = minNum > SecondMatrix[i, j] ? SecondMatrix[i, j] : minNum; //Если проверяемая сейчас ячейка меньше, чем минимальное записанное число, вписываем новое значение
                    }
                }

                for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        if (SecondMatrix[i, j] == maxNum) //Если проверяемая ячейка - максимальное число, меняем его на минимальное
                        {
                            SecondMatrix[i, j] = minNum;
                        }
                        else if (SecondMatrix[i, j] == minNum)
                        {
                            SecondMatrix[i, j] = maxNum;
                        }
                    }
                }

                Console.WriteLine($"B (Max: {maxNum}, Min: {minNum}:");
                ShowMatrix(SecondMatrix);

                Console.Write("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
                //Конец 3 условия
                //Начало 4 условия
                Console.WriteLine("\n4 условие: "); //в исходных матрицах посчитать количество положительных и отрицательных элементов
                int numOfPositive = 0;
                int numOfNegative = 0;
                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                    {
                        if (FirstMatrix[i, j] > 0)
                            numOfPositive++;
                        else if (FirstMatrix[i, j] < 0)
                            numOfNegative++;
                    }
                }
                Console.WriteLine($"Количество положительных чисел в матрице A: {numOfPositive}");
                Console.WriteLine($"Количество отрицательных чисел в матрице A: {numOfNegative}");
                numOfPositive = 0;
                numOfNegative = 0;
                for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        if (SecondMatrix[i, j] > 0)
                            numOfPositive++;
                        else if (SecondMatrix[i, j] < 0)
                            numOfNegative++;
                    }
                }
                Console.WriteLine($"Количество положительных чисел в матрице B: {numOfPositive}");
                Console.WriteLine($"Количество отрицательных чисел в матрице B: {numOfNegative}");

                Console.Write("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
                //Конец 4 условия
                //Начало 5 условия
                Console.WriteLine("\n5 условие: "); //в исходных матрицах посчитать суммы элементов строк и столбцов
                Console.WriteLine("Сумма строк и столбцов матриц:\n" +
                    "A:");
                int tempRow = 0;
                int[] tempCollumn = new int[FirstMatrix.GetLength(1)]; //Создаём массив с размерностью второго измерения матрицы А
                for (int i = 0; i < tempCollumn.Length; i++)
                {
                    tempCollumn[i] = 0; //Заполняем массив нулями
                }

                for (int i = 0; i < FirstMatrix.GetLength(0); i++)
                {
                    Console.Write("\t"); //Добавляем табуляцию в начало каждой строки для того, чтобы строка "Sum", суммирующая столбцы, не съехала
                    for (int j = 0; j < FirstMatrix.GetLength(1); j++)
                    {
                        Console.Write(FirstMatrix[i, j] + "\t");
                        tempRow += FirstMatrix[i, j]; //Добавляем во временную переменную числа, суммирующие строку
                        tempCollumn[j] += FirstMatrix[i, j]; //Добавляем в каждую ячейку массива сумму от каждого стоблца (Так, как читка массива происходит
                                                             //от по строкам, а не столбцам, мы заполяем дополнительную строку, которую будем выводить
                                                             //в конце отображения массива)
                    }
                    Console.WriteLine("Sum: " + tempRow);
                    tempRow = 0; //Сбрасываем временную переменную, суммирующую строку
                }
                Console.Write("Sum:\t");
                for (int i = 0; i < tempCollumn.Length; i++)
                {
                    Console.Write(tempCollumn[i] + "\t");
                }
                Console.WriteLine("\n\nB:"); //Двойной перенос строки для форматирования

                tempRow = 0;
                tempCollumn = new int[SecondMatrix.GetLength(1)]; //Изменяем массив с размерностью второго измерения матрицы В
                for (int i = 0; i < tempCollumn.Length; i++)
                {
                    tempCollumn[i] = 0; //Заполняем массив нулями
                }

                for (int i = 0; i < SecondMatrix.GetLength(0); i++)
                {
                    Console.Write("\t"); //Добавляем табуляцию в начало каждой строки для того, чтобы строка "Sum", суммирующая столбцы, не съехала
                    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
                    {
                        Console.Write(SecondMatrix[i, j] + "\t");
                        tempRow += SecondMatrix[i, j]; //Добавляем во временную переменную числа, суммирующие строку
                        tempCollumn[j] += SecondMatrix[i, j];//Добавляем в каждую ячейку массива сумму от каждого стоблца (Так, как читка массива происходит
                                                             //от по строкам, а не столбцам, мы заполяем дополнительную строку, которую будем выводить
                                                             //в конце отображения массива)
                    }
                    Console.WriteLine("Sum: " + tempRow);
                    tempRow = 0; //Сбрасываем временную переменную, суммирующую строку
                }
                Console.Write("Sum:\t");
                for (int i = 0; i < tempCollumn.Length; i++)
                {
                    Console.Write(tempCollumn[i] + "\t");
                }
                //Конец 5 условия
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер задания 1-5 (Введите 'exit' для выхода или 'about' для информации): ");
                string variant = Console.ReadLine().Trim().ToLower();
                switch (variant)
                {
                    case "1": Console.Clear(); Exercises.First(); break;
                    case "2": Console.Clear(); Exercises.Second(); break;
                    case "3": Console.Clear(); Exercises.Third(); break;
                    case "4": Console.Clear(); Exercises.Fourth(); break;
                    case "5": Console.Clear(); Exercises.Fifth(); break;
                    case "exit": Environment.Exit(0); break;
                    case "about": Console.Clear(); Info.About(); break;
                    default: Console.WriteLine("Введен неверный номер задания"); break;
                }
            }
        }
    }
}
