//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFModernVerticalMenu.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Skin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skin()
        {
            this.Operation = new HashSet<Operation>();
        }
    
        public int idSkin { get; set; }
        public Nullable<int> idClient { get; set; }
        public string AveragePrice { get; set; }
        public string ImageUrl { get; set; }
        public string LowestPrice { get; set; }
        public string Currency { get; set; }
        public string Price { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Name { get; set; }
        public Nullable<bool> SkinSold { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation> Operation { get; set; }
    }
}
