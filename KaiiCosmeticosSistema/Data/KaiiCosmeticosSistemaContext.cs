using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KaiiCosmeticosSistema.Models;

namespace KaiiCosmeticosSistema.Data
{
    public class KaiiCosmeticosSistemaContext : DbContext
    {
        public KaiiCosmeticosSistemaContext (DbContextOptions<KaiiCosmeticosSistemaContext> options)
            : base(options)
        {
        }

        public DbSet<KaiiCosmeticosSistema.Models.Cliente> Cliente { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Despesa> Despesa { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Endereco> Endereco { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Fornecedor> Fornecedor { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Frete> Frete { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Produto> Produto { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Promocoes> Promocoes { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.TipoPagamento> TipoPagamento { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.Transportadora> Transportadora { get; set; }

        public DbSet<KaiiCosmeticosSistema.Models.PedidoVendas> PedidoVendas { get; set; }
    }
}
