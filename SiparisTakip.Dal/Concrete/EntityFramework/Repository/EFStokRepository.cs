﻿using SiparisTakip.Dal.Abstract.StokA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiparisTakip.Entity.Models;
using SiparisTakip.Dal.Concrete.EntityFramework.Context;

namespace SiparisTakip.Dal.Concrete.EntityFramework.Repository
{
    public class EFStokRepository : IStokDal
    {
        SiparisTakipEntity ctx = new SiparisTakipEntity();

        public Stok Getir(int id)
        {
            var data = ctx.Stok.Where(x => x.StokID == id).FirstOrDefault();

            return data;
        }

        public int Guncelle(Stok nesne)
        {
            ctx.Stok.Attach(nesne);
            return ctx.SaveChanges();
        }

        public int Kaydet(Stok nesne)
        {
            ctx.Stok.Add(nesne);
            return ctx.SaveChanges();
        }

        public List<Stok> ListeGetir()
        {
            return ctx.Stok.ToList();
        }

        public Stok Sil(Stok nesne)
        {
            return ctx.Stok.Remove(nesne);
        }
    }
}
