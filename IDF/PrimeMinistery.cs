using IDF_Operation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Operation.IDF
{
     class PrimeMinistery
    {
        IDF idf = new IDF();

        public void Run()
        {
            TaskReport taskReport = null;
            int task;
            bool menu = true;
            while (menu)
            {
                Console.WriteLine(DefenseMinister.BringMenu(taskReport));
                try
                {
                    task = Convert.ToInt32(Console.ReadLine());
                    if (task == 0)  break;
                    taskReport = DefenseMinister.DoTask(task, idf, taskReport);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Wrong input");
                }
            }


            //for (int i = 0; i <= 5; i++)
            //{

            //    try
            //    {
            //        idf.ShowAvailbleStrike();
            //        idf.Fire();
            //    }
            //    catch
            //    {

            //    }

            //}
        }
    }
}
