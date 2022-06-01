using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BiblWeb2._0.Data
{
    public partial class WebDbContext : DbContext
    {
        public WebDbContext()
        {
        }

        public WebDbContext(DbContextOptions<WebDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AboutUsView> AboutUsViews { get; set; } = null!;
        public virtual DbSet<Aside> Asides { get; set; } = null!;
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; } = null!;
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<ContactInfo> ContactInfos { get; set; } = null!;
        public virtual DbSet<ContactView> ContactViews { get; set; } = null!;
        public virtual DbSet<Doc> Docs { get; set; } = null!;
        public virtual DbSet<Docs> Docs1 { get; set; } = null!;
        public virtual DbSet<DocDoc> DocDocs { get; set; } = null!;
        public virtual DbSet<Footer> Footers { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<Galleries> Galleries1 { get; set; } = null!;
        public virtual DbSet<GalleryGallery> GalleryGalleries { get; set; } = null!;
        public virtual DbSet<Header> Headers { get; set; } = null!;
        public virtual DbSet<MainView> MainViews { get; set; } = null!;
        public virtual DbSet<New> News { get; set; } = null!;
        public virtual DbSet<NewNews> NewNews { get; set; } = null!;
        public virtual DbSet<News> News1 { get; set; } = null!;
        public virtual DbSet<NewsView> NewsViews { get; set; } = null!;
        public virtual DbSet<Project> Projects { get; set; } = null!;
        public virtual DbSet<Projects> Projects1 { get; set; } = null!;
        public virtual DbSet<ProjectProject> ProjectProjects { get; set; } = null!;
        public virtual DbSet<ProjectStatus> ProjectStatuses { get; set; } = null!;
        public virtual DbSet<ProjectType> ProjectTypes { get; set; } = null!;
        public virtual DbSet<ProjectView> ProjectViews { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Services> Services1 { get; set; } = null!;
        public virtual DbSet<ServiceServicesId> ServiceServicesIds { get; set; } = null!;
        public virtual DbSet<ServiceView> ServiceViews { get; set; } = null!;
        public virtual DbSet<Slider> Sliders { get; set; } = null!;
        public virtual DbSet<Sliders> Sliders1 { get; set; } = null!;
        public virtual DbSet<SliderSlider> SliderSliders { get; set; } = null!;
        public virtual DbSet<Team> Teams { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;
        public virtual DbSet<WorkerTeam> WorkerTeams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LITA_PC;Database=aspnet-BiblWeb2._0-E845F4AF-EB37-4CDB-8004-EC91916FF9CA;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AboutUsView>(entity =>
            {
                entity.HasKey(e => e.AboutUsElementId)
                    .HasName("PK_AboutUsVIew");

                entity.ToTable("AboutUsView");

                entity.Property(e => e.AboutUsElementId).HasColumnName("AboutUsElementID");

                entity.Property(e => e.DocsId).HasColumnName("DocsID");

                entity.Property(e => e.TeamsId).HasColumnName("TeamsID");

                entity.HasOne(d => d.Docs)
                    .WithMany(p => p.AboutUsViews)
                    .HasForeignKey(d => d.DocsId)
                    .HasConstraintName("FK_AboutUsView_AboutUsView");

                entity.HasOne(d => d.Teams)
                    .WithMany(p => p.AboutUsViews)
                    .HasForeignKey(d => d.TeamsId)
                    .HasConstraintName("FK_AboutUsView_Teams");
            });

            modelBuilder.Entity<Aside>(entity =>
            {
                entity.HasKey(e => e.AsideElementId);

                entity.ToTable("Aside");

                entity.Property(e => e.AsideElementId).HasColumnName("AsideElementID");
            });

            modelBuilder.Entity<AspNetRole>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetRoleClaim>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserToken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<ContactInfo>(entity =>
            {
                entity.ToTable("ContactInfo");

                entity.Property(e => e.ContactInfoId)
                    .ValueGeneratedNever()
                    .HasColumnName("ContactInfoID");
            });

            modelBuilder.Entity<ContactView>(entity =>
            {
                entity.HasKey(e => e.ContactViewElementId);

                entity.ToTable("ContactView");

                entity.Property(e => e.ContactViewElementId).HasColumnName("ContactViewElementID");

                entity.Property(e => e.ContactInfoId).HasColumnName("ContactInfoID");

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.ContactViews)
                    .HasForeignKey(d => d.ContactInfoId)
                    .HasConstraintName("FK_ContactView_ContactInfo");
            });

            modelBuilder.Entity<Doc>(entity =>
            {
                entity.ToTable("Doc");

                entity.Property(e => e.DocId).HasColumnName("DocID");
            });

            modelBuilder.Entity<Docs>(entity =>
            {
                entity.HasKey(e => e.DocsId);

                entity.ToTable("Docs");

                entity.Property(e => e.DocsId).HasColumnName("DocsID");
            });

            modelBuilder.Entity<DocDoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Doc_Docs");

                entity.Property(e => e.DocDocsId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Doc_DocsID");

                entity.HasOne(d => d.DocNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Doc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doc_Docs_Doc");

                entity.HasOne(d => d.DocsNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Docs)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doc_Docs_Docs");
            });

            modelBuilder.Entity<Footer>(entity =>
            {
                entity.ToTable("Footer");

                entity.Property(e => e.FooterId)
                    .ValueGeneratedNever()
                    .HasColumnName("FooterID");

                entity.Property(e => e.ContactInfoId).HasColumnName("ContactInfoID");

                entity.Property(e => e.GalleriesId).HasColumnName("GalleriesID");

                entity.Property(e => e.SlidersId).HasColumnName("SlidersID");

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.Footers)
                    .HasForeignKey(d => d.ContactInfoId)
                    .HasConstraintName("FK_Footer_ContactInfo");

                entity.HasOne(d => d.Galleries)
                    .WithMany(p => p.Footers)
                    .HasForeignKey(d => d.GalleriesId)
                    .HasConstraintName("FK_Footer_Galleries");

                entity.HasOne(d => d.Sliders)
                    .WithMany(p => p.Footers)
                    .HasForeignKey(d => d.SlidersId)
                    .HasConstraintName("FK_Footer_Sliders");
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.HasKey(e => e.GalleriesId);

                entity.Property(e => e.GalleriesId)
                    .ValueGeneratedNever()
                    .HasColumnName("GalleriesID");
            });

            modelBuilder.Entity<Galleries>(entity =>
            {
                entity.HasKey(e => e.GalleryId)
                    .HasName("PK_GalleryID");

                entity.ToTable("Gallery");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");
            });

            modelBuilder.Entity<GalleryGallery>(entity =>
            {
                entity.HasKey(e => e.GalleryGalleriesId);

                entity.ToTable("Gallery_Galleries");

                entity.Property(e => e.GalleryGalleriesId).HasColumnName("Gallery_GalleriesID");

                entity.Property(e => e.GalleriesId).HasColumnName("GalleriesID");

                entity.Property(e => e.GalleryId).HasColumnName("GalleryID");

                entity.HasOne(d => d.Galleries)
                    .WithMany(p => p.GalleryGalleries)
                    .HasForeignKey(d => d.GalleriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gallery_Galleries_Galleries");

                entity.HasOne(d => d.Gallery)
                    .WithMany(p => p.GalleryGalleries)
                    .HasForeignKey(d => d.GalleryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gallery_Galleries_Gallery");
            });

            modelBuilder.Entity<Header>(entity =>
            {
                entity.ToTable("Header");

                entity.Property(e => e.HeaderId)
                    .ValueGeneratedNever()
                    .HasColumnName("HeaderID");

                entity.Property(e => e.ContactInfoId).HasColumnName("ContactInfoID");

                entity.HasOne(d => d.ContactInfo)
                    .WithMany(p => p.Headers)
                    .HasForeignKey(d => d.ContactInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Header_ContactInfo");
            });

            modelBuilder.Entity<MainView>(entity =>
            {
                entity.HasKey(e => e.MainViewElemId);

                entity.ToTable("MainView");

                entity.Property(e => e.MainViewElemId)
                    .ValueGeneratedNever()
                    .HasColumnName("MainViewElemID");

                entity.Property(e => e.MainNewsId).HasColumnName("MainNewsID");

                entity.Property(e => e.MainProjectsId).HasColumnName("MainProjectsID");

                entity.Property(e => e.MainSlidersId).HasColumnName("MainSlidersID");

                entity.Property(e => e.SecondSlidersId).HasColumnName("SecondSlidersID");

                entity.HasOne(d => d.MainNews)
                    .WithMany(p => p.MainViews)
                    .HasForeignKey(d => d.MainNewsId)
                    .HasConstraintName("FK_MainView_News");

                entity.HasOne(d => d.MainProjects)
                    .WithMany(p => p.MainViews)
                    .HasForeignKey(d => d.MainProjectsId)
                    .HasConstraintName("FK_MainView_Projects");

                entity.HasOne(d => d.MainSliders)
                    .WithMany(p => p.MainViewMainSliders)
                    .HasForeignKey(d => d.MainSlidersId)
                    .HasConstraintName("FK_MainView_Sliders");

                entity.HasOne(d => d.SecondSliders)
                    .WithMany(p => p.MainViewSecondSliders)
                    .HasForeignKey(d => d.SecondSlidersId)
                    .HasConstraintName("FK_MainView_Sliders1");
            });

            modelBuilder.Entity<New>(entity =>
            {
                entity.ToTable("New");

                entity.Property(e => e.NewId)
                    .ValueGeneratedNever()
                    .HasColumnName("NewID");
            });

            modelBuilder.Entity<NewNews>(entity =>
            {
                entity.ToTable("New_News");

                entity.Property(e => e.NewNewsId).HasColumnName("New_NewsID");

                entity.Property(e => e.NewId).HasColumnName("NewID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.HasOne(d => d.New)
                    .WithMany(p => p.NewNews)
                    .HasForeignKey(d => d.NewId)
                    .HasConstraintName("FK_New_News_New");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewNews)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_New_News_News");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("News");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");
            });

            modelBuilder.Entity<NewsView>(entity =>
            {
                entity.HasKey(e => e.NewsViewElementId);

                entity.ToTable("NewsView");

                entity.Property(e => e.NewsViewElementId).HasColumnName("NewsViewElementID");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.NewsViews)
                    .HasForeignKey(d => d.NewsId)
                    .HasConstraintName("FK_NewsView_News");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.ToTable("Project");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectStatusId).HasColumnName("ProjectStatusID");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.HasOne(d => d.ProjectStatus)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_ProjectStatus");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_ProjectType");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectsId);

                entity.ToTable("Projects");

                entity.Property(e => e.ProjectsId).HasColumnName("ProjectsID");
            });

            modelBuilder.Entity<ProjectProject>(entity =>
            {
                entity.HasKey(e => e.ProjectProjectsId)
                    .HasName("PK_Project_ProjectsID");

                entity.ToTable("Project_Projects");

                entity.Property(e => e.ProjectProjectsId).HasColumnName("Project_ProjectsID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectsId).HasColumnName("ProjectsID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Projects_Project");

                entity.HasOne(d => d.Projects)
                    .WithMany(p => p.ProjectProjects)
                    .HasForeignKey(d => d.ProjectsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_Projects_Projects");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.ToTable("ProjectStatus");

                entity.Property(e => e.ProjectStatusId).HasColumnName("ProjectStatusID");
            });

            modelBuilder.Entity<ProjectType>(entity =>
            {
                entity.ToTable("ProjectType");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");
            });

            modelBuilder.Entity<ProjectView>(entity =>
            {
                entity.HasKey(e => e.ProjectViewElementId);

                entity.ToTable("ProjectView");

                entity.Property(e => e.ProjectViewElementId).HasColumnName("ProjectViewElementID");

                entity.Property(e => e.GalleriesId).HasColumnName("GalleriesID");

                entity.Property(e => e.ProjectsId).HasColumnName("ProjectsID");

                entity.HasOne(d => d.Galleries)
                    .WithMany(p => p.ProjectViews)
                    .HasForeignKey(d => d.GalleriesId)
                    .HasConstraintName("FK_ProjectView_Galleries1");

                entity.HasOne(d => d.Projects)
                    .WithMany(p => p.ProjectViews)
                    .HasForeignKey(d => d.ProjectsId)
                    .HasConstraintName("FK_ProjectView_Projects");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.SeviceId);

                entity.ToTable("Service");

                entity.Property(e => e.SeviceId).HasColumnName("SeviceID");
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServicesId);

                entity.ToTable("Services");

                entity.Property(e => e.ServicesId).HasColumnName("ServicesID");
            });

            modelBuilder.Entity<ServiceServicesId>(entity =>
            {
                entity.HasKey(e => e.ServiceServicesId1);

                entity.ToTable("Service_ServicesID");

                entity.Property(e => e.ServiceServicesId1).HasColumnName("Service_ServicesID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServicesId).HasColumnName("ServicesID");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceServicesIds)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_ServicesID_Service");

                entity.HasOne(d => d.Services)
                    .WithMany(p => p.ServiceServicesIds)
                    .HasForeignKey(d => d.ServicesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Service_ServicesID_Services");
            });

            modelBuilder.Entity<ServiceView>(entity =>
            {
                entity.HasKey(e => e.ServiceViewElementId);

                entity.ToTable("ServiceView");

                entity.Property(e => e.ServiceViewElementId).HasColumnName("ServiceViewElementID");

                entity.Property(e => e.ServicesId).HasColumnName("ServicesID");

                entity.Property(e => e.SevicesImageId).HasColumnName("SevicesImageID");

                entity.HasOne(d => d.Services)
                    .WithMany(p => p.ServiceViewServices)
                    .HasForeignKey(d => d.ServicesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceView_Services");

                entity.HasOne(d => d.SevicesImage)
                    .WithMany(p => p.ServiceViewSevicesImages)
                    .HasForeignKey(d => d.SevicesImageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceView_Services1");
            });

            modelBuilder.Entity<Slider>(entity =>
            {
                entity.ToTable("Slider");

                entity.Property(e => e.SliderId).HasColumnName("SliderID");
            });

            modelBuilder.Entity<Sliders>(entity =>
            {
                entity.HasKey(e => e.SlidersId)
                    .HasName("PK_Sliders_1");

                entity.ToTable("Sliders");

                entity.Property(e => e.SlidersId).HasColumnName("SlidersID");
            });

            modelBuilder.Entity<SliderSlider>(entity =>
            {
                entity.HasKey(e => e.SliderSlidersId);

                entity.ToTable("Slider_Sliders");

                entity.Property(e => e.SliderSlidersId).HasColumnName("Slider_SlidersID");

                entity.Property(e => e.SliderId).HasColumnName("SliderID");

                entity.Property(e => e.SlidersId).HasColumnName("SlidersID");

                entity.HasOne(d => d.Slider)
                    .WithMany(p => p.SliderSliders)
                    .HasForeignKey(d => d.SliderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slider_Sliders_Slider");

                entity.HasOne(d => d.Sliders)
                    .WithMany(p => p.SliderSliders)
                    .HasForeignKey(d => d.SlidersId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Slider_Sliders_Sliders");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasKey(e => e.TeamsId)
                    .HasName("PK_Table_1");

                entity.Property(e => e.TeamsId).HasColumnName("TeamsID");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerTeam>(entity =>
            {
                entity.HasKey(e => e.WorkerTeamsId);

                entity.ToTable("Worker_Teams");

                entity.Property(e => e.WorkerTeamsId).HasColumnName("Worker_TeamsID");

                entity.Property(e => e.TeamsId).HasColumnName("TeamsID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Teams)
                    .WithMany(p => p.WorkerTeams)
                    .HasForeignKey(d => d.TeamsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Worker_Teams_Teams");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.WorkerTeams)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Worker_Teams_Worker");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
