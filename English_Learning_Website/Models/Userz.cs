//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace English_Learning_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Userz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Userz()
        {
            this.Stories = new HashSet<Story>();
            this.Quiz_Detail = new HashSet<Quiz_Detail>();
        }
    
        public int User_Code { get; set; }
        public Nullable<bool> User_Category { get; set; }
        public string User_FullName { get; set; }
        public string User_Mail { get; set; }
        public string User_Password { get; set; }
        public string User_PhoneNumber { get; set; }
        public Nullable<System.DateTime> User_Birthday { get; set; }
        public string User_Gender { get; set; }
        public string User_Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Story> Stories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Quiz_Detail> Quiz_Detail { get; set; }
    }
}
