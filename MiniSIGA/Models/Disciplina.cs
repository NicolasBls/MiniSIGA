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
    
    public partial class Disciplina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Disciplina()
        {
            this.Aula = new HashSet<Aula>();
            this.PessoaDisciplina = new HashSet<PessoaDisciplina>();
            this.DisciplinaCurso = new HashSet<DisciplinaCurso>();
        }
    
        public int DisciplinaId { get; set; }
        public string Descricao { get; set; }
        public int PessoaId { get; set; }
        public Nullable<int> StatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aula> Aula { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PessoaDisciplina> PessoaDisciplina { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Status Status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplinaCurso> DisciplinaCurso { get; set; }
    }
}
