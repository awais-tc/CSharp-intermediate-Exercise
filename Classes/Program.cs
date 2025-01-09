using System;
using System.Diagnostics;
using Classes;

namespace Classes
{
    //public class DbMigrator
    //{
    //    private readonly Logger _logger;
    //    public DbMigrator(Logger logger)
    //    {
    //        _logger = logger;
    //    }
    //    public void Migrate()
    //    {
    //        _logger.Log("We are migrating blah blah blah...");
    //    }
    //}

    public class UploadVideoActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to cloud storage...");
        }
    }

    public class NotifyVideoProcessingActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending notification: Video is being processed...");
        }
    }

    public class ChangeVideoStatusActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing video status to 'Processing' in the database...");
        }
    }

    public class CallEncodingServiceActivity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party video encoding service...");
        }
    }

    public class Workflow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }

    // Define the WorkflowEngine class
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }






    class Program
    {
        static void Main(string[] args)
        {
            //var title = "The New Beginning";
            //var description = "This is the description of the post";
            //var post = new Post(title, description);
            //post.UpVote();
            //post.UpVote();
            //post.UpVote();
            //post.DownVote();
            //post.Display();

            //var DbMigrator = new DbMigrator(new Logger());
            //DbMigrator.Migrate();

            //var stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);
            //stack.Push(7);
            //stack.Push(8);
            //stack.Push(9);
            //stack.Push(10);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //stack.Clear();

            //var sql = new SqlConnection("localhost/1526");
            //var db = new DbCommand(sql);
            //db.Execute("fetch Api");
            //Console.WriteLine("Connection from SQL CLASS");
            //sql.Open();
            //sql.Close();
            //var oracle = new OracleConnection("localhost/1526");
            //Console.WriteLine("Connection from ORACLE CLASS");
            //oracle.Open();
            //oracle.Close();


            var workflow = new Workflow();
            workflow.AddActivity(new UploadVideoActivity());
            workflow.AddActivity(new NotifyVideoProcessingActivity());
            workflow.AddActivity(new ChangeVideoStatusActivity());
            workflow.AddActivity(new CallEncodingServiceActivity());

            // Create and run the workflow engine
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);


        }
    }
}
