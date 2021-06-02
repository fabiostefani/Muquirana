using System;
using fabiostefani.io.Muquirana.Core.DomainObjects;
namespace fabiostefani.io.Muquirana.Cadastros.Domain.Categorias.Subcategorias
{
    public class Subcategoria : Entity
    {
        const string ValidacaoNome = "O campo Nome não deve ser vazio.";
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public Guid CodigoCategoria { get; private set; }
        public Categoria Categoria { get; private set; }

        public Subcategoria(string nome)
        {
            Nome = nome;
            Ativar();
            Validar();
        }

        protected Subcategoria( ) { }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, ValidacaoNome);
        }
    }
}