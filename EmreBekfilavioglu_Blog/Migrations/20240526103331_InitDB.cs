using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmreBekfilavioglu_Blog.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeSoyadi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UyeAciklamasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UyeResmi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Konular",
                columns: table => new
                {
                    KonuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonuAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Konular", x => x.KonuID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Makaleler",
                columns: table => new
                {
                    MakaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icerik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YazimTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OkumaSuresi = table.Column<int>(type: "int", nullable: false),
                    OkunmaSayisi = table.Column<int>(type: "int", nullable: false),
                    UyeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makaleler", x => x.MakaleID);
                    table.ForeignKey(
                        name: "FK_Makaleler_AspNetUsers_UyeID",
                        column: x => x.UyeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KonuUyeler",
                columns: table => new
                {
                    KonuUyeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonuID = table.Column<int>(type: "int", nullable: false),
                    UyeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonuUyeler", x => x.KonuUyeID);
                    table.ForeignKey(
                        name: "FK_KonuUyeler_AspNetUsers_UyeID",
                        column: x => x.UyeID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonuUyeler_Konular_KonuID",
                        column: x => x.KonuID,
                        principalTable: "Konular",
                        principalColumn: "KonuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KonuMakaleler",
                columns: table => new
                {
                    KonuMakaleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KonuID = table.Column<int>(type: "int", nullable: false),
                    MakaleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KonuMakaleler", x => x.KonuMakaleID);
                    table.ForeignKey(
                        name: "FK_KonuMakaleler_Konular_KonuID",
                        column: x => x.KonuID,
                        principalTable: "Konular",
                        principalColumn: "KonuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KonuMakaleler_Makaleler_MakaleID",
                        column: x => x.MakaleID,
                        principalTable: "Makaleler",
                        principalColumn: "MakaleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "9602492e-1924-47ec-a4b6-9ea6edcf29f8", "Uye", "UYE" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UyeAciklamasi", "UyeAdi", "UyeResmi", "UyeSoyadi" },
                values: new object[] { 1, 0, "64ea3b2a-2d19-45fd-84ec-38d36ca8471c", "emre@gmail.com", false, false, null, "EMRE@GMAIL.COM", "EMRE@GMAIL.COM", "AQAAAAIAAYagAAAAEIO8TKJKNedEtZCLbQ55jEJsEQ/e+3wtLyhmytvv67eVpW/I8pMVDpVW+Tfk24rlWw==", null, false, "4596abc1-419a-41eb-a1d7-2d1a1294be5f", false, "emre@gmail.com", "KD-20 BilgeAdam Boost Ogrencisi", "Emre", null, "Bekfilavi" });

            migrationBuilder.InsertData(
                table: "Konular",
                columns: new[] { "KonuID", "KonuAdi" },
                values: new object[,]
                {
                    { 1, "Bilim" },
                    { 2, "Spor" },
                    { 3, "Yazılım" },
                    { 4, "Edebiyat" },
                    { 5, "Teknoloji" },
                    { 6, "Kişisel Gelişim" },
                    { 7, "Oyun" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Makaleler",
                columns: new[] { "MakaleID", "Baslik", "Icerik", "OkumaSuresi", "OkunmaSayisi", "UyeID", "YazimTarihi" },
                values: new object[,]
                {
                    { 1, "C# Programlama Dilinin Gücü ve Kullanım Alanları", "C# (C-sharp), Microsoft tarafından geliştirilen ve .NET platformunun temelini oluşturan, güçlü ve çok yönlü bir programlama dilidir. 2000 yılında piyasaya sürülen bu dil, başta Windows tabanlı uygulamalar geliştirmek için tasarlanmış olsa da, zamanla çok çeşitli platformlarda kullanılabilir hale gelmiştir. C#, Java ve C++ gibi dillerden esinlenerek, nesne yönelimli programlama (OOP) paradigmasını destekler ve geliştiricilere modüler, ölçeklenebilir ve bakımı kolay yazılımlar oluşturma imkanı tanır.\r\n\r\nC#'ın en büyük avantajlarından biri, geniş ve zengin bir kütüphane seti olan .NET Framework ile birlikte gelmesidir. Bu framework, geliştiricilere dosya işlemleri, veri tabanı erişimi, web servisleri ve kullanıcı arayüzleri gibi yaygın görevler için önceden yazılmış kodlar sunar. Ayrıca, C# ve .NET Core'un birleşimi sayesinde, bu dil ile Linux ve macOS gibi farklı işletim sistemlerinde de uygulamalar geliştirmek mümkündür. Bu, C#'ı çapraz platform projeleri için cazip bir seçenek haline getirir.\r\n\r\nDil, aynı zamanda güçlü bir tip güvenliği sağlar. Bu, hataların erken tespit edilmesine ve kodun daha güvenilir olmasına yardımcı olur. C# dilindeki istisna işleme mekanizması, hataların etkin bir şekilde yönetilmesine olanak tanır ve uygulamaların çökmesini önler. Bu özellikler, özellikle büyük ve karmaşık projelerde, kod kalitesini ve güvenliğini artırmak için son derece değerlidir.\r\n\r\nC# ayrıca, modern yazılım geliştirme trendlerini takip eden özelliklere sahiptir. Örneğin, LINQ (Language Integrated Query) ile geliştiriciler, veri koleksiyonları üzerinde daha okunabilir ve daha az hata içeren sorgular yazabilirler. Asenkron programlama için sunulan async ve await anahtar kelimeleri, uygulamaların performansını artırmak ve daha duyarlı hale getirmek için idealdir. Bu özellikler, geliştiricilere daha verimli ve etkili kod yazma imkanı sunar.\r\n\r\nSonuç olarak, C#, hem yeni başlayanlar hem de deneyimli geliştiriciler için güçlü bir araç seti sunan bir programlama dilidir. Microsoft'un sürekli olarak güncellediği ve geliştirdiği bu dil, endüstride geniş bir kabul görmüş ve pek çok farklı kullanım alanına hitap etmektedir. Masaüstü uygulamalarından mobil uygulamalara, oyun geliştirmeden web servislerine kadar geniş bir yelpazede C# ile projeler geliştirmek mümkündür. Bu da onu, yazılım dünyasında önemli ve değerli bir dil haline getirir.", 10, 0, 1, new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6546) },
                    { 2, "Sporun İnsan Sağlığı Üzerindeki Olumlu Etkileri", "Spor, bireylerin fiziksel ve zihinsel sağlığını iyileştirmek için en etkili yöntemlerden biridir. Düzenli fiziksel aktivite, kas ve kemik sağlığını geliştirir, kalp-damar sistemini güçlendirir ve genel vücut fonksiyonlarını optimize eder. Özellikle çocukluk ve ergenlik döneminde yapılan spor, büyüme ve gelişmeye katkıda bulunurken, yetişkinlikte ise kas kütlesinin korunmasına ve yaşlanma sürecinin yavaşlatılmasına yardımcı olur. Sporun bu fiziksel faydaları, bireylerin yaşam kalitesini artırır ve daha uzun, sağlıklı bir yaşam sürmelerini sağlar.\r\n\r\nBunun yanı sıra, spor yapmak ruh sağlığı üzerinde de olumlu etkilere sahiptir. Fiziksel aktivite sırasında salgılanan endorfin hormonları, kişinin ruh halini iyileştirir ve stresle başa çıkma yeteneğini artırır. Depresyon ve anksiyete gibi zihinsel sağlık sorunlarıyla mücadelede sporun önemli bir rolü olduğu bilimsel olarak kanıtlanmıştır. Düzenli spor yapmanın, uyku kalitesini artırarak kişinin genel mutluluğunu ve yaşamdan aldığı tatmini de artırdığı gözlemlenmiştir.\r\n\r\nSporun sosyal faydaları da göz ardı edilemez. Takım sporları, bireylerin sosyal becerilerini geliştirmelerine yardımcı olur ve sosyal bağlarını güçlendirir. Spor, disiplin, işbirliği, liderlik ve sorumluluk gibi önemli değerleri öğretir. Ayrıca, spor etkinliklerine katılmak, yeni insanlarla tanışma ve yeni arkadaşlıklar kurma fırsatı sunar. Bu sosyal etkileşimler, bireylerin kendine güvenini artırır ve toplum içinde daha aktif ve mutlu bireyler olmalarını sağlar.\r\n\r\nSporun eğitim üzerindeki etkileri de dikkate değerdir. Spor yapmak, çocukların ve gençlerin akademik başarılarını olumlu yönde etkileyebilir. Fiziksel aktivite, beyin fonksiyonlarını geliştirir ve konsantrasyon, hafıza ve problem çözme yeteneklerini artırır. Sporun, öğrencilerin okula olan bağlılıklarını ve motivasyonlarını artırarak daha başarılı bir eğitim hayatı sürmelerine katkıda bulunduğu gözlemlenmiştir. Ayrıca, sporun getirdiği disiplin ve zaman yönetimi becerileri, akademik başarıya doğrudan yansır.\r\n\r\nSonuç olarak, sporun insan hayatındaki rolü sadece fiziksel sağlıkla sınırlı kalmaz; ruhsal, sosyal ve eğitsel alanlarda da önemli katkılar sağlar. Düzenli spor yapmak, bireylerin genel sağlığını ve yaşam kalitesini artırırken, toplum içinde daha aktif ve mutlu bireyler olmalarına yardımcı olur. Bu nedenle, sporun günlük hayatın ayrılmaz bir parçası haline getirilmesi ve her yaştan insanın spor yapmaya teşvik edilmesi büyük önem taşır.", 10, 0, 1, new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6563) },
                    { 3, "Edebiyatın Toplum ve Birey Üzerindeki Dönüştürücü Gücü", "Edebiyat, insanlık tarihinin en eski ve en etkili sanat formlarından biridir. Yalnızca estetik bir zevk sunmakla kalmaz, aynı zamanda bireylerin ve toplumların düşünce yapısını, değerlerini ve kültürel normlarını şekillendirir. Edebiyat, yazılı ve sözlü ifadeler aracılığıyla insan deneyimlerini, duygularını ve düşüncelerini aktarmanın güçlü bir yoludur. Bu nedenle, edebiyatın toplumsal ve bireysel dönüşüm üzerindeki etkisi, tarih boyunca sürekli olarak hissedilmiştir.\r\n\r\nToplumsal düzeyde edebiyat, tarihsel olayları, kültürel değişimleri ve sosyal adaletsizlikleri belgelemenin ve eleştirmenin önemli bir aracı olmuştur. Örneğin, Charles Dickens'ın romanları, 19. yüzyıl İngiltere'sinin sosyal ve ekonomik koşullarını canlı bir şekilde tasvir ederken, toplumsal reform çağrılarına ilham vermiştir. Aynı şekilde, George Orwell'in \"1984\" gibi distopik eserleri, totaliter rejimlerin tehlikelerine dikkat çekerek okuyucuları politik ve sosyal bilinçlenmeye yönlendirmiştir. Edebiyat, bu tür eserler aracılığıyla toplumun aynası olur ve değişim için güçlü bir motivasyon kaynağı sağlar.\r\n\r\nBireysel düzeyde ise edebiyat, okuyucuların empati kurma yeteneklerini geliştirir ve farklı bakış açılarını anlamalarına yardımcı olur. Bir roman karakterinin yaşadığı zorlukları, sevinçleri ve acıları deneyimlemek, okuyucunun kendi hayatındaki benzer durumları daha derinlemesine anlamasına olanak tanır. Bu bağlamda, edebiyat, kişisel gelişim ve duygusal zekanın gelişimi için önemli bir araçtır. Ayrıca, şiir, deneme ve diğer edebi türler, bireylerin kendi iç dünyalarını keşfetmelerine ve ifade etmelerine yardımcı olur.\r\n\r\nEdebiyat aynı zamanda dilin zenginliğini ve gücünü ortaya koyar. Edebi eserler, kelimelerin ve cümlelerin nasıl ustalıkla kullanılabileceğini gösterir ve okuyucuların dil becerilerini geliştirir. Dilin sanatsal kullanımı, okuyuculara yeni kelimeler ve ifadeler öğretirken, dilin güzelliklerini ve inceliklerini keşfetmelerine de olanak tanır. Bu, özellikle genç okuyucular için dil ve okuma sevgisinin gelişmesinde kritik bir rol oynar. Edebiyatın sunduğu bu dilsel zenginlik, bireylerin kendilerini daha etkili ve yaratıcı bir şekilde ifade etmelerini sağlar.\r\n\r\nSonuç olarak, edebiyatın toplum ve birey üzerindeki etkisi derin ve çok yönlüdür. Toplumsal adaleti savunan, kültürel mirası koruyan ve kişisel gelişimi teşvik eden edebi eserler, hem bireylerin hem de toplumların dönüşümüne katkıda bulunur. Edebiyat, insan deneyiminin tüm yelpazesini kucaklayarak, okuyucularına farklı dünyalar sunar ve onları daha bilinçli, empatik ve ifade gücü yüksek bireyler haline getirir. Bu nedenle, edebiyatın değerini ve önemini her zaman vurgulamak ve onu hayatımızın bir parçası haline getirmek büyük bir önem taşır.", 10, 0, 1, new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6564) },
                    { 4, "Kişisel Gelişim: Bireysel Potansiyelin Keşfi ve Geliştirilmesi", "Kişisel gelişim, bireyin kendini tanıması, potansiyelini fark etmesi ve bu potansiyeli en üst düzeye çıkarması sürecidir. Bu süreç, yaşamın farklı alanlarında sürekli olarak öğrenme, büyüme ve gelişme anlamına gelir. Kişisel gelişim, sadece profesyonel başarıya ulaşmak için değil, aynı zamanda daha tatmin edici ve dengeli bir yaşam sürmek için de önemlidir. Kendini geliştirme çabası, bireyin hedeflerine ulaşmasını ve hayatın sunduğu zorluklarla başa çıkma yeteneğini artırır.\r\n\r\nBu süreçte, bireyin kendi güçlü ve zayıf yönlerini analiz etmesi kritik bir adımdır. Güçlü yönlerin farkında olmak, bu alanlarda daha fazla gelişmeyi teşvik ederken, zayıf yönlerin tanınması ve üzerinde çalışılması, kişisel ve profesyonel yaşamda daha sağlam adımlar atılmasına yardımcı olur. Kendi kendine değerlendirme ve geri bildirim alma alışkanlığı, bireyin kendini sürekli olarak yenilemesine ve geliştirmesine olanak tanır. Bu, aynı zamanda kişinin özgüvenini artırır ve yaşamını daha bilinçli bir şekilde yönlendirmesine yardımcı olur.\r\n\r\nKişisel gelişimin bir diğer önemli boyutu, hedef belirleme ve bu hedeflere ulaşma stratejilerinin geliştirilmesidir. Belirlenen hedefler, kişisel gelişim yolculuğunda bir rehber işlevi görür. Hedeflere ulaşmak için somut ve uygulanabilir planlar yapmak, bireyin motivasyonunu yüksek tutar ve başarıya ulaşma olasılığını artırır. Ayrıca, bu hedeflere ulaşma sürecinde karşılaşılan engeller ve başarısızlıklar, öğrenme fırsatları olarak görülmeli ve gelişim sürecinin bir parçası olarak değerlendirilmelidir.\r\n\r\nKişisel gelişim, aynı zamanda sürekli öğrenmeyi ve kendini yenilemeyi içerir. Bu, sadece formel eğitim yoluyla değil, aynı zamanda günlük yaşam deneyimleri, kitaplar, seminerler, atölye çalışmaları ve mentorluk gibi farklı kaynaklardan da sağlanabilir. Sürekli öğrenme alışkanlığı, bireyin zihinsel esnekliğini artırır ve yeni beceriler kazanmasına yardımcı olur. Teknolojinin hızla geliştiği bir dünyada, bu öğrenme süreci, bireyin çağın gereksinimlerine uyum sağlamasını ve rekabetçi kalmasını sağlar.\r\n\r\nSonuç olarak, kişisel gelişim, bireyin yaşam kalitesini artıran, hedeflerine ulaşmasına yardımcı olan ve sürekli büyüme ve öğrenmeyi teşvik eden bir süreçtir. Kendi kendini değerlendirme, hedef belirleme, sürekli öğrenme ve gelişim stratejileri uygulama gibi adımlar, bu sürecin temel bileşenleridir. Kişisel gelişim yolculuğu, bireyin potansiyelini en üst düzeye çıkarmasına ve daha tatmin edici, dengeli ve başarılı bir yaşam sürmesine olanak tanır. Bu nedenle, kişisel gelişim, hayatın her aşamasında üzerinde durulması gereken önemli bir konudur.", 10, 0, 1, new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6565) },
                    { 5, "Video Oyunlarının Toplum ve Birey Üzerindeki Etkileri", "Video oyunları, son birkaç on yılda büyük bir evrim geçirerek basit eğlencelerden karmaşık ve derinlemesine deneyimlere dönüşmüştür. Bu gelişim, oyunların kültürel, sosyal ve ekonomik alanlarda önemli bir rol oynamasına neden olmuştur. Video oyunları, sadece gençlerin değil, her yaştan insanın ilgisini çeken ve onları kendine çeken bir eğlence biçimi haline gelmiştir. Bu makale, video oyunlarının bireyler ve toplum üzerindeki etkilerini incelemektedir.\r\n\r\nBirçok araştırma, video oyunlarının bilişsel yetenekler üzerindeki olumlu etkilerini ortaya koymaktadır. Strateji ve bulmaca oyunları, oyuncuların problem çözme becerilerini, eleştirel düşünme yeteneklerini ve hafızalarını geliştirmelerine yardımcı olabilir. Ayrıca, refleks oyunları ve aksiyon oyunları, el-göz koordinasyonu ve hızlı karar verme becerilerini artırır. Bu tür oyunlar, oyuncuların zihinsel esnekliklerini geliştirerek günlük yaşamda daha etkili olmalarına katkıda bulunabilir.\r\n\r\nVideo oyunlarının sosyal faydaları da göz ardı edilmemelidir. Çevrimiçi çok oyunculu oyunlar, dünyanın dört bir yanından insanlarla etkileşime geçme ve işbirliği yapma fırsatı sunar. Bu oyunlar, sosyal becerilerin gelişimine katkıda bulunarak, takım çalışması, liderlik ve iletişim becerilerini güçlendirir. Özellikle pandemi döneminde, video oyunları sosyal bağlantıyı sürdürmek ve izolasyonu azaltmak için önemli bir araç haline gelmiştir.\r\n\r\nAncak, video oyunlarının olumsuz etkileri de dikkate alınmalıdır. Aşırı oyun oynamak, fiziksel sağlık sorunlarına, uyku düzeninde bozulmalara ve sosyal izolasyona yol açabilir. Ayrıca, şiddet içeren oyunların, bazı bireylerde agresif davranışları tetikleyebileceği yönünde endişeler bulunmaktadır. Bu nedenle, oyun oynama süresinin dengeli ve sağlıklı bir şekilde yönetilmesi önemlidir. Ebeveynler ve oyuncular, oyun seçiminde dikkatli olmalı ve oyun süresini kontrol altında tutmalıdır.\r\n\r\nSonuç olarak, video oyunları modern toplumun vazgeçilmez bir parçası haline gelmiştir. Bilişsel ve sosyal faydalar sağlarken, potansiyel olumsuz etkileri de göz önünde bulundurulmalıdır. Denge ve sorumluluk bilinciyle oyun oynamak, bu etkinliğin bireyler ve toplum üzerindeki olumlu etkilerini maksimize ederken, olumsuz sonuçlarını minimize edebilir. Video oyunları, doğru kullanıldığında, hem eğlenceli hem de eğitici bir araç olabilir. Bu nedenle, oyun kültürünü anlamak ve bu kültürün getirdiği fırsatları ve zorlukları dikkatle değerlendirmek önemlidir.\r\n\r\n\r\n\r\n\r\n\r\n", 10, 0, 1, new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6567) }
                });

            migrationBuilder.InsertData(
                table: "KonuMakaleler",
                columns: new[] { "KonuMakaleID", "KonuID", "MakaleID" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 5, 1 },
                    { 3, 2, 2 },
                    { 4, 4, 3 },
                    { 5, 6, 4 },
                    { 6, 7, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KonuMakaleler_KonuID",
                table: "KonuMakaleler",
                column: "KonuID");

            migrationBuilder.CreateIndex(
                name: "IX_KonuMakaleler_MakaleID",
                table: "KonuMakaleler",
                column: "MakaleID");

            migrationBuilder.CreateIndex(
                name: "IX_KonuUyeler_KonuID",
                table: "KonuUyeler",
                column: "KonuID");

            migrationBuilder.CreateIndex(
                name: "IX_KonuUyeler_UyeID",
                table: "KonuUyeler",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "IX_Makaleler_UyeID",
                table: "Makaleler",
                column: "UyeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "KonuMakaleler");

            migrationBuilder.DropTable(
                name: "KonuUyeler");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Makaleler");

            migrationBuilder.DropTable(
                name: "Konular");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
