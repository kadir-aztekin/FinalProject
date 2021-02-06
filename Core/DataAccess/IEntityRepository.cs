
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //GENERİC CONSTRAİNT : GENERIK KISIT DEMEK T OLAN YERE ENTITES DEKI URUNLER GIRILMELI  SARTLANDIRIYORUZ NERDEN GELECEGINI SEÇIYORUZ
    //class : Refarans tip 
    //IEntity : Ientity olabilir veya Ientity implemente eden bir nesne(CUSTOMER PRODUCT CATEGORY) olabilir
    //new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
        //BUTUN ABSTRAC ICINDEKI IPRODUCTDAL,ICATEGORY TEK BİR INTERFACE ICINDE TANIMLADIK 
        //HEPSİNİ TEK BİR INTERFACE ICINDE KULLANABİLİRİZ 
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        //YAZDIGIMIZ GETALL(.........) İÇİNE YAZILAN KOD (İF ELSE LİNQ ) GİBİ KOSUL BELİRTME ŞART İÇİN KULLANILIR
        //YANİ DATAYI İŞTE ADI AHMET OLAN ID Sİ 3 OLAN GETİRMEK İÇİN KULLANILIR 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        
    }
}
