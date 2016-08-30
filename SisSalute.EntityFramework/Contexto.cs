using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisSalute.Modelo;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisSalute.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var mapClientes = modelBuilder.Entity<Clientes>();
            mapClientes.Property(x => x.codCliente)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            mapClientes.Property(x => x.nome)
                .IsRequired();
            mapClientes.Property(x => x.cpf)
                .IsOptional();
            mapClientes.Property(x => x.numEndereco)
                .IsOptional();
            mapClientes.Property(x => x.compEndereco)
                .IsOptional();
            mapClientes.Property(x => x.telefone)
                .IsOptional();
            mapClientes.Property(x => x.celular1)
                .IsOptional();
            mapClientes.Property(x => x.celular2)
                .IsOptional();
            mapClientes.Property(x => x.email)
                .IsOptional();
            mapClientes.Property(x => x.facebook)
                .IsOptional();
            mapClientes.Property(x => x.profissao)
                .IsOptional();
            mapClientes.Property(x => x.estadoCivil)
                .IsOptional();
            mapClientes.Property(x => x.sexo)
                .IsOptional();
            mapClientes.Property(x => x.dataNascimento)
                .IsOptional();
            mapClientes.Property(x => x.dataCadastro)
                .IsOptional();
            mapClientes.HasKey(x => x.codCliente);
            mapClientes.ToTable("Clientes");
        }
    }
}
