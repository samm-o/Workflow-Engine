using System;
namespace Workflow_Engine
{
    public class WorkflowEngine
    {
        public IWorkflow Workflow { get; set; }
        public WorkflowEngine(IWorkflow workflow)
        {
            Workflow = workflow;
        }
        public void Run()
        {
            Workflow.Execute();
        }
    }
}
