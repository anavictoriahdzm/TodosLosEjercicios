using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Extensions.MonoHttp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterApi
{
    class Twitter
    {
        public string GetRequestToken(string key, string secret, string callBackUrl)
        {
            var client = new RestClient("https://api.twitter.com");

            client.Authenticator = OAuth1Authenticator.ForRequestToken(
                key,
                secret,
                callBackUrl
                );

            var request = new RestRequest("/oauth/request_token", Method.POST);
            var response = client.Execute(request);

            var qs = HttpUtillity.ParseQueryString(response.Content);

            string oauthToken = qs["oauth_token"];
            string ouathTokenSecret = qs["oauth_token_secret"];

            request = new RestRequest("oauth/authorize?oauth_token=" + oauthToken);

            string url = client.BuildUri(request).ToString();
            return url;
        }

        public string GetAccessToken(string key, string secret, string oauth_token, string ouath_token_secret);
    }
}
