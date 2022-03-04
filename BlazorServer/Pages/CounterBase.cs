using Microsoft.AspNetCore.Components;

namespace BlazorServer.Pages
{
    // Using the Base Class approacch to split the HTML and C# code
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        protected string countColor = "red";

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
