using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 3", DateTime.Now, "andrebaltieri"));
            _items.Add(new TodoItem("Tarefa 4", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("Tarefa 5", DateTime.Now, "andrebaltieri"));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_andrebaltieri()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("andrebaltieri"));
            Assert.AreEqual(2, result.Count());
        }
    }
}
