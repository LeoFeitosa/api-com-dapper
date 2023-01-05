using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasApi.Data;

[Table("tarefas")]
public record Tarefas(int Id, string Atividade, string Status);