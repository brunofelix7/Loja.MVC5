namespace Loja.MVC5.Model {

    public class Categoria {

        public long Id { get; set; }
        public string Nome { get; set; }

        public Categoria() {

        }

        public Categoria(long id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString() {
            return "Categoria: " + this.Id + ", " + this.Nome;
        }
    }
}
