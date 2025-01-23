using System.Text.Json.Serialization;

namespace ConsultaCep.Modelo
{
    internal class Cep
    {
        [JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }
        [JsonPropertyName("bairro")]
        public string? Bairro { get; set; }
        [JsonPropertyName("localidade")]
        public string? Localidade { get; set; }
        [JsonPropertyName("uf")]
        public string? Uf { get; set; }

        public Cep(string logradouro, string bairro, string localidade, string uf)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Localidade = localidade;
            Uf = uf;
        }

        public void ExibirCep()
        {
            Console.WriteLine($"Logradouro: {Logradouro}");
            Console.WriteLine($"Bairro: {Bairro}");
            Console.WriteLine($"Cidade: {Localidade}");
            Console.WriteLine($"UF: {Uf}");
        }
    }
}
