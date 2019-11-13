//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChicoDoColchao.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class MovimentoCaixa
    {
        public int MovimentoCaixaID { get; set; }
        public System.DateTime DataMovimento { get; set; }
        public int LojaID { get; set; }
        public Nullable<double> Valor { get; set; }
        public int MovimentoCaixaStatusID { get; set; }
        public Nullable<System.DateTime> DataRecebimento { get; set; }
        public Nullable<int> UsuarioRecebimentoID { get; set; }
        public Nullable<int> NumeroSequencial { get; set; }
    
        public virtual Loja Loja { get; set; }
        public virtual MovimentoCaixaStatus MovimentoCaixaStatus { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}