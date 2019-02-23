using System;

namespace WorkflowEngine
{
    partial class Program
    {
        /* 
         * 1- Upload a video to a cloud storage.
        2- Call a web service provided by a third-party video encoding service to tell them you have 
        a video ready for encoding.
        3- Send an email to the owner of the video notifying them that the video started processing. 
        4- Change the status of the video record in the database to “Processing”.
        Each of these steps can be represented by an activity. For the purpose of this exercise, 
        do not worry about these complexities. Simply use Console.WriteLine() in each of your activity 
        classes. Your focus should be on sending a workflow to the workflow engine and having it 
        run the workflow and all the activities inside it. We don’t care about the actual activities.
        */
        public class VideoUploader : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("Activity: Uploading a video");
            }
        }
    }
}
