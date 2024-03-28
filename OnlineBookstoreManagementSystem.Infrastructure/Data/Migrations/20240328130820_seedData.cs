using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookstoreManagementSystem.Data.Migrations
{
    public partial class seedData : Migration
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
                    { "deal1232-c23-dsds334-sdsk23-b2343431fefe", 0, "f8702e96-dfd2-4f9a-86b9-2c1dc1eaf767", "seller@gmail.com", false, false, null, "seller@gmail.com", "seller@gmail.com", "AQAAAAEAACcQAAAAEA8JWHR1bgMtviuEJ7ccaZeenB3hGP5B21OBznMhHSOPAhSa7AKDAvHaFKCaWK5haA==", null, false, "f2ed9284-a6cf-486b-85f7-e52a8305ad06", false, "seller@gmail.com" },
                    { "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 0, "8b0c598c-27b9-4667-a965-555820c9ace5", "guestuser@gmail.com", false, false, null, "guestuser@gmail.com", "guestuser@gmail.com", "AQAAAAEAACcQAAAAEPJwzTsDhWWzVQKBrrQsBqOqxpks3N8YQkjWPJwgT/Klyfdakgugs64tQdc38S4PMg==", null, false, "a44d750a-1a17-42df-a7e6-88e67dc29cdd", false, "guestuser@gmail.com" }
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
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "Price", "SellerId", "Title" },
                values: new object[] { 1, 1, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 1, "This is a third series book in the author collection.It represents the author inimaginary situation in the past", 40.00m, 1, "The silent patient" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "Price", "SellerId", "Title" },
                values: new object[] { 2, 2, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 2, "How to manage your budget.Think of a money like a businessman.", 60.00m, 1, "The Psychology Of Money Book" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BuyerId", "CategoryId", "Description", "Price", "SellerId", "Title" },
                values: new object[] { 3, 3, "fbjfif33-c23-ooo21-sdsk23-a3jfjcj224", 3, "Join in a world full of fantasy and your mind will explode in happiness", 70.00m, 1, "Fairy Tale" });

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
