//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibreriaConexion
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIENDA
    {
        public TIENDA()
        {
            this.OFERTA = new HashSet<OFERTA>();
            this.VENTA = new HashSet<VENTA>();
        }
    
        public decimal ID_TIENDA { get; set; }
        public string NOMBRE_TIENDA { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public decimal ID_USERTIENDA { get; set; }
        public decimal ID_BODEGA { get; set; }
        public decimal ID_CIUDAD { get; set; }
    
        public virtual BODEGA BODEGA { get; set; }
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual ICollection<OFERTA> OFERTA { get; set; }
        public virtual USER_TIENDA USER_TIENDA { get; set; }
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}
