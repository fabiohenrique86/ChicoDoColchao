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
    
    public partial class PedidoProduto
    {
        public int PedidoProdutoID { get; set; }
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }
        public short Quantidade { get; set; }
        public string Medida { get; set; }
        public double Preco { get; set; }
    
        public virtual Pedido Pedido { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
