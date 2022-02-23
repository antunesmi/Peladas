using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Peladas_WEBAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocaisP",
                columns: table => new
                {
                    localPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeLocal = table.Column<string>(nullable: true),
                    apelido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocaisP", x => x.localPId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    usuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeCompleto = table.Column<string>(nullable: true),
                    apelido = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.usuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Peladas",
                columns: table => new
                {
                    peladaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeEvento = table.Column<string>(nullable: true),
                    dataEvento = table.Column<DateTime>(nullable: false),
                    horaEvento = table.Column<DateTime>(nullable: false),
                    dataAgend = table.Column<DateTime>(nullable: false),
                    localPId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peladas", x => x.peladaId);
                    table.ForeignKey(
                        name: "FK_Peladas_LocaisP_localPId",
                        column: x => x.localPId,
                        principalTable: "LocaisP",
                        principalColumn: "localPId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agendamentos",
                columns: table => new
                {
                    peladaId = table.Column<int>(nullable: false),
                    usuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agendamentos", x => new { x.usuarioId, x.peladaId });
                    table.ForeignKey(
                        name: "FK_Agendamentos_Peladas_peladaId",
                        column: x => x.peladaId,
                        principalTable: "Peladas",
                        principalColumn: "peladaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agendamentos_Usuario_usuarioId",
                        column: x => x.usuarioId,
                        principalTable: "Usuario",
                        principalColumn: "usuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "LocaisP",
                columns: new[] { "localPId", "apelido", "nomeLocal" },
                values: new object[,]
                {
                    { 1, "Renato Russo", "Ginásio Renato Manfredini" },
                    { 2, "Cazuzão", "Ginásio Agenor Miranda" },
                    { 3, "Leoni", "Quadra Carlos Leoni" },
                    { 4, "Frejat", "Quadra Roberto Frejat" },
                    { 5, "PR", "Campo Síntético Paulo Ricardo" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "usuarioId", "apelido", "email", "nomeCompleto", "senha" },
                values: new object[,]
                {
                    { 1, "Táta", "tata@gmail.com", "Marta Antunes", "prodeb" },
                    { 2, "Paulinha", "Paulinha@gmail.com", "Paula Nascimento", "prodeb" },
                    { 3, "Laurinha", "tata@gmail.com", "Laura Barros", "prodeb" },
                    { 4, "Lúh", "luh@gmail.com", "Luiza Santiago", "prodeb" },
                    { 5, "Kazão", "kazao@gmail.com", "Lucas Ferreira", "prodeb" },
                    { 6, "Pedroca", "droca@gmail.com", "Pedro Silva", "prodeb" },
                    { 7, "Paulito", "lito@gmail.com", "Paulo Santos", "prodeb" }
                });

            migrationBuilder.InsertData(
                table: "Peladas",
                columns: new[] { "peladaId", "dataAgend", "dataEvento", "horaEvento", "localPId", "nomeEvento" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 22, 21, 6, 0, 522, DateTimeKind.Local).AddTicks(7584), new DateTime(2022, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, "Grupo Ypiranga" },
                    { 2, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, "Grupo Bahia" },
                    { 6, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6838), new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 8, 0, 0, 0, DateTimeKind.Unspecified), 2, "Grupo Galícia" },
                    { 3, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6812), new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 3, "Grupo Vitória" },
                    { 7, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 9, 30, 0, 0, DateTimeKind.Unspecified), 3, "Grupo Cruzeiro do Sul" },
                    { 4, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6822), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 18, 0, 0, 0, DateTimeKind.Unspecified), 4, "Grupo Botafogo SSA" },
                    { 5, new DateTime(2022, 2, 22, 21, 6, 0, 525, DateTimeKind.Local).AddTicks(6829), new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 7, 0, 0, 0, DateTimeKind.Unspecified), 5, "Grupo Leônico" }
                });

            migrationBuilder.InsertData(
                table: "Agendamentos",
                columns: new[] { "usuarioId", "peladaId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 3 },
                    { 1, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_peladaId",
                table: "Agendamentos",
                column: "peladaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peladas_localPId",
                table: "Peladas",
                column: "localPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agendamentos");

            migrationBuilder.DropTable(
                name: "Peladas");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "LocaisP");
        }
    }
}
