using System;
using System.Collections.Generic;
using fabiostefani.io.Muquirana.Cadastros.Domain.Categorias.Subcategorias;
using fabiostefani.io.Muquirana.Core.DomainObjects;

namespace fabiostefani.io.Muquirana.Cadastros.Domain.Categorias
{
    public class Categoria : Entity, IAggregateRoot
    {
        const string ValidacaoNome = "O campo Nome da Categoria não pode estar vazio";        
        const string ValidacaoDescricao = "O campo Descrição não pode estar vazio";

        public string Nome { get; private set; }        
        public string Descricao { get; private set; }
        public bool Ativo { get; set; }

         private readonly List<Subcategoria> _subcategorias;
         public IReadOnlyCollection<Subcategoria> Subcategorias => _subcategorias;

        public Categoria(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
            _subcategorias = new List<Subcategoria>();
            Ativar();
            Validar();
        }

        protected Categoria() { }

        public override string ToString()
        {
            return $"{Nome}";
        }

        public void Ativar() => Ativo = true;

        public void Desativar() => Ativo = false;

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, ValidacaoNome);            
            Validacoes.ValidarSeVazio(Descricao, ValidacaoDescricao);
        }
    }
}