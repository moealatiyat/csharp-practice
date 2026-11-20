public class Program
{
    public async Task DownloadDataAsync()
    {
        try
        {
        System.Console.WriteLine("Download Started....");
        await Task.Delay(3000);
        throw new Exception("Network Error");
        System.Console.WriteLine("Download Completed");
        

        } 
        catch (Exception ex)
        {
            System.Console.WriteLine("Network Error");
        }       
       
    }

        public async Task DownloadDataAsync2()
    {
        System.Console.WriteLine("Download 2 Started....");
        await Task.Delay(5000);
        System.Console.WriteLine("Download 2 Completed");

    }
    public static async Task Main(string[] args)
    {
        Program p = new Program();
        await Task.WhenAll(p.DownloadDataAsync(), p.DownloadDataAsync2());
    }
}