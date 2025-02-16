//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniSIGA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pessoa()
        {
            this.Aula = new HashSet<Aula>();
            this.Avaliacao = new HashSet<Avaliacao>();
            this.Curso = new HashSet<Curso>();
            this.Disciplina = new HashSet<Disciplina>();
            this.Documento = new HashSet<Documento>();
            this.Endereco = new HashSet<Endereco>();
            this.Falta = new HashSet<Falta>();
            this.NotaAluno = new HashSet<NotaAluno>();
            this.Pessoa1 = new HashSet<Pessoa>();
            this.PessoaDisciplina = new HashSet<PessoaDisciplina>();
        }
    
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public System.DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public int AcessoId { get; set; }
        public Nullable<int> PessoaAcessoId { get; set; }
        public System.DateTime DataCadastro { get; set; }
        public string Senha { get; set; }
        public Nullable<int> SatusId { get; set; }
    
        public virtual Acesso Acesso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aula> Aula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avaliacao> Avaliacao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Curso> Curso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Disciplina> Disciplina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Endereco> Endereco { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Falta> Falta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaAluno> NotaAluno { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pessoa> Pessoa1 { get; set; }
        public virtual Pessoa Pessoa2 { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaDisciplina> PessoaDisciplina { get; set; }
    }
}
