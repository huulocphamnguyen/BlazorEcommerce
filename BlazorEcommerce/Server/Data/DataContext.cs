using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Title = "Thảm sát Batavia năm 1740",
                Description = "Trong tháng 9 năm 1740, tình trạng bất ổn bắt đầu nổi lên từ các cụm dân cư gốc Hoa, chúng được châm ngòi từ hoạt động đàn áp của chính phủ và thu nhập giảm do giá đường sụt giảm trước khi diễn ra vụ thảm sát.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/5/57/Chinezenmoord_van_stolk_%282%29.jpg",
                Price = 99.99m
            },
            new Product
            {
                Id = 2,
                Title = "Hiện tượng 2012",
                Description = "Hiện tượng 2012 bao gồm hàng loạt những người tin về thuyết mạt thế cho rằng vào ngày 21 tháng 12 năm 2012 là ngày tận thế hoặc sẽ xảy ra những sự kiện biến đổi lớn",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7a/East_side_of_stela_C%2C_Quirigua.PNG",
                Price = 99.99m
            },
            new Product
            {
                Id = 3,
                Title = "Trung Bộ châu Mỹ",
                Description = "Trung Bộ châu Mỹ cổ đại (thuật ngữ gốc: Mesoamerica) là 1 vùng và là 1 khu vực văn hóa ở châu Mỹ, trải dài từ miền trung México đến Belize, Guatemala, El Salvador, Honduras, Nicaragua và miền bắc Costa Rica",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/79/Mesoamerica_english.PNG",
                Price = 99.99m
            });
        }
        public DbSet<Product> Products { get; set; }
    }
}
