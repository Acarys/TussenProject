namespace TussenTijdProject.Client.Helpers;

public static class HttpClientExtensions
{
    public static HttpClient Configure(this HttpClient client)
    {
        client.BaseAddress = new Uri(AppSettings.ApiBaseAddress);
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        return client;
    }
}
