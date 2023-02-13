using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieOnline.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cartitems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cartitems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Sci Fi" },
                    { 4, "horror" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImgUrl", "Name", "Price", "Qty" },
                values: new object[,]
                {
                    { 1, 1, "After being bestowed with godly powers and imprisoned for it, Black Adam is liberated from his earthly binds to unleash his fury on the modern world.", "/Images/Beauty/Beauty1.png", "Black Adam", 10m, 100 },
                    { 2, 1, "After being bestowed with godly powers and imprisoned for it, Black Adam is liberated from his earthly binds to unleash his fury on the modern world.", "/Images/Beauty/Beauty1.png", "Black Panther: Wakanda forever", 10m, 100 },
                    { 3, 1, "Thor embarks on a journey unlike anything he's ever faced -- a quest for inner peace. However, his retirement gets interrupted by Gorr the God Butcher, a galactic killer who seeks the extinction of the gods. .", "/Images/Beauty/Beauty1.png", "Thor: Love and Thunder", 12m, 100 },
                    { 4, 1, "Jake Sully and Ney'tiri have formed a family and are doing everything to stay together. However, they must leave their home and explore the regions of Pandora. When an ancient threat resurfaces, Jake must fight a difficult war against the humans.", "/Images/Beauty/Beauty1.png", "Avatar: The way of water", 10m, 100 },
                    { 5, 2, "A man and his ex-wife race to Bali, Indonesia, to stop their daughter from marrying a seaweed farmer. As they desperately try to sabotage the wedding, the bickering duo soon find themselves rekindling old feelings that once made them happy together.", "/Images/Beauty/Beauty1.png", "Ticket to Paradise", 10m, 100 },
                    { 6, 2, "Ladybug is an unlucky assassin who's determined to do his job peacefully after one too many gigs has gone off the rails.", "/Images/Beauty/Beauty1.png", "Bullet Train", 10m, 100 },
                    { 7, 2, "College professor Jack Gladney and his family's comfortable suburban life is upended when a nearby chemical leak causes \"The Airborne Toxic Event,\" releasing a noxious black cloud over the region that forces the Gladney family to evacuate.", "/Images/Beauty/Beauty1.png", "White Noise", 10m, 100 },
                    { 8, 2, "Ousmane and François are two cops with very different styles. The unlikely pair are reunited once again for a new investigation.", "/Images/Beauty/Beauty1.png", "The Takedown", 10m, 100 },
                    { 9, 3, "A man and his ex-wife race to Bali, Indonesia, to stop their daughter from marrying a seaweed farmer. As they desperately try to sabotage the wedding, the bickering duo soon find themselves rekindling old feelings that once made them happy together.", "/Images/Beauty/Beauty1.png", "Ticket to Paradise", 10m, 100 },
                    { 10, 3, "When Superman and the rest of the league get kidnapped by Lex Luthor, it is up to Superdog Krypto to rescue them. He finds a group of shelter pets with superpowers and convinces them to help him.", "/Images/Beauty/Beauty1.png", "DC League of Super-Pets", 10m, 100 },
                    { 11, 3, "A man and his sister discover something sinister in the skies above their California horse ranch, while the owner of a nearby theme park tries to profit from the mysterious, otherworldly phenomenon..", "/Images/Beauty/Beauty1.png", "Nope", 10m, 100 },
                    { 12, 3, "Two inmates form a connection while grappling with their pasts in a state-of-the-art penitentiary run by a brilliant visionary who experiments on his subjects with mind-altering drugs.", "/Images/Beauty/Beauty1.png", "Spiderhead", 10m, 100 },
                    { 13, 4, "After witnessing a bizarre, traumatic incident involving a patient, Dr. Rose Cotter starts experiencing frightening occurrences that she can't explain.", "/Images/Beauty/Beauty1.png", "Smile", 10m, 100 },
                    { 14, 4, "The film, penned by Will Tracy and Seth Reiss, focuses on a young couple who visits an exclusive destination restaurant on a remote island", "/Images/Beauty/Beauty1.png", "The Menu", 10m, 100 },
                    { 15, 4, "After the death of her mother and having no other known relatives, Evie takes a DNA test and discovers a long-lost cousin she never knew she had.", "/Images/Beauty/Beauty1.png", "The Invitation", 10m, 100 },
                    { 16, 4, "A filmmaking crew and the cast make an adult movie at a reclusive place but elderly hosts find them and try to kill them.", "/Images/Beauty/Beauty1.png", "X", 10m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cartitems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
