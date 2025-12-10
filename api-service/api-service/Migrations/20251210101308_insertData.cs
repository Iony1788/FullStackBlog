using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api_service.Migrations
{
    /// <inheritdoc />
    public partial class insertData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Informatique", "Ordinateur portable performant avec processeur i7", "https://example.com/images/laptop-lenovo.jpg", "Laptop Lenovo", 1200.50m },
                    { 2, "Téléphonie", "Smartphone haut de gamme avec écran AMOLED", "https://example.com/images/samsung-s24.jpg", "Smartphone Samsung S24", 999.99m },
                    { 3, "Audio", "Casque Bluetooth à réduction de bruit", "https://example.com/images/sony-wh1000xm5.jpg", "Casque Sony WH-1000XM5", 349.99m },
                    { 4, "Informatique", "Clavier RGB pour gaming", "https://example.com/images/logitech-keyboard.jpg", "Clavier mécanique Logitech", 129.99m },
                    { 5, "Informatique", "Souris gamer ergonomique avec 11 boutons programmables", "https://example.com/images/razer-basilisk.jpg", "Souris Razer Basilisk", 79.99m },
                    { 6, "Informatique", "Moniteur 4K UHD IPS", "https://example.com/images/dell-monitor.jpg", "Écran Dell 27 pouces", 499.00m },
                    { 7, "Informatique", "Imprimante tout-en-un sans fil", "https://example.com/images/hp-deskjet.jpg", "Imprimante HP DeskJet 4155e", 149.00m },
                    { 8, "Informatique", "Stockage rapide NVMe M.2", "https://example.com/images/samsung-ssd.jpg", "Disque SSD Samsung 1TB", 129.50m },
                    { 9, "Informatique", "Caméra HD 1080p pour visioconférence", "https://example.com/images/logitech-c920.jpg", "Webcam Logitech C920", 89.00m },
                    { 10, "Mobilier", "Chaise de bureau premium pour le confort", "https://example.com/images/secretlab-chair.jpg", "Chaise ergonomique Secretlab", 459.99m },
                    { 11, "Gaming", "Casque réalité virtuelle autonome", "https://example.com/images/oculus-quest2.jpg", "Casque VR Oculus Quest 2", 299.00m },
                    { 12, "Informatique", "Tablette légère et performante", "https://example.com/images/ipad-air.jpg", "Tablette Apple iPad Air", 599.00m },
                    { 13, "Wearable", "Montre connectée multisport", "https://example.com/images/garmin-fenix7.jpg", "Smartwatch Garmin Fenix 7", 699.99m },
                    { 14, "Audio", "Enceinte portable Bluetooth", "https://example.com/images/bose-soundlink.jpg", "Haut-parleur Bose SoundLink", 199.00m },
                    { 15, "Réseau", "Routeur WiFi 6 ultra-rapide", "https://example.com/images/asus-router.jpg", "Router WiFi ASUS RT-AX88U", 299.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
