using ecomerces.Models;
using Microsoft.EntityFrameworkCore;

namespace ecomerces.Data;

public class AppDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Cart> Carts { get; set; }

    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().HasData(new User()
        {
            Id = 1,
            Name = "Huy Hieu",
            Email = "huyhieu.nguyenphan@gmail.com",
            Password = "Sp140802"
        });
        modelBuilder.Entity<Category>().HasData(new List<Category>()
        {
            new Category()
            {
                Id = 1,
                Name = "Smartphone",
                Image = "https://cdn.tgdd.vn/Products/Images/42/249720/TimerThumb/vivo-y15s-2021-(12).jpg"
            },
            new Category()
            {
                Id = 2,
                Name = "Laptop",
                Image = "https://fptshop.com.vn/Uploads/Originals/2021/9/4/637663485438013374_msi-modern-14-xam-dd.jpg"
            },
            new Category()
            {
                Id = 3,
                Name = "Tablet",
                Image =
                    "https://images.samsung.com/is/image/samsung/p6pim/vn/ef-bt730pbegww/gallery/vn-galaxy-tab-s7-fe-bt730-ef-bt730pbegww-thumb-499778061?$264_264_PNG$"
            },
            new Category()
            {
                Id = 4,
                Name = "Watch",
                Image = "https://cdn2.cellphones.com.vn/358x358,webp,q100/media/catalog/product/1/_/1_258.jpg"
            },
            new Category()
            {
                Id = 5,
                Name = "Headphone",
                Image =
                    "https://antien.vn/uploaded/Bose%20Headphone%20700/tai-nghe-bluetooth-chong-on-bose-headphones-700.jpg"
            },
            new Category()
            {
                Id = 6,
                Name = "Speaker",
                Image =
                    "https://vn.jbl.com/dw/image/v2/AAUJ_PRD/on/demandware.static/-/Sites-masterCatalog_Harman/default/dwd04e5f23/1_JBL_PARTYBOX_110_HERO_x2.jpg?sw=270&sh=330&sm=fit&sfrm=png"
            },
            new Category()
            {
                Id = 7,
                Name = "Camera",
                Image =
                    "https://hanoicomputercdn.com/media/product/60800_camera_ip_wifi_quay_quet_thong_minh_ezviz_c6n_4mp_sp.png"
            },
            new Category()
            {
                Id = 8,
                Name = "Main board",
                Image = "https://phongnet.com/wp-content/uploads/2022/09/mainboard-asus-h510m-k-chinh-hang.jpg"
            },
            new Category()
            {
                Id = 9,
                Name = "CPU",
                Image =
                    "https://cdn.techzones.vn/Data/Sites/1/News/3246/techzones-top-nhung-cpu-may-tinh-manh-nhat-hien-nay.jpg"
            },
            new Category()
            {
                Id = 10,
                Name = "RAM",
                Image = "https://www.sieuthimaychu.vn/datafiles/setone/16027492188296.jpg"
            },
            new Category()
            {
                Id = 11,
                Name = "VGA",
                Image = "https://m.media-amazon.com/images/I/81kf3+5l2LS._SL1500_.jpg"
            },
            new Category()
            {
                Id = 12,
                Name = "SSD",
                Image = "https://www.sieuthimaychu.vn/datafiles/setone/16240015291425.png"
            },
            new Category()
            {
                Id = 13,
                Name = "HDD",
                Image = "https://kccshop.vn/media/product/250-963-44444_hdd_seagate_barracuda_2tb.jpg"
            },
            new Category()
            {
                Id = 14,
                Name = "Case",
                Image = "https://gland.vn/media/news/1501_vo-case-6.jpg"
            },
            new Category()
            {
                Id = 15,
                Name = "PSU",
                Image = "https://npcshop.vn/media/product/250-3800-63449_rm850_____850_watt_80_plus_gold_fully__7_.jpg"
            },
            new Category()
            {
                Id = 16,
                Name = "Cooler",
                Image = "https://files.pccasegear.com/images/1625009304-ROG-STRIX-LC-II-360-ARGB-thb.jpg"
            },
        });
        modelBuilder.Entity<Product>().HasData(new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Iphone 12",
                Price = 14790000,
                Description = "Iphone 12",
                Image = "https://cdn2.cellphones.com.vn/358x358,webp,q100/media/catalog/product/1/_/1_252.jpg",
                CategoryId = 1,
                Quantity = 1
            },
            new Product()
            {
                Id = 2,
                Name = "Iphone 12 Pro",
                Price = 16790000,
                Description = "Iphone 12 Pro",
                Image = "https://cdn.tgdd.vn/Products/Images/42/213032/iphone-12-pro-xam-new-600x600-2-600x600.jpg",
                CategoryId = 1,
                Quantity = 1
            },
            new Product()
            {
                Id = 3,
                Name = "Iphone 12 Pro Max",
                Price = 18790000,
                Description = "Iphone 12 Pro Max",
                Image = "https://cdn.tgdd.vn/Products/Images/42/213033/iphone-12-pro-max-xam-new-600x600-200x200.jpg",
                CategoryId = 1,
                Quantity = 1
            }
        });
    }
}