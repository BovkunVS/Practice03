﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo01_ModelFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ModelExibitionContainer : DbContext
    {
        public ModelExibitionContainer()
            : base("name=ModelExibitionContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Owner> OwnerSet { get; set; }
        public virtual DbSet<Company> CompanySet { get; set; }
        public virtual DbSet<Products> ProductsSet { get; set; }
        public virtual DbSet<Contract> ContractSet { get; set; }
        public virtual DbSet<Address> AddressSet { get; set; }
    }
}
