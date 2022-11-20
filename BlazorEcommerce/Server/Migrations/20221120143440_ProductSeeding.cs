using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Trong tháng 9 năm 1740, tình trạng bất ổn bắt đầu nổi lên từ các cụm dân cư gốc Hoa, chúng được châm ngòi từ hoạt động đàn áp của chính phủ và thu nhập giảm do giá đường sụt giảm trước khi diễn ra vụ thảm sát.", "https://upload.wikimedia.org/wikipedia/commons/5/57/Chinezenmoord_van_stolk_%282%29.jpg", 99.99m, "Thảm sát Batavia năm 1740" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Hiện tượng 2012 bao gồm hàng loạt những người tin về thuyết mạt thế cho rằng vào ngày 21 tháng 12 năm 2012 là ngày tận thế hoặc sẽ xảy ra những sự kiện biến đổi lớn", "https://upload.wikimedia.org/wikipedia/commons/7/7a/East_side_of_stela_C%2C_Quirigua.PNG", 99.99m, "Hiện tượng 2012" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Trung Bộ châu Mỹ cổ đại (thuật ngữ gốc: Mesoamerica) là 1 vùng và là 1 khu vực văn hóa ở châu Mỹ, trải dài từ miền trung México đến Belize, Guatemala, El Salvador, Honduras, Nicaragua và miền bắc Costa Rica", "https://upload.wikimedia.org/wikipedia/commons/7/79/Mesoamerica_english.PNG", 99.99m, "Trung Bộ châu Mỹ" });
        }

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
        }
    }
}
