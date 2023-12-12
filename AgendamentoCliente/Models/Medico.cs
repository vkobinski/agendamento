namespace AgendamentoCliente.Models
{
    public class Medico
    {
        public long MedicoId { get; set; }
        public string NomeCompleto { get; set; }
        public bool Ativo { get; set; }
        public byte[] Foto { get; set; }

    }

    public class Paciente
    {
        public long PacienteId { get; set; }
        public string NomeCompleto { get; set; }

        public DateOnly DataNascimento { get; set; }
        public bool ativo { get; set; }
    }
    public class Usuario
    {
        public long idUsuario { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public Medico medico { get; set; }

    }

    public class Atendimento
    {
        public long AtendimentoId { get; set; }

        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public string DataAtendimento { get; set; }
        public bool Chegou { get; set; }
    }
}
