//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatchShop_Vasilyev_isp27
{
    using System;
    using System.Collections.Generic;
    
    public partial class Продажа
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продажа()
        {
            this.Состав_Продажи = new HashSet<Состав_Продажи>();
        }
    
        public int ID_Продажа { get; set; }
        public Nullable<System.DateTime> Дата { get; set; }
        public Nullable<int> ID_Сотрудника { get; set; }
    
        public virtual Сотрудники Сотрудники { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Состав_Продажи> Состав_Продажи { get; set; }
    }
}
