//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mavtozavr
{
    using System;
    using System.Collections.Generic;
    
    public partial class Devices
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Devices()
        {
            this.Kits = new HashSet<Kits>();
        }
    
        public System.Guid Id { get; set; }
        public int DeviceType { get; set; }
        public string SerialNumber { get; set; }
        public string InventoryNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kits> Kits { private get; set; }
    }
}