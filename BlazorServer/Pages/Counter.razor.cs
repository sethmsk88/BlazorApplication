namespace BlazorServer.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private string countColor = "red";

        private void IncrementCount()
        {
            currentCount++;
        }
    }
}
