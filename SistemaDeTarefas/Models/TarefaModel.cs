﻿namespace SistemaDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Descricao { get; set; }

        public int Status { get; set; }
    }
}
