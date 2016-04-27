﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Luna.Models.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int Account_Create(string loginid, string passwd, string email, Nullable<byte> userlevel, string id_sexType, string code)
        {
            var loginidParameter = loginid != null ?
                new ObjectParameter("loginid", loginid) :
                new ObjectParameter("loginid", typeof(string));
    
            var passwdParameter = passwd != null ?
                new ObjectParameter("passwd", passwd) :
                new ObjectParameter("passwd", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var userlevelParameter = userlevel.HasValue ?
                new ObjectParameter("userlevel", userlevel) :
                new ObjectParameter("userlevel", typeof(byte));
    
            var id_sexTypeParameter = id_sexType != null ?
                new ObjectParameter("id_sexType", id_sexType) :
                new ObjectParameter("id_sexType", typeof(string));
    
            var codeParameter = code != null ?
                new ObjectParameter("code", code) :
                new ObjectParameter("code", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Account_Create", loginidParameter, passwdParameter, emailParameter, userlevelParameter, id_sexTypeParameter, codeParameter);
        }
    }
}
