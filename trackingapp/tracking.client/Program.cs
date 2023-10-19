using System.Net.Http.Headers;
using System.Net.Http.Json;
using tracking.client; 

HttpClient client = new();

client.BaseAddress = new Uri("https://localhost:7046");
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

HttpResponseMessage response = await client.GetAsync("api/issue");
response.EnsureSuccessStatusCode(); 

if (response.IsSuccessStatusCode)
{
    var issues = await response.Content.ReadFromJsonAsync<IEnumerable<IssueDto>>();

    if (issues.Any())
    {
        foreach (var issue in issues)
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine(issue.Title);
            Console.WriteLine(issue.Description);
            Console.WriteLine(issue.Priority.ToString());
            Console.WriteLine(issue.IssueType.ToString());
            Console.WriteLine(issue.Created.ToString());
            Console.WriteLine(issue.Completed.ToString());
            Console.WriteLine("----------------------------------");


        }
    } 
    else
    {
        Console.WriteLine("No data to display");
    }

}
else
{
    Console.WriteLine("No results");
}




Console.ReadLine();



