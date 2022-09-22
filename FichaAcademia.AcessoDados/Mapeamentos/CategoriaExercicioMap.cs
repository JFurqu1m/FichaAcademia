﻿using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FichaAcademia.AcessoDados.Mapeamentos
{
    class CategoriaExercicioMap : IEntityTypeConfiguration<CategoriaExercicio>
    {
        public void Configure(EntityTypeBuilder<CategoriaExercicio> builder)
        {
            builder.HasKey(c => c.CategoriaExercicioId);

            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();

            builder.HasMany(c => c.Exercicios).WithOne(c => c.CategoriaExercicio).OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("CategoriasExercicios");
        }
    }
}
