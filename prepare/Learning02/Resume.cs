public class Resume
{
    public string _memberName;
    public List<Job> jobList = new List<Job>();
    public void DisplayResume()
    {
        System.Console.WriteLine($"Name: {_memberName}");
        System.Console.WriteLine($"Jobs: ");
        foreach (Job job in jobList)
        {
            job.DisplayJobDetails();
        }
    }
}