//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_management
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            this.bookOfTeachers = new HashSet<bookOfTeacher>();
            this.borrows = new HashSet<borrow>();
            this.returnBooks = new HashSet<returnBook>();
        }
    
        public int id { get; set; }
        public Nullable<int> type { get; set; }
        public string lname { get; set; }
        public string fname { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string gender { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public byte[] img { get; set; }
    
        public virtual account account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bookOfTeacher> bookOfTeachers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrow> borrows { get; set; }
        public virtual fineMoney fineMoney { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<returnBook> returnBooks { get; set; }
        public virtual staff staff { get; set; }
        public virtual userType userType { get; set; }
    }
}
