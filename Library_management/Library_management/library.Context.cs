﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LibraryEntities : DbContext
    {
        public LibraryEntities()
            : base("name=LibraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<bookCategory> bookCategories { get; set; }
        public virtual DbSet<bookOfTeacher> bookOfTeachers { get; set; }
        public virtual DbSet<borrow> borrows { get; set; }
        public virtual DbSet<fineMoney> fineMoneys { get; set; }
        public virtual DbSet<returnBook> returnBooks { get; set; }
        public virtual DbSet<shift> shifts { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<staffRole> staffRoles { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<userType> userTypes { get; set; }
    }
}
