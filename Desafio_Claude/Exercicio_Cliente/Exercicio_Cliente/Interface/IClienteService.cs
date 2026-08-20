namespace Exercicio_Cliente.Interface
{
    public interface IClienteService
    {
        Cliente? ObterPorId(int id);
        List<Cliente> ObterTodos();

        Cliente Adicionar(ClienteCreateDto novoCliente);
    }

    public class ClienteService : IClienteService
    {
        private readonly List<Cliente> _clientes = new()
    {
        new Cliente(1, "Felipe Cruz", "felipe@email.com"),
        new Cliente(2, "Ana Souza", "ana@email.com")
    };

        public Cliente? ObterPorId(int id) =>
            _clientes.FirstOrDefault(c => c.Id == id);

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }

        public Cliente Adicionar(ClienteCreateDto novoCliente)
        {
            var novoId = _clientes.Max(c => c.Id) + 1;
            var cliente = new Cliente(novoId, novoCliente.Nome, novoCliente.Email);
            _clientes.Add(cliente);
            return cliente;
        }
    }

    public record Cliente(int Id, string Nome, string Email);
    public record ClienteDto(int Id, string Nome, string Email);
    public record ClienteCreateDto(string Nome, string Email);
}
