﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SkinMarketEntities : DbContext
    {
        public SkinMarketEntities()
            : base("name=SkinMarketEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ClientInformation> ClientInformation { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Skin> Skin { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}