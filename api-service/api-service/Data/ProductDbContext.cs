using api_service.Models;
using Microsoft.EntityFrameworkCore;

namespace api_service.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop Lenovo", Description = "Ordinateur portable performant avec processeur i7", Category = "Informatique", Price = 1200.50M, ImageUrl = "https://example.com/images/laptop-lenovo.jpg" },
                new Product { Id = 2, Name = "Smartphone Samsung S24", Description = "Smartphone haut de gamme avec écran AMOLED", Category = "Téléphonie", Price = 999.99M, ImageUrl = "https://example.com/images/samsung-s24.jpg" },
                new Product { Id = 3, Name = "Casque Sony WH-1000XM5", Description = "Casque Bluetooth à réduction de bruit", Category = "Audio", Price = 349.99M, ImageUrl = "https://example.com/images/sony-wh1000xm5.jpg" },
                new Product { Id = 4, Name = "Clavier mécanique Logitech", Description = "Clavier RGB pour gaming", Category = "Informatique", Price = 129.99M, ImageUrl = "https://example.com/images/logitech-keyboard.jpg" },
                new Product { Id = 5, Name = "Souris Razer Basilisk", Description = "Souris gamer ergonomique avec 11 boutons programmables", Category = "Informatique", Price = 79.99M, ImageUrl = "https://example.com/images/razer-basilisk.jpg" },
                new Product { Id = 6, Name = "Écran Dell 27 pouces", Description = "Moniteur 4K UHD IPS", Category = "Informatique", Price = 499.00M, ImageUrl = "https://example.com/images/dell-monitor.jpg" },
                new Product { Id = 7, Name = "Imprimante HP DeskJet 4155e", Description = "Imprimante tout-en-un sans fil", Category = "Informatique", Price = 149.00M, ImageUrl = "https://example.com/images/hp-deskjet.jpg" },
                new Product { Id = 8, Name = "Disque SSD Samsung 1TB", Description = "Stockage rapide NVMe M.2", Category = "Informatique", Price = 129.50M, ImageUrl = "https://example.com/images/samsung-ssd.jpg" },
                new Product { Id = 9, Name = "Webcam Logitech C920", Description = "Caméra HD 1080p pour visioconférence", Category = "Informatique", Price = 89.00M, ImageUrl = "https://example.com/images/logitech-c920.jpg" },
                new Product { Id = 10, Name = "Chaise ergonomique Secretlab", Description = "Chaise de bureau premium pour le confort", Category = "Mobilier", Price = 459.99M, ImageUrl = "https://example.com/images/secretlab-chair.jpg" },
                new Product { Id = 11, Name = "Casque VR Oculus Quest 2", Description = "Casque réalité virtuelle autonome", Category = "Gaming", Price = 299.00M, ImageUrl = "https://example.com/images/oculus-quest2.jpg" },
                new Product { Id = 12, Name = "Tablette Apple iPad Air", Description = "Tablette légère et performante", Category = "Informatique", Price = 599.00M, ImageUrl = "https://example.com/images/ipad-air.jpg" },
                new Product { Id = 13, Name = "Smartwatch Garmin Fenix 7", Description = "Montre connectée multisport", Category = "Wearable", Price = 699.99M, ImageUrl = "https://example.com/images/garmin-fenix7.jpg" },
                new Product { Id = 14, Name = "Haut-parleur Bose SoundLink", Description = "Enceinte portable Bluetooth", Category = "Audio", Price = 199.00M, ImageUrl = "https://example.com/images/bose-soundlink.jpg" },
                new Product { Id = 15, Name = "Router WiFi ASUS RT-AX88U", Description = "Routeur WiFi 6 ultra-rapide", Category = "Réseau", Price = 299.99M, ImageUrl = "https://example.com/images/asus-router.jpg" }
            );
        }
    }
}
