namespace AppEmpresa.Data;
using System.Text.Json.Serialization;
    public class Puesto
    {
        [JsonPropertyName("idpuesto")]
        public Int16 Idpuesto { get; set; }
        [JsonPropertyName("puestos")]
        public string? Puestos { get; set; }
    }