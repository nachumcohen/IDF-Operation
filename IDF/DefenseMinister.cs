using IDF_Operation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
    static class DefenseMinister
    {
        public static string BringMenu(TaskReport task)
        {
            string strike = "4. Strike.\n";
            string menu = "\n\n" +
                "0. Exit\n" +
                "1. Show list of lives TERRORIST.\n" +
                "2. Show list of Israeli Soldier.\n" +
                "3. Show strike option.\n";
            if (task is null) return menu;

            return menu+strike;
        }
        public static TaskReport DoTask(int task, IDF idf, TaskReport taskReport = null)
        {
            
            switch (task)
            {
                case 1:
                    idf.PrintAliveTerrorist();
                    break;
                case 2:
                    idf.PrintSoldiers();
                    break;
                case 3:
                    try {
                        taskReport = idf.ShowAvailbleStrike();
                        Console.WriteLine(taskReport);
                        return taskReport;
                    }
                    catch (NoTerroristAlives) { Console.WriteLine("No Terrorist Alives"); }
                    catch (NotHaveAvalbleSoldiers) { Console.WriteLine("There is no Soldier that can make the mission"); }
                    catch (NoTasks) { Console.WriteLine("No Tasks"); }

                    break;
                case 4:
                    try { if (!(taskReport is null)) idf.Fire(taskReport);
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                    }
                    catch (NoTerroristAlives) { Console.WriteLine("No Terrorist Alives"); }
                    catch (NotHaveAvalbleSoldiers) { Console.WriteLine("There is no Soldier that can make the mission"); }
                    catch (NoTasks) { Console.WriteLine("No Tasks"); }
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            return null;
        }
        private static void PrintSoldiers()
        {

        }
        private static void PrintTerrorist()
        {

        }
        private static void PrintStrikeOption()
        {

        }
        private static void Strike()
        {

        }
    }
}
