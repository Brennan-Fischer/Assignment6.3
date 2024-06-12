namespace Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CallQueue callQueue = new CallQueue();
            callQueue.Add();
            callQueue.Add();
            callQueue.Answer();
        }
    }
}
