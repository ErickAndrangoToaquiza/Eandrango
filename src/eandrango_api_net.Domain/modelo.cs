namespace eandrango_api_net.Domain;

public class Modelo 
{
   public string RestCliente (){
var client = new RestClient("https://rickandmortyapi.com/api/character");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
   };
}