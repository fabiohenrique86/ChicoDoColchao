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
    
    public partial class ParcelaProduto
    {
        public int ParcelaProdutoID { get; set; }
        public int ParcelaID { get; set; }
        public int ProdutoID { get; set; }
        public double Preco { get; set; }
        public bool AVista { get; set; }
    
        public virtual Parcela Parcela { get; set; }
        public virtual Produto Produto { get; set; }
    }
}