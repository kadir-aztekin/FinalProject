using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    //CONTEXT : DB(DATABASE) TABLOLARI İLE PROJE CLASSLARINI BAGLAMAK
    public class NorthwindContext:DbContext
    {
        //HANGİ VERİTABANI ILE ILİŞKİLİ DEMEK OVER YAZIP ONCONFI DIYINCE GELİR
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //hangi veritabanına baglanatcaksın demek (optionsbuilder.usesqlserver)
            //server=localdb\localdb\mssqllocaldb demek sql verıtabanın ısmını yazdık
            //Trusted_Connection = sifresiz kullan
            //database = nortwind olana baglan 
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        //BURADA DBSET<> YAPMAMIZIIN NEDENI SQL DEKI TABLODAKİLERİ BİZİM CLASSLARIMIZA ESITLEDIK 
        //YANİ TABLODAKİ PRODUCT,CUSTOMER,CATEGORY VSVS BIZIM ENTİTES DEKİ VERİLERE BAGLA DEMEK 
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
