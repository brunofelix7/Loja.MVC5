namespace Loja.MVC5.Model {

    public class Fabricante {

        public long Id { get; set; }
        public string Nome { get; set; }

        public Fabricante() {

        }

        public Fabricante(long id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }

        public override string ToString() {
            return "Fabricante: " + this.Id + ", " + this.Nome;
        }

    }
}
