using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using KaiiCosmeticos.Sistema.Models;

namespace KaiiCosmeticos.Sistema.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KaiiCosmeticos.Sistema.Models.Despesa> Despesa { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Cliente> Cliente { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Endereco> Endereco { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Frete> Frete { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.PedidoVendas> PedidoVendas { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Produto> Produto { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Promocoes> Promocoes { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.TipoPagamento> TipoPagamento { get; set; }
        public DbSet<KaiiCosmeticos.Sistema.Models.Transportadora> Transportadora { get; set; }
    }
}
