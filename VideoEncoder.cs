using System;
namespace Workflow_Engine
{
    public class VideoEncoder : IWorkflow
    {
        public void Execute()
        {
            Upload();
            Encode();
            SendEmail();
            StatusChange();
        }
        public void Upload()
        {
            Console.WriteLine("Uploading Video");
        }
        public void Encode()
        {
            Console.WriteLine("Encoding Video");
        }
        public void SendEmail()
        {
            Console.WriteLine("Sending Email");
        }
        public void StatusChange()
        {
            Console.WriteLine("Video Processed");
        }
    }
}

