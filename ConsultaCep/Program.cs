using System.Text.Json;
using ConsultaCep.Modelo;

using (HttpClient client = new HttpClient())
{
    try
    {
        int cep = 29124337;

        string resposta = await client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
        Cep endereco = JsonSerializer.Deserialize<Cep>(resposta);
        endereco.ExibirCep();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro foi encontrado: {ex.Message}");
    }
}
