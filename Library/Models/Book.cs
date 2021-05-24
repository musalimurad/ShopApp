//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Book_To_Authors = new HashSet<Book_To_Authors>();
            this.Book_To_Readers = new HashSet<Book_To_Readers>();
        }
    
        public int BookID { get; set; }
        public string Bookname { get; set; }
        public Nullable<System.DateTime> Purchasedate { get; set; }
        public Nullable<int> Publish_ID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Typeof_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_To_Authors> Book_To_Authors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_To_Readers> Book_To_Readers { get; set; }
        public virtual Publishing Publishing { get; set; }
        public virtual TypeOfBook TypeOfBook { get; set; }
    }
}
