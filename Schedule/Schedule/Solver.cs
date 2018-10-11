using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    class Solver
    {
        public static char?[,] Solve(string text, int workersCount, int pointsCount)
        {
            string[] lines = text.Split('\n');
            int?[] pointConnection = new int?[pointsCount];

            char[] points = new char[pointsCount];
            int counter = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                char beginPoint = lines[i][0];
                char endPoint = lines[i][lines[i].Length - 1];

                if (GetIndex(points, beginPoint) == -1)
                    points[counter++] = beginPoint;
                if (GetIndex(points, endPoint) == -1)
                    points[counter++] = endPoint;

                pointConnection[GetIndex(points, beginPoint)] = GetIndex(points, endPoint);
            }

            int[,] table = SetPrioriries(workersCount, pointsCount, pointConnection);

            char?[,] result = new char?[workersCount, pointsCount];
            int availableWorkCount = pointsCount;
            int time = 0;
            //очередь рабочих
            Queue<int> workersQueue = new Queue<int>();
            for (int i = 0; i < workersCount; i++)
                workersQueue.Enqueue(i);

            do
            {
                int[] descendantsCountTemp = GetDescendantsArray(table);
                for (int i = 0; i < workersCount; i++)
                {
                    int worker = workersQueue.Dequeue();
                    int maxPriorityIndex = GetMaxPriorityIndex(table);

                    if (table[0, maxPriorityIndex] > 0)
                    {
                        if (table[1, maxPriorityIndex] == 0)
                        {
                            //выполняем работу
                            result[worker, time] = points[maxPriorityIndex];
                            table[0, maxPriorityIndex] = -1;
                            availableWorkCount--;

                            //вычитаем у наследника 1
                            if (pointConnection[maxPriorityIndex] != null)
                            {
                                int endPoint = (int)pointConnection[maxPriorityIndex];
                                descendantsCountTemp[endPoint]--;
                            }
                        }
                        //если есть наследники или работа зависит от той, что делается в этот момент времени, то выполняем что можно
                        else
                        {
                            int currentPriority = table[0, maxPriorityIndex] - 1;
                            //ищем индекс следующей по приоритету работы
                            bool isWorkCompleted = false;
                            while (!isWorkCompleted && currentPriority > 0)
                            {
                                int indexOfCurrentPriority = -1;
                                for (int j = 0; j < pointsCount; j++)
                                {
                                    if (table[0, j] == currentPriority)
                                    {
                                        indexOfCurrentPriority = j;
                                        break;
                                    }
                                }
                                //если она независима, то работаем
                                if (indexOfCurrentPriority >= 0 && table[1, indexOfCurrentPriority] == 0)
                                {
                                    //выполняем работу
                                    result[worker, time] = points[maxPriorityIndex];
                                    table[0, maxPriorityIndex] = -1;
                                    availableWorkCount--;

                                    if (pointConnection[maxPriorityIndex] != null)
                                    {
                                        int endPoint = (int)pointConnection[maxPriorityIndex];
                                        descendantsCountTemp[endPoint]--;
                                    }

                                    isWorkCompleted = true;
                                }
                                //иначе идем дальше
                                else
                                    currentPriority--;
                            }
                        }
                    }

                    workersQueue.Enqueue(worker);
                }

                //записываем изменения
                for (int i = 0; i < pointsCount; i++)
                    table[1, i] = descendantsCountTemp[i];
                time++;
            } while (availableWorkCount > 0);

            return result;
        }

        private static int[,] SetPrioriries(int workers, int points, int?[] pointConnection)
        {
            //1 строка - приоритет i-ой работы
            //2 строка - количество предыдущих работ у i-ой работы
            int[,] table = new int[2, pointConnection.Length];

            Stack<int> works = new Stack<int>();
            //подсчет количества предыдущих работ
            for (int i = 0; i < points; i++)
            {
                if (pointConnection[i] != null)
                {
                    int index = (int)pointConnection[i];
                    table[1, index]++;
                }
                //запись конечной работы
                else
                    works.Push(i);
            }
            int priority = 1;
            table[0, works.Peek()] = priority;
            priority++;
            do
            {
                int currentWork = works.Pop();
                for (int i = 0; i < points; i++)
                {
                    if (pointConnection[i] != null && pointConnection[i] == currentWork)
                    {
                        if (table[1, i] != 0)
                            works.Push(i);
                        table[0, i] = priority;
                        priority++;
                    }
                }
            } while (works.Count != 0);

            //int[] prioritiesArray = new int[points];
            //for (int i = 0; i < points; i++)
            //    prioritiesArray[i] = table[0, i];

            return table;
        }

        private static int GetIndex(char[] array, char point)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] == point)
                    return i;

            return -1;
        }

        private static int GetMaxPriorityIndex(int[,] table)
        {
            int max = table[0, 0];
            int index = 0;
            for (int i = 1; i < table.GetLength(1); i++)
            {
                if (table[0, i] > max)
                {
                    max = table[0, i];
                    index = i;
                }
            }

            return index;
        }

        private static int[] GetDescendantsArray(int[,] table)
        {
            int[] descendants = new int[table.GetLength(1)];
            for (int i = 0; i < table.GetLength(1); i++)
                descendants[i] = table[1, i];

            return descendants;
        }
    }
}
