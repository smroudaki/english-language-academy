﻿using Quartz;
using Quartz.Impl;
using Quartz.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESL.Services.Plugins
{
    public class Quartz
    {
        public static async Task RunProgramRunExample()
        {
            try
            {
                // Grab the Scheduler instance from the Factory
                NameValueCollection props = new NameValueCollection
                {
                    { "quartz.serializer.type", "binary" }
                };
                StdSchedulerFactory factory = new StdSchedulerFactory(props);
                IScheduler scheduler = await factory.GetScheduler();

                // and start it off
                await scheduler.Start();

                // define the job and tie it to our HelloJob class
                IJobDetail job = JobBuilder.Create<HelloJob>()
                    .WithIdentity("job1", "group1")
                    .Build();

                // Trigger the job to run now, and then repeat every 10 seconds
                ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("trigger1", "group1")
                    .StartNow()
                    .WithSimpleSchedule(x => x
                        .WithIntervalInSeconds(10)
                        .RepeatForever())
                    .Build();

                // Tell quartz to schedule the job using our trigger
                await scheduler.ScheduleJob(job, trigger);

                // some sleep to show what's happening
                await Task.Delay(TimeSpan.FromSeconds(60));

                // and last shut down the scheduler when you are ready to close your program
                await scheduler.Shutdown();
            }
            catch (SchedulerException se)
            {
                Console.WriteLine(se);
            }
        }

        // simple log provider to get something to the console
        //public class ConsoleLogProvider : ILogProvider
        //{
        //    public Logger GetLogger(string name)
        //    {
        //        return (level, func, exception, parameters) =>
        //        {
        //            if (level >= LogLevel.Info && func != null)
        //            {
        //                Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] [" + level + "] " + func(), parameters);
        //            }
        //            return true;
        //        };
        //    }

        //    public IDisposable OpenNestedContext(string message)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public IDisposable OpenMappedContext(string key, string value)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }

    public class HelloJob : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            //await Console.Out.WriteLineAsync("Greetings from HelloJob!");

            using (var message = new System.Net.Mail.MailMessage("sinmimr@gmail.com", "sinmimr@gmail.com"))
            {
                message.Subject = "Message Subject test";
                message.Body = "Message body test at " + DateTime.Now;
                using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient
                {
                    EnableSsl = true,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    Credentials = new System.Net.NetworkCredential("sinmimr@gmail.com", "m_h_i.r19977")
                })
                {
                    await client.SendMailAsync(message);
                }
            }
        }
    }
}
