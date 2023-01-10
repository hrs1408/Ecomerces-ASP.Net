using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ecomerces.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Image = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "https://cdn.tgdd.vn/Products/Images/42/249720/TimerThumb/vivo-y15s-2021-(12).jpg", "Smartphone" },
                    { 2, "https://fptshop.com.vn/Uploads/Originals/2021/9/4/637663485438013374_msi-modern-14-xam-dd.jpg", "Laptop" },
                    { 3, "https://images.samsung.com/is/image/samsung/p6pim/vn/ef-bt730pbegww/gallery/vn-galaxy-tab-s7-fe-bt730-ef-bt730pbegww-thumb-499778061?$264_264_PNG$", "Tablet" },
                    { 4, "https://cdn2.cellphones.com.vn/358x358,webp,q100/media/catalog/product/1/_/1_258.jpg", "Watch" },
                    { 5, "https://antien.vn/uploaded/Bose%20Headphone%20700/tai-nghe-bluetooth-chong-on-bose-headphones-700.jpg", "Headphone" },
                    { 6, "https://vn.jbl.com/dw/image/v2/AAUJ_PRD/on/demandware.static/-/Sites-masterCatalog_Harman/default/dwd04e5f23/1_JBL_PARTYBOX_110_HERO_x2.jpg?sw=270&sh=330&sm=fit&sfrm=png", "Speaker" },
                    { 7, "https://hanoicomputercdn.com/media/product/60800_camera_ip_wifi_quay_quet_thong_minh_ezviz_c6n_4mp_sp.png", "Camera" },
                    { 8, "https://phongnet.com/wp-content/uploads/2022/09/mainboard-asus-h510m-k-chinh-hang.jpg", "Main board" },
                    { 9, "https://cdn.techzones.vn/Data/Sites/1/News/3246/techzones-top-nhung-cpu-may-tinh-manh-nhat-hien-nay.jpg", "CPU" },
                    { 10, "https://www.sieuthimaychu.vn/datafiles/setone/16027492188296.jpg", "RAM" },
                    { 11, "https://m.media-amazon.com/images/I/81kf3+5l2LS._SL1500_.jpg", "VGA" },
                    { 12, "https://www.sieuthimaychu.vn/datafiles/setone/16240015291425.png", "SSD" },
                    { 13, "https://kccshop.vn/media/product/250-963-44444_hdd_seagate_barracuda_2tb.jpg", "HDD" },
                    { 14, "https://gland.vn/media/news/1501_vo-case-6.jpg", "Case" },
                    { 15, "https://npcshop.vn/media/product/250-3800-63449_rm850_____850_watt_80_plus_gold_fully__7_.jpg", "PSU" },
                    { 16, "https://files.pccasegear.com/images/1625009304-ROG-STRIX-LC-II-360-ARGB-thb.jpg", "Cooler" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "huyhieu.nguyenphan@gmail.com", "Huy Hieu", "Sp140802" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Iphone 12", "https://cdn2.cellphones.com.vn/358x358,webp,q100/media/catalog/product/1/_/1_252.jpg", "Iphone 12", 14790000m, 1 },
                    { 2, 1, "Iphone 12 Pro", "https://cdn.tgdd.vn/Products/Images/42/213032/iphone-12-pro-xam-new-600x600-2-600x600.jpg", "Iphone 12 Pro", 16790000m, 1 },
                    { 3, 1, "Iphone 12 Pro Max", "https://cdn.tgdd.vn/Products/Images/42/213033/iphone-12-pro-max-xam-new-600x600-200x200.jpg", "Iphone 12 Pro Max", 18790000m, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
