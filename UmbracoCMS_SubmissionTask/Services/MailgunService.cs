using System.Text;

namespace UmbracoCMS_SubmissionTask.Services;

public class MailgunService
{
    private static readonly HttpClient client = new();

    public static async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var apiKey = "895f5e0a2b0c73719e2bd7b908fe7735-5dcb5e36-835edbc3";
        var domain = "sandbox9a325bb20e1b48d1aabed7af251ba179.mailgun.org";
        var fromEmail = "mailgun@sandbox9a325bb20e1b48d1aabed7af251ba179.mailgun.org";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri($"https://api.mailgun.net/v3/{domain}/messages"),
            Headers =
            {
                { "Authorization", "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes("api:" + apiKey)) }
            },
            Content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("from", $"Excited User <{fromEmail}>"),
                new KeyValuePair<string, string>("to", toEmail),
                new KeyValuePair<string, string>("subject", subject),
                new KeyValuePair<string, string>("text", body)
            })
        };

        try
        {
            var response = await client.SendAsync(request);
            var responseString = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Mail sent successfully.");
            Console.WriteLine(responseString);
        }
        catch
        {
            Console.WriteLine("Failed to send email.");
        }
    }
}
