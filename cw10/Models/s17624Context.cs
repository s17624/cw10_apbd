using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cw10.Models
{
    public partial class s17624Context : DbContext
    {
        public s17624Context()
        {
        }

        public s17624Context(DbContextOptions<s17624Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Budzet> Budzet { get; set; }
        public virtual DbSet<Championships> Championships { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<DeliveryAddreses> DeliveryAddreses { get; set; }
        public virtual DbSet<DeliveryMethods> DeliveryMethods { get; set; }
        public virtual DbSet<Dept> Dept { get; set; }
        public virtual DbSet<Emp> Emp { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Gosc> Gosc { get; set; }
        public virtual DbSet<Kategoria> Kategoria { get; set; }
        public virtual DbSet<Magazyn> Magazyn { get; set; }
        public virtual DbSet<Miejscowosc> Miejscowosc { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Osoba> Osoba { get; set; }
        public virtual DbSet<Players> Players { get; set; }
        public virtual DbSet<Pokoj> Pokoj { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<PromoDetails> PromoDetails { get; set; }
        public virtual DbSet<Promos> Promos { get; set; }
        public virtual DbSet<Rezerwacja> Rezerwacja { get; set; }
        public virtual DbSet<Salgrade> Salgrade { get; set; }
        public virtual DbSet<Sizes> Sizes { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<ZwiazekMalzenski> ZwiazekMalzenski { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=db-mssql;Initial Catalog=s17624;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brands>(entity =>
            {
                entity.HasKey(e => e.IdBrand)
                    .HasName("Brands_pk");

                entity.Property(e => e.IdBrand)
                    .HasColumnName("idBrand")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Budzet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("budzet");

                entity.Property(e => e.Wartosc).HasColumnName("wartosc");
            });

            modelBuilder.Entity<Championships>(entity =>
            {
                entity.HasKey(e => e.IdChampionship);

                entity.Property(e => e.OfficialName).HasMaxLength(100);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.IdClient)
                    .HasName("Client_pk");

                entity.Property(e => e.IdClient)
                    .HasColumnName("idClient")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDay)
                    .HasColumnName("birthDay")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registrationDate")
                    .HasColumnType("date");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryAddreses>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("DeliveryAddreses_pk");

                entity.Property(e => e.IdAddress)
                    .HasColumnName("idAddress")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddresField1)
                    .IsRequired()
                    .HasColumnName("addresField1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddresField2)
                    .IsRequired()
                    .HasColumnName("addresField2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddresField3)
                    .IsRequired()
                    .HasColumnName("addresField3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId).HasColumnName("clientId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.DeliveryAddreses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("DeliveryAddreses_Client");
            });

            modelBuilder.Entity<DeliveryMethods>(entity =>
            {
                entity.HasKey(e => e.IdMethod)
                    .HasName("DeliveryMethods_pk");

                entity.Property(e => e.IdMethod)
                    .HasColumnName("idMethod")
                    .ValueGeneratedNever();

                entity.Property(e => e.MetName)
                    .IsRequired()
                    .HasColumnName("metName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.Deptno)
                    .HasName("PK__DEPT__E0EB08D73FF60A6B");

                entity.ToTable("DEPT");

                entity.Property(e => e.Deptno)
                    .HasColumnName("DEPTNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dname)
                    .HasColumnName("DNAME")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Loc)
                    .HasColumnName("LOC")
                    .HasMaxLength(13)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emp>(entity =>
            {
                entity.HasKey(e => e.Empno)
                    .HasName("PK__EMP__14CCF2EE3593CC8A");

                entity.ToTable("EMP");

                entity.Property(e => e.Empno)
                    .HasColumnName("EMPNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comm).HasColumnName("COMM");

                entity.Property(e => e.Deptno).HasColumnName("DEPTNO");

                entity.Property(e => e.Ename)
                    .HasColumnName("ENAME")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hiredate)
                    .HasColumnName("HIREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Job)
                    .HasColumnName("JOB")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Mgr).HasColumnName("MGR");

                entity.Property(e => e.Sal).HasColumnName("SAL");

                entity.HasOne(d => d.DeptnoNavigation)
                    .WithMany(p => p.Emp)
                    .HasForeignKey(d => d.Deptno)
                    .HasConstraintName("FK__EMP__DEPTNO__3C69FB99");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasKey(e => e.IdEnrollment)
                    .HasName("Enrollment_pk");

                entity.Property(e => e.IdEnrollment).ValueGeneratedNever();

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.IdStudyNavigation)
                    .WithMany(p => p.Enrollment)
                    .HasForeignKey(d => d.IdStudy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Enrollment_Studies");
            });

            modelBuilder.Entity<Gosc>(entity =>
            {
                entity.HasKey(e => e.IdGosc)
                    .HasName("PK__Gosc__8126AB6D705E7FFB");

                entity.Property(e => e.IdGosc).ValueGeneratedNever();

                entity.Property(e => e.Imie)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Nazwisko)
                    .IsRequired()
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ProcentRabatu).HasColumnName("Procent_rabatu");
            });

            modelBuilder.Entity<Kategoria>(entity =>
            {
                entity.HasKey(e => e.IdKategoria)
                    .HasName("PK__Kategori__31412B26488DBDEA");

                entity.Property(e => e.IdKategoria).ValueGeneratedNever();

                entity.Property(e => e.Cena).HasColumnType("money");

                entity.Property(e => e.Nazwa)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Magazyn>(entity =>
            {
                entity.HasKey(e => e.Idpozycji)
                    .HasName("PK__MAGAZYN__61D1D0D0936D30FF");

                entity.ToTable("MAGAZYN");

                entity.Property(e => e.Idpozycji)
                    .HasColumnName("IDPOZYCJI")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ilosc).HasColumnName("ILOSC");

                entity.Property(e => e.Nazwa)
                    .HasColumnName("NAZWA")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Miejscowosc>(entity =>
            {
                entity.HasKey(e => e.IdMiejscowosci)
                    .HasName("PK__Miejscow__B9B2E836B483F8DD");

                entity.Property(e => e.IdMiejscowosci)
                    .HasColumnName("Id_Miejscowosci")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nazwa)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Offer>(entity =>
            {
                entity.HasKey(e => e.IdProdOffer)
                    .HasName("Offer_pk");

                entity.Property(e => e.IdProdOffer)
                    .HasColumnName("idProdOffer")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.IdSize).HasColumnName("idSize");

                entity.Property(e => e.OnStock).HasColumnName("onStock");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Offer_Products");

                entity.HasOne(d => d.IdSizeNavigation)
                    .WithMany(p => p.Offer)
                    .HasForeignKey(d => d.IdSize)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Offer_Sizes");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.IdOrder, e.IdProdOffer })
                    .HasName("OrderDetails_pk");

                entity.Property(e => e.IdOrder).HasColumnName("idOrder");

                entity.Property(e => e.IdProdOffer).HasColumnName("idProdOffer");

                entity.Property(e => e.InOrder).HasColumnName("inOrder");

                entity.HasOne(d => d.IdOrderNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdOrder)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetails_Orders");

                entity.HasOne(d => d.IdProdOfferNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.IdProdOffer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("OrderDetails_Offer");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("Orders_pk");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("idOrder")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdAddress).HasColumnName("idAddress");

                entity.Property(e => e.IdClient).HasColumnName("idClient");

                entity.Property(e => e.IdMethod).HasColumnName("idMethod");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("orderDate")
                    .HasColumnType("date");

                entity.Property(e => e.OrderFinish)
                    .HasColumnName("orderFinish")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdAddressNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdAddress)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Orders_DeliveryAddreses");

                entity.HasOne(d => d.IdClientNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdClient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Orders_Client");

                entity.HasOne(d => d.IdMethodNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.IdMethod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Orders_DeliveryMethods");
            });

            modelBuilder.Entity<Osoba>(entity =>
            {
                entity.HasKey(e => e.Pesel)
                    .HasName("PK__Osoba__48A5F7162198C677");

                entity.Property(e => e.Pesel)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DataUrodzenia)
                    .HasColumnName("Data_Urodzenia")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZgonu)
                    .HasColumnName("Data_Zgonu")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imie)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Matka)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MiejsceUrodzenia).HasColumnName("Miejsce_Urodzenia");

                entity.Property(e => e.Nazwisko)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Ojciec)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Plec)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.MatkaNavigation)
                    .WithMany(p => p.InverseMatkaNavigation)
                    .HasForeignKey(d => d.Matka)
                    .HasConstraintName("FK__Osoba__Matka__2E1BDC42");

                entity.HasOne(d => d.MiejsceUrodzeniaNavigation)
                    .WithMany(p => p.Osoba)
                    .HasForeignKey(d => d.MiejsceUrodzenia)
                    .HasConstraintName("FK__Osoba__Miejsce_U__2D27B809");

                entity.HasOne(d => d.OjciecNavigation)
                    .WithMany(p => p.InverseOjciecNavigation)
                    .HasForeignKey(d => d.Ojciec)
                    .HasConstraintName("FK__Osoba__Ojciec__2F10007B");
            });

            modelBuilder.Entity<Players>(entity =>
            {
                entity.HasKey(e => e.IdPlayer);

                entity.Property(e => e.FirstName).HasMaxLength(30);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<Pokoj>(entity =>
            {
                entity.HasKey(e => e.NrPokoju)
                    .HasName("PK__Pokoj__18804ABED5192783");

                entity.Property(e => e.NrPokoju).ValueGeneratedNever();

                entity.Property(e => e.LiczbaMiejsc).HasColumnName("Liczba_miejsc");

                entity.HasOne(d => d.IdKategoriaNavigation)
                    .WithMany(p => p.Pokoj)
                    .HasForeignKey(d => d.IdKategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Pokoj__IdKategor__4E88ABD4");
            });

            modelBuilder.Entity<ProductTypes>(entity =>
            {
                entity.HasKey(e => e.IdType)
                    .HasName("ProductTypes_pk");

                entity.Property(e => e.IdType)
                    .HasColumnName("idType")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdParentType).HasColumnName("idParentType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdParentTypeNavigation)
                    .WithMany(p => p.InverseIdParentTypeNavigation)
                    .HasForeignKey(d => d.IdParentType)
                    .HasConstraintName("ProductTypes_ProductTypes");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("Products_pk");

                entity.Property(e => e.IdProduct)
                    .HasColumnName("idProduct")
                    .ValueGeneratedNever();

                entity.Property(e => e.BasePrice)
                    .HasColumnName("basePrice")
                    .HasColumnType("numeric(7, 2)");

                entity.Property(e => e.IdBrand).HasColumnName("idBrand");

                entity.Property(e => e.IdProdType).HasColumnName("idProdType");

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasColumnName("prodName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBrandNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdBrand)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_Brands");

                entity.HasOne(d => d.IdProdTypeNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdProdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Products_ProductTypes");
            });

            modelBuilder.Entity<PromoDetails>(entity =>
            {
                entity.HasKey(e => new { e.IdPromo, e.IdProduct })
                    .HasName("PromoDetails_pk");

                entity.Property(e => e.IdPromo).HasColumnName("idPromo");

                entity.Property(e => e.IdProduct).HasColumnName("idProduct");

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("numeric(4, 2)");

                entity.HasOne(d => d.IdProductNavigation)
                    .WithMany(p => p.PromoDetails)
                    .HasForeignKey(d => d.IdProduct)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PromoDetails_Products");

                entity.HasOne(d => d.IdPromoNavigation)
                    .WithMany(p => p.PromoDetails)
                    .HasForeignKey(d => d.IdPromo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PromoDetails_Promos");
            });

            modelBuilder.Entity<Promos>(entity =>
            {
                entity.HasKey(e => e.IdPromo)
                    .HasName("Promos_pk");

                entity.Property(e => e.IdPromo)
                    .HasColumnName("idPromo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PromoEnd)
                    .HasColumnName("promoEnd")
                    .HasColumnType("date");

                entity.Property(e => e.PromoStart)
                    .HasColumnName("promoStart")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<Rezerwacja>(entity =>
            {
                entity.HasKey(e => e.IdRezerwacja)
                    .HasName("PK__Rezerwac__68F5E186D8A41D9B");

                entity.Property(e => e.IdRezerwacja).ValueGeneratedNever();

                entity.Property(e => e.DataDo).HasColumnType("datetime");

                entity.Property(e => e.DataOd).HasColumnType("datetime");

                entity.HasOne(d => d.IdGoscNavigation)
                    .WithMany(p => p.Rezerwacja)
                    .HasForeignKey(d => d.IdGosc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezerwacj__IdGos__5165187F");

                entity.HasOne(d => d.NrPokojuNavigation)
                    .WithMany(p => p.Rezerwacja)
                    .HasForeignKey(d => d.NrPokoju)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Rezerwacj__NrPok__52593CB8");
            });

            modelBuilder.Entity<Salgrade>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SALGRADE");

                entity.Property(e => e.Grade).HasColumnName("GRADE");

                entity.Property(e => e.Hisal).HasColumnName("HISAL");

                entity.Property(e => e.Losal).HasColumnName("LOSAL");
            });

            modelBuilder.Entity<Sizes>(entity =>
            {
                entity.HasKey(e => e.IdSizeType)
                    .HasName("Sizes_pk");

                entity.Property(e => e.IdSizeType)
                    .HasColumnName("idSizeType")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdType).HasColumnName("idType");

                entity.Property(e => e.SizeField1)
                    .IsRequired()
                    .HasColumnName("sizeField1")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SizeField2)
                    .HasColumnName("sizeField2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTypeNavigation)
                    .WithMany(p => p.Sizes)
                    .HasForeignKey(d => d.IdType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Sizes_ProductTypes");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IndexNumber)
                    .HasName("Student_pk");

                entity.Property(e => e.IndexNumber).HasMaxLength(100);

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdEnrollmentNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.IdEnrollment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Student_Enrollment");
            });

            modelBuilder.Entity<Studies>(entity =>
            {
                entity.HasKey(e => e.IdStudy)
                    .HasName("Studies_pk");

                entity.Property(e => e.IdStudy).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Teams>(entity =>
            {
                entity.HasKey(e => e.IdTeam);

                entity.Property(e => e.TeamName).HasMaxLength(30);
            });

            modelBuilder.Entity<ZwiazekMalzenski>(entity =>
            {
                entity.HasKey(e => e.IdZwiazku)
                    .HasName("PK__Zwiazek___7C75E0F70104A82C");

                entity.ToTable("Zwiazek_Malzenski");

                entity.Property(e => e.IdZwiazku)
                    .HasColumnName("Id_Zwiazku")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataWygasnieciaZwiazku)
                    .HasColumnName("Data_Wygasniecia_Zwiazku")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataZawarciaZwiazku)
                    .HasColumnName("Data_Zawarcia_Zwiazku")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdMiejscowosci).HasColumnName("Id_Miejscowosci");

                entity.Property(e => e.Maz)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PowodWygasnieciaZwiazku)
                    .HasColumnName("Powod_Wygasniecia_Zwiazku")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Zona)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.IdMiejscowosciNavigation)
                    .WithMany(p => p.ZwiazekMalzenski)
                    .HasForeignKey(d => d.IdMiejscowosci)
                    .HasConstraintName("FK__Zwiazek_M__Id_Mi__31EC6D26");

                entity.HasOne(d => d.MazNavigation)
                    .WithMany(p => p.ZwiazekMalzenskiMazNavigation)
                    .HasForeignKey(d => d.Maz)
                    .HasConstraintName("FK__Zwiazek_Mal__Maz__32E0915F");

                entity.HasOne(d => d.ZonaNavigation)
                    .WithMany(p => p.ZwiazekMalzenskiZonaNavigation)
                    .HasForeignKey(d => d.Zona)
                    .HasConstraintName("FK__Zwiazek_Ma__Zona__33D4B598");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
