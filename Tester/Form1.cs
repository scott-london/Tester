using System;
using System.Json;
using System.Net.Http;
using System.Windows.Forms;

using Octokit;

namespace Tester
{
    public partial class Form1 : Form
    {
        //github-rd.carefusion.com
        //const string CLIENT_ID = "cbba4fab68793ec8390b";
        //const string CLIENT_SECRET = "b09adb2cfe8c044c5f3d766ea8168ee008b4fac1";

        //github.com
        const string CLIENT_ID = "6ffd31e5f9c828b1087d";
        const string CLIENT_SECRET = "119e5b0efc467325be1e62e84176b96df28c6ff6";

        const string APP_NAME = "Tester";
        const string GITHUB_URI = "https://github.com";

        //TESTING
        static string address = "http://api.worldbank.org/countries?format=json";

        bool connected = false;
        string accessToken = "";
        static Uri gitUri = new Uri(GITHUB_URI);
        GitHubClient client = new GitHubClient(new ProductHeaderValue(APP_NAME), gitUri);

        public Form1()
        {
            InitializeComponent();
        }

        private void connect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!connected)
                Connect();
            else
                Disconnect();
        }

        private async void Connect()
        {
            if (!string.IsNullOrEmpty(accessToken))
            {
                client.Credentials = new Credentials(accessToken);
            }

            try
            {
                var repostiories = await client.Repository.GetAllForCurrent();
                var brake = 0;
            }
            catch (AuthorizationException)
            {
                //make a request to the authorization page
                var url = GetOAuthLogin();
                var navi = System.Net.WebUtility.UrlDecode(url.OriginalString);
                oAuthBrowser.Navigate(navi);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString(), "FUCK", MessageBoxButtons.OK);
            }

            #region Test Request
            /************TEST REQUEST**********************************************/
            /*//create a web request.  You will need to look at how crawlr uses REST for octo deploy
            var request = new HttpClient();
            

            HttpResponseMessage response = await request.GetAsync(GITHUB_URI);
            
            response.EnsureSuccessStatusCode();

            var contents = await response.Content.ReadAsStreamAsync();


            //var array = JsonArray.Load(contents);
            //for (int i = 0; i < array[1].Count; i++)
            //{
            //    string id = array[1][i]["id"].ToString();
            //    string name = array[1][i]["name"].ToString();
            //}
            
            */
            #endregion


            connectStatus.Text = "Connected";
            connected = true;
        }

        private Uri GetOAuthLogin()
        {
            var csrf = System.Web.Security.Membership.GeneratePassword(24, 1);
            var request = new OauthLoginRequest(CLIENT_ID)
            {
                
            };
            var uri = client.Oauth.GetGitHubLoginUrl(request);
            return uri;
        }

        private void Disconnect()
        {
            connectStatus.Text = "Disconneted";
            connected = false;
        }
    }
}
