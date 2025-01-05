using aero_quest.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace aero_quest
{
    internal class MailControl
    {
        public static Queue<Mails> DeletedMailsQueue = new Queue<Mails>();

        public static void ProcessDeletedMailsQueue()
        {
            
                int queueCount = DeletedMailsQueue.Count;
                for (int i = 0; i < queueCount; i++)
                {
                    Mails mail = DeletedMailsQueue.Dequeue();
                    if ((DateTime.Now.Date - mail.DateDeleted.Date).TotalDays >= 30)
                    {
                        User._userMails.Remove(mail);
                        Console.WriteLine($"Deleted mail successfully.\nDate it was added to trash:{mail.DateDeleted}");
                    }
                    else
                    {
                        DeletedMailsQueue.Enqueue(mail); 


                    }
                }
            
        }


    }
}
