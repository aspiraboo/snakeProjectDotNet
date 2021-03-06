﻿using BlogFelipe.DB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogFelipe.DB.Mapeamentos
{
    public class DownlaodConfig : EntityTypeConfiguration<Download>
    {
        public DownlaodConfig()
        {
            ToTable("DOWNLOAD");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasColumnName("IDDOWNLOAD")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.sIP)
                .HasColumnName("IP")
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.dDataHora)
                .HasColumnName("DATAHORA")
                .IsRequired();

            Property(x => x.iDArquivo)
                .HasColumnName("IDARQUIVO")
                .IsRequired();

            HasRequired(x => x.Arquivo)
                .WithMany()
                .HasForeignKey(x => x.iDArquivo);
        }
    }
}
