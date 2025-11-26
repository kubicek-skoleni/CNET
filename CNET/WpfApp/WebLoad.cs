using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp;

class WebLoad
{
    public static WebResult LoadUrl(string url)
    {
        try
        {
            HttpClient client = new();
            return new WebResult()
            {
                Content = client.GetStringAsync(url).Result,
                Url = url,
                IsSuccess = true
            };
        }
        catch (AuthenticationException ex)
        {
            return new WebResult()
            {
                Url = url,
                IsSuccess = false,
                ErrorMessage = $"Chyba autentizace: {ex.Message}"
            };
        }
        catch (Exception ex)
        {
            return new WebResult()
            {
                Url = url,
                IsSuccess = false,
                ErrorMessage = $"Chyba: {ex.Message}"
            };
        }
    }
}

class WebResult
{
    public string Url { get; set; }
    public string Content { get; set; }
    public bool IsSuccess { get; set; }

    public string ErrorMessage { get; set; }

}