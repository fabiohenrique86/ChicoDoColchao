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
    
    public partial class TipoPagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoPagamento()
        {
            this.PedidoTipoPagamento = new HashSet<PedidoTipoPagamento>();
        }
    
        public int TipoPagamentoID { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoTipoPagamento> PedidoTipoPagamento { get; set; }
    }
}
