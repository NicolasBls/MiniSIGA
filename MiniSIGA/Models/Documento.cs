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
    
    public partial class Documento
    {
        public int DocumentoId { get; set; }
        public int PessoaId { get; set; }
        public int DocumentoTipoId { get; set; }
        public string Numero { get; set; }
        public string OrgaoExpedidor { get; set; }
        public Nullable<System.DateTime> DataExpedicao { get; set; }
        public int StatusId { get; set; }
    
        public virtual DocumentoTipo DocumentoTipo { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual Status Status { get; set; }
    }
}
