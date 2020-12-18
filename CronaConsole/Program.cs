using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoronaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(
              "https://services7.arcgis.com/mOBPykOjAyBO2ZKk/arcgis/rest/services/RKI_Landkreisdaten/FeatureServer/0/query?where=OBJECTID%20%3E%3D%20305%20AND%20OBJECTID%20%3C%3D%20310&outFields=*&outSR=4326&f=json");

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;

            // Get the response.
            WebResponse response = request.GetResponse();

            // Display the status.
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            string sJson;

            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();

                // Display the content.
                //Console.WriteLine(responseFromServer);
                sJson = responseFromServer;
            }

            // Close the response.
            response.Close();

            var Corona = JsonConvert.DeserializeObject<CoronaObject.root>(sJson);
            foreach (CoronaObject.Feature feature in Corona.features) { 
                
                if (feature.attributes.OBJECTID == 310 || feature.attributes.OBJECTID == 305)
                {
                    Console.WriteLine("Corona Daten - " + feature.attributes.GEN + " " + feature.attributes.BEZ);
                    Console.WriteLine("   Einwohnerzahl: " + feature.attributes.EWZ);
                    Console.WriteLine("   7 Tages Inz.:  " + feature.attributes.cases7_per_100k);
                    Console.WriteLine("   Fälle Insg.:   " + feature.attributes.cases);
                    Console.WriteLine("   Tote Insg.:    " + feature.attributes.deaths);
                    Console.WriteLine("   Sterberate     " + feature.attributes.death_rate);

                    Console.WriteLine("     7 Tage Fälle: " + feature.attributes.cases7_lk);
                    Console.WriteLine("     7 Tage Tote:  " + feature.attributes.death7_lk);

                    Console.WriteLine("");
                }
                
            }

        }

    }
}
