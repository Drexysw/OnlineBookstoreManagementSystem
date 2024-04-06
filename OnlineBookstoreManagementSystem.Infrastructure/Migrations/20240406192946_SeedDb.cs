using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstoreManagementSystem.Infrastructure.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Sellers_SellerId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "deal1232-c23-dsds334-sdsk23-b2343431fefe", 0, "c708d76c-6ce4-4420-85fa-c5e1e874c6d5", "seller@gmail.com", false, false, null, "seller@gmail.com", "seller@gmail.com", "AQAAAAEAACcQAAAAEKfqSn/VLRyNyW+Y+4EVWCxfrSrP25mDEIPi2NWaaJCT4ysI4tNnzM5t+xblb9hG0w==", null, false, "b5bfa266-b86c-4d35-b496-0a221a102401", false, "seller@gmail.com" },
                    { "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 0, "c7709822-dec9-4c1e-b614-ec32a0ef73f4", "guestuser@gmail.com", false, false, null, "guestuser@gmail.com", "guestuser@gmail.com", "AQAAAAEAACcQAAAAEFaHhqqkXXjzPPOWUqPlg88YXg7HnPiQh2ownBPOcncRIG9f+TIaWkTg6bi2bkA5lg==", null, false, "6083ad37-e574-4a3a-8696-f4d62202cfd5", false, "guestuser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Age", "Authobriography", "Name" },
                values: new object[,]
                {
                    { 1, 45, "Has been writing psychology books for 20 years.Some of them are know araound the world", "Alex Michaelides" },
                    { 2, 30, "Keen on psychology since childhood Morgan Housel is one of the briliant people on earth who wrote araound 300 humdreds psychology books", "Morgan Housel" },
                    { 3, 50, "He is one of the most artistic people on earth", "Fairy Tale" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Thriller" },
                    { 2, "Psychology" },
                    { 3, "Novel" }
                });

            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Name", "Rating" },
                values: new object[] { 1, "John", 5.5 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "SellerId", "Title" },
                values: new object[] { 1, 1, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 1, "This is a third series book in the author collection.It represents the author inimaginary situation in the past", "https://m.media-amazon.com/images/I/81JJPDNlxSL._AC_UF1000,1000_QL80_.jpg", 40.00m, 1, "The silent patient" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "SellerId", "Title" },
                values: new object[] { 2, 2, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 2, "How to manage your budget.Think of a money like a businessman.", "https://5.imimg.com/data5/ANDROID/Default/2021/1/AD/UC/ZK/19351533/product-jpeg-1000x1000.jpeg", 60.00m, 1, "The Psychology Of Money Book" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "ImageUrl", "Price", "SellerId", "Title" },
                values: new object[] { 3, 3, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 3, "Join in a world full of fantasy and your mind will explode in happiness", "https://m.media-amazon.com/images/I/81blQfKsLtL._AC_UF1000,1000_QL80_.jpg", 70.00m, 1, "Fairy Tale" });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Sellers_SellerId",
                table: "Books",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Sellers_SellerId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "deal1232-c23-dsds334-sdsk23-b2343431fefe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorId",
                table: "Books",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Sellers_SellerId",
                table: "Books",
                column: "SellerId",
                principalTable: "Sellers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
