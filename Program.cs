using System;

namespace Workflow_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new WorkflowEngine(new VideoEncoder());
            engine.Run();
        }
    }
}
