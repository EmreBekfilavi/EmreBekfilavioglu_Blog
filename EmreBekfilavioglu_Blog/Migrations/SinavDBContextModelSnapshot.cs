﻿// <auto-generated />
using System;
using EmreBekfilavioglu_Blog.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmreBekfilavioglu_Blog.Migrations
{
    [DbContext(typeof(SinavDBContext))]
    partial class SinavDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Identity.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "9602492e-1924-47ec-a4b6-9ea6edcf29f8",
                            Name = "Uye",
                            NormalizedName = "UYE"
                        });
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Identity.Uye", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("UyeAciklamasi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeResmi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UyeSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "64ea3b2a-2d19-45fd-84ec-38d36ca8471c",
                            Email = "emre@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "EMRE@GMAIL.COM",
                            NormalizedUserName = "EMRE@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEIO8TKJKNedEtZCLbQ55jEJsEQ/e+3wtLyhmytvv67eVpW/I8pMVDpVW+Tfk24rlWw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4596abc1-419a-41eb-a1d7-2d1a1294be5f",
                            TwoFactorEnabled = false,
                            UserName = "emre@gmail.com",
                            UyeAciklamasi = "KD-20 BilgeAdam Boost Ogrencisi",
                            UyeAdi = "Emre",
                            UyeSoyadi = "Bekfilavi"
                        });
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Konu", b =>
                {
                    b.Property<int>("KonuID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KonuID"));

                    b.Property<string>("KonuAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KonuID");

                    b.ToTable("Konular");

                    b.HasData(
                        new
                        {
                            KonuID = 1,
                            KonuAdi = "Bilim"
                        },
                        new
                        {
                            KonuID = 2,
                            KonuAdi = "Spor"
                        },
                        new
                        {
                            KonuID = 3,
                            KonuAdi = "Yazılım"
                        },
                        new
                        {
                            KonuID = 4,
                            KonuAdi = "Edebiyat"
                        },
                        new
                        {
                            KonuID = 5,
                            KonuAdi = "Teknoloji"
                        },
                        new
                        {
                            KonuID = 6,
                            KonuAdi = "Kişisel Gelişim"
                        },
                        new
                        {
                            KonuID = 7,
                            KonuAdi = "Oyun"
                        });
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.KonuMakale", b =>
                {
                    b.Property<int>("KonuMakaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KonuMakaleID"));

                    b.Property<int>("KonuID")
                        .HasColumnType("int");

                    b.Property<int>("MakaleID")
                        .HasColumnType("int");

                    b.HasKey("KonuMakaleID");

                    b.HasIndex("KonuID");

                    b.HasIndex("MakaleID");

                    b.ToTable("KonuMakaleler");

                    b.HasData(
                        new
                        {
                            KonuMakaleID = 1,
                            KonuID = 3,
                            MakaleID = 1
                        },
                        new
                        {
                            KonuMakaleID = 2,
                            KonuID = 5,
                            MakaleID = 1
                        },
                        new
                        {
                            KonuMakaleID = 3,
                            KonuID = 2,
                            MakaleID = 2
                        },
                        new
                        {
                            KonuMakaleID = 4,
                            KonuID = 4,
                            MakaleID = 3
                        },
                        new
                        {
                            KonuMakaleID = 5,
                            KonuID = 6,
                            MakaleID = 4
                        },
                        new
                        {
                            KonuMakaleID = 6,
                            KonuID = 7,
                            MakaleID = 5
                        });
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.KonuUye", b =>
                {
                    b.Property<int>("KonuUyeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KonuUyeID"));

                    b.Property<int>("KonuID")
                        .HasColumnType("int");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.HasKey("KonuUyeID");

                    b.HasIndex("KonuID");

                    b.HasIndex("UyeID");

                    b.ToTable("KonuUyeler");
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Makale", b =>
                {
                    b.Property<int>("MakaleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MakaleID"));

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OkumaSuresi")
                        .HasColumnType("int");

                    b.Property<int>("OkunmaSayisi")
                        .HasColumnType("int");

                    b.Property<int>("UyeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("YazimTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("MakaleID");

                    b.HasIndex("UyeID");

                    b.ToTable("Makaleler");

                    b.HasData(
                        new
                        {
                            MakaleID = 1,
                            Baslik = "C# Programlama Dilinin Gücü ve Kullanım Alanları",
                            Icerik = "C# (C-sharp), Microsoft tarafından geliştirilen ve .NET platformunun temelini oluşturan, güçlü ve çok yönlü bir programlama dilidir. 2000 yılında piyasaya sürülen bu dil, başta Windows tabanlı uygulamalar geliştirmek için tasarlanmış olsa da, zamanla çok çeşitli platformlarda kullanılabilir hale gelmiştir. C#, Java ve C++ gibi dillerden esinlenerek, nesne yönelimli programlama (OOP) paradigmasını destekler ve geliştiricilere modüler, ölçeklenebilir ve bakımı kolay yazılımlar oluşturma imkanı tanır.\r\n\r\nC#'ın en büyük avantajlarından biri, geniş ve zengin bir kütüphane seti olan .NET Framework ile birlikte gelmesidir. Bu framework, geliştiricilere dosya işlemleri, veri tabanı erişimi, web servisleri ve kullanıcı arayüzleri gibi yaygın görevler için önceden yazılmış kodlar sunar. Ayrıca, C# ve .NET Core'un birleşimi sayesinde, bu dil ile Linux ve macOS gibi farklı işletim sistemlerinde de uygulamalar geliştirmek mümkündür. Bu, C#'ı çapraz platform projeleri için cazip bir seçenek haline getirir.\r\n\r\nDil, aynı zamanda güçlü bir tip güvenliği sağlar. Bu, hataların erken tespit edilmesine ve kodun daha güvenilir olmasına yardımcı olur. C# dilindeki istisna işleme mekanizması, hataların etkin bir şekilde yönetilmesine olanak tanır ve uygulamaların çökmesini önler. Bu özellikler, özellikle büyük ve karmaşık projelerde, kod kalitesini ve güvenliğini artırmak için son derece değerlidir.\r\n\r\nC# ayrıca, modern yazılım geliştirme trendlerini takip eden özelliklere sahiptir. Örneğin, LINQ (Language Integrated Query) ile geliştiriciler, veri koleksiyonları üzerinde daha okunabilir ve daha az hata içeren sorgular yazabilirler. Asenkron programlama için sunulan async ve await anahtar kelimeleri, uygulamaların performansını artırmak ve daha duyarlı hale getirmek için idealdir. Bu özellikler, geliştiricilere daha verimli ve etkili kod yazma imkanı sunar.\r\n\r\nSonuç olarak, C#, hem yeni başlayanlar hem de deneyimli geliştiriciler için güçlü bir araç seti sunan bir programlama dilidir. Microsoft'un sürekli olarak güncellediği ve geliştirdiği bu dil, endüstride geniş bir kabul görmüş ve pek çok farklı kullanım alanına hitap etmektedir. Masaüstü uygulamalarından mobil uygulamalara, oyun geliştirmeden web servislerine kadar geniş bir yelpazede C# ile projeler geliştirmek mümkündür. Bu da onu, yazılım dünyasında önemli ve değerli bir dil haline getirir.",
                            OkumaSuresi = 10,
                            OkunmaSayisi = 0,
                            UyeID = 1,
                            YazimTarihi = new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6546)
                        },
                        new
                        {
                            MakaleID = 2,
                            Baslik = "Sporun İnsan Sağlığı Üzerindeki Olumlu Etkileri",
                            Icerik = "Spor, bireylerin fiziksel ve zihinsel sağlığını iyileştirmek için en etkili yöntemlerden biridir. Düzenli fiziksel aktivite, kas ve kemik sağlığını geliştirir, kalp-damar sistemini güçlendirir ve genel vücut fonksiyonlarını optimize eder. Özellikle çocukluk ve ergenlik döneminde yapılan spor, büyüme ve gelişmeye katkıda bulunurken, yetişkinlikte ise kas kütlesinin korunmasına ve yaşlanma sürecinin yavaşlatılmasına yardımcı olur. Sporun bu fiziksel faydaları, bireylerin yaşam kalitesini artırır ve daha uzun, sağlıklı bir yaşam sürmelerini sağlar.\r\n\r\nBunun yanı sıra, spor yapmak ruh sağlığı üzerinde de olumlu etkilere sahiptir. Fiziksel aktivite sırasında salgılanan endorfin hormonları, kişinin ruh halini iyileştirir ve stresle başa çıkma yeteneğini artırır. Depresyon ve anksiyete gibi zihinsel sağlık sorunlarıyla mücadelede sporun önemli bir rolü olduğu bilimsel olarak kanıtlanmıştır. Düzenli spor yapmanın, uyku kalitesini artırarak kişinin genel mutluluğunu ve yaşamdan aldığı tatmini de artırdığı gözlemlenmiştir.\r\n\r\nSporun sosyal faydaları da göz ardı edilemez. Takım sporları, bireylerin sosyal becerilerini geliştirmelerine yardımcı olur ve sosyal bağlarını güçlendirir. Spor, disiplin, işbirliği, liderlik ve sorumluluk gibi önemli değerleri öğretir. Ayrıca, spor etkinliklerine katılmak, yeni insanlarla tanışma ve yeni arkadaşlıklar kurma fırsatı sunar. Bu sosyal etkileşimler, bireylerin kendine güvenini artırır ve toplum içinde daha aktif ve mutlu bireyler olmalarını sağlar.\r\n\r\nSporun eğitim üzerindeki etkileri de dikkate değerdir. Spor yapmak, çocukların ve gençlerin akademik başarılarını olumlu yönde etkileyebilir. Fiziksel aktivite, beyin fonksiyonlarını geliştirir ve konsantrasyon, hafıza ve problem çözme yeteneklerini artırır. Sporun, öğrencilerin okula olan bağlılıklarını ve motivasyonlarını artırarak daha başarılı bir eğitim hayatı sürmelerine katkıda bulunduğu gözlemlenmiştir. Ayrıca, sporun getirdiği disiplin ve zaman yönetimi becerileri, akademik başarıya doğrudan yansır.\r\n\r\nSonuç olarak, sporun insan hayatındaki rolü sadece fiziksel sağlıkla sınırlı kalmaz; ruhsal, sosyal ve eğitsel alanlarda da önemli katkılar sağlar. Düzenli spor yapmak, bireylerin genel sağlığını ve yaşam kalitesini artırırken, toplum içinde daha aktif ve mutlu bireyler olmalarına yardımcı olur. Bu nedenle, sporun günlük hayatın ayrılmaz bir parçası haline getirilmesi ve her yaştan insanın spor yapmaya teşvik edilmesi büyük önem taşır.",
                            OkumaSuresi = 10,
                            OkunmaSayisi = 0,
                            UyeID = 1,
                            YazimTarihi = new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6563)
                        },
                        new
                        {
                            MakaleID = 3,
                            Baslik = "Edebiyatın Toplum ve Birey Üzerindeki Dönüştürücü Gücü",
                            Icerik = "Edebiyat, insanlık tarihinin en eski ve en etkili sanat formlarından biridir. Yalnızca estetik bir zevk sunmakla kalmaz, aynı zamanda bireylerin ve toplumların düşünce yapısını, değerlerini ve kültürel normlarını şekillendirir. Edebiyat, yazılı ve sözlü ifadeler aracılığıyla insan deneyimlerini, duygularını ve düşüncelerini aktarmanın güçlü bir yoludur. Bu nedenle, edebiyatın toplumsal ve bireysel dönüşüm üzerindeki etkisi, tarih boyunca sürekli olarak hissedilmiştir.\r\n\r\nToplumsal düzeyde edebiyat, tarihsel olayları, kültürel değişimleri ve sosyal adaletsizlikleri belgelemenin ve eleştirmenin önemli bir aracı olmuştur. Örneğin, Charles Dickens'ın romanları, 19. yüzyıl İngiltere'sinin sosyal ve ekonomik koşullarını canlı bir şekilde tasvir ederken, toplumsal reform çağrılarına ilham vermiştir. Aynı şekilde, George Orwell'in \"1984\" gibi distopik eserleri, totaliter rejimlerin tehlikelerine dikkat çekerek okuyucuları politik ve sosyal bilinçlenmeye yönlendirmiştir. Edebiyat, bu tür eserler aracılığıyla toplumun aynası olur ve değişim için güçlü bir motivasyon kaynağı sağlar.\r\n\r\nBireysel düzeyde ise edebiyat, okuyucuların empati kurma yeteneklerini geliştirir ve farklı bakış açılarını anlamalarına yardımcı olur. Bir roman karakterinin yaşadığı zorlukları, sevinçleri ve acıları deneyimlemek, okuyucunun kendi hayatındaki benzer durumları daha derinlemesine anlamasına olanak tanır. Bu bağlamda, edebiyat, kişisel gelişim ve duygusal zekanın gelişimi için önemli bir araçtır. Ayrıca, şiir, deneme ve diğer edebi türler, bireylerin kendi iç dünyalarını keşfetmelerine ve ifade etmelerine yardımcı olur.\r\n\r\nEdebiyat aynı zamanda dilin zenginliğini ve gücünü ortaya koyar. Edebi eserler, kelimelerin ve cümlelerin nasıl ustalıkla kullanılabileceğini gösterir ve okuyucuların dil becerilerini geliştirir. Dilin sanatsal kullanımı, okuyuculara yeni kelimeler ve ifadeler öğretirken, dilin güzelliklerini ve inceliklerini keşfetmelerine de olanak tanır. Bu, özellikle genç okuyucular için dil ve okuma sevgisinin gelişmesinde kritik bir rol oynar. Edebiyatın sunduğu bu dilsel zenginlik, bireylerin kendilerini daha etkili ve yaratıcı bir şekilde ifade etmelerini sağlar.\r\n\r\nSonuç olarak, edebiyatın toplum ve birey üzerindeki etkisi derin ve çok yönlüdür. Toplumsal adaleti savunan, kültürel mirası koruyan ve kişisel gelişimi teşvik eden edebi eserler, hem bireylerin hem de toplumların dönüşümüne katkıda bulunur. Edebiyat, insan deneyiminin tüm yelpazesini kucaklayarak, okuyucularına farklı dünyalar sunar ve onları daha bilinçli, empatik ve ifade gücü yüksek bireyler haline getirir. Bu nedenle, edebiyatın değerini ve önemini her zaman vurgulamak ve onu hayatımızın bir parçası haline getirmek büyük bir önem taşır.",
                            OkumaSuresi = 10,
                            OkunmaSayisi = 0,
                            UyeID = 1,
                            YazimTarihi = new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6564)
                        },
                        new
                        {
                            MakaleID = 4,
                            Baslik = "Kişisel Gelişim: Bireysel Potansiyelin Keşfi ve Geliştirilmesi",
                            Icerik = "Kişisel gelişim, bireyin kendini tanıması, potansiyelini fark etmesi ve bu potansiyeli en üst düzeye çıkarması sürecidir. Bu süreç, yaşamın farklı alanlarında sürekli olarak öğrenme, büyüme ve gelişme anlamına gelir. Kişisel gelişim, sadece profesyonel başarıya ulaşmak için değil, aynı zamanda daha tatmin edici ve dengeli bir yaşam sürmek için de önemlidir. Kendini geliştirme çabası, bireyin hedeflerine ulaşmasını ve hayatın sunduğu zorluklarla başa çıkma yeteneğini artırır.\r\n\r\nBu süreçte, bireyin kendi güçlü ve zayıf yönlerini analiz etmesi kritik bir adımdır. Güçlü yönlerin farkında olmak, bu alanlarda daha fazla gelişmeyi teşvik ederken, zayıf yönlerin tanınması ve üzerinde çalışılması, kişisel ve profesyonel yaşamda daha sağlam adımlar atılmasına yardımcı olur. Kendi kendine değerlendirme ve geri bildirim alma alışkanlığı, bireyin kendini sürekli olarak yenilemesine ve geliştirmesine olanak tanır. Bu, aynı zamanda kişinin özgüvenini artırır ve yaşamını daha bilinçli bir şekilde yönlendirmesine yardımcı olur.\r\n\r\nKişisel gelişimin bir diğer önemli boyutu, hedef belirleme ve bu hedeflere ulaşma stratejilerinin geliştirilmesidir. Belirlenen hedefler, kişisel gelişim yolculuğunda bir rehber işlevi görür. Hedeflere ulaşmak için somut ve uygulanabilir planlar yapmak, bireyin motivasyonunu yüksek tutar ve başarıya ulaşma olasılığını artırır. Ayrıca, bu hedeflere ulaşma sürecinde karşılaşılan engeller ve başarısızlıklar, öğrenme fırsatları olarak görülmeli ve gelişim sürecinin bir parçası olarak değerlendirilmelidir.\r\n\r\nKişisel gelişim, aynı zamanda sürekli öğrenmeyi ve kendini yenilemeyi içerir. Bu, sadece formel eğitim yoluyla değil, aynı zamanda günlük yaşam deneyimleri, kitaplar, seminerler, atölye çalışmaları ve mentorluk gibi farklı kaynaklardan da sağlanabilir. Sürekli öğrenme alışkanlığı, bireyin zihinsel esnekliğini artırır ve yeni beceriler kazanmasına yardımcı olur. Teknolojinin hızla geliştiği bir dünyada, bu öğrenme süreci, bireyin çağın gereksinimlerine uyum sağlamasını ve rekabetçi kalmasını sağlar.\r\n\r\nSonuç olarak, kişisel gelişim, bireyin yaşam kalitesini artıran, hedeflerine ulaşmasına yardımcı olan ve sürekli büyüme ve öğrenmeyi teşvik eden bir süreçtir. Kendi kendini değerlendirme, hedef belirleme, sürekli öğrenme ve gelişim stratejileri uygulama gibi adımlar, bu sürecin temel bileşenleridir. Kişisel gelişim yolculuğu, bireyin potansiyelini en üst düzeye çıkarmasına ve daha tatmin edici, dengeli ve başarılı bir yaşam sürmesine olanak tanır. Bu nedenle, kişisel gelişim, hayatın her aşamasında üzerinde durulması gereken önemli bir konudur.",
                            OkumaSuresi = 10,
                            OkunmaSayisi = 0,
                            UyeID = 1,
                            YazimTarihi = new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6565)
                        },
                        new
                        {
                            MakaleID = 5,
                            Baslik = "Video Oyunlarının Toplum ve Birey Üzerindeki Etkileri",
                            Icerik = "Video oyunları, son birkaç on yılda büyük bir evrim geçirerek basit eğlencelerden karmaşık ve derinlemesine deneyimlere dönüşmüştür. Bu gelişim, oyunların kültürel, sosyal ve ekonomik alanlarda önemli bir rol oynamasına neden olmuştur. Video oyunları, sadece gençlerin değil, her yaştan insanın ilgisini çeken ve onları kendine çeken bir eğlence biçimi haline gelmiştir. Bu makale, video oyunlarının bireyler ve toplum üzerindeki etkilerini incelemektedir.\r\n\r\nBirçok araştırma, video oyunlarının bilişsel yetenekler üzerindeki olumlu etkilerini ortaya koymaktadır. Strateji ve bulmaca oyunları, oyuncuların problem çözme becerilerini, eleştirel düşünme yeteneklerini ve hafızalarını geliştirmelerine yardımcı olabilir. Ayrıca, refleks oyunları ve aksiyon oyunları, el-göz koordinasyonu ve hızlı karar verme becerilerini artırır. Bu tür oyunlar, oyuncuların zihinsel esnekliklerini geliştirerek günlük yaşamda daha etkili olmalarına katkıda bulunabilir.\r\n\r\nVideo oyunlarının sosyal faydaları da göz ardı edilmemelidir. Çevrimiçi çok oyunculu oyunlar, dünyanın dört bir yanından insanlarla etkileşime geçme ve işbirliği yapma fırsatı sunar. Bu oyunlar, sosyal becerilerin gelişimine katkıda bulunarak, takım çalışması, liderlik ve iletişim becerilerini güçlendirir. Özellikle pandemi döneminde, video oyunları sosyal bağlantıyı sürdürmek ve izolasyonu azaltmak için önemli bir araç haline gelmiştir.\r\n\r\nAncak, video oyunlarının olumsuz etkileri de dikkate alınmalıdır. Aşırı oyun oynamak, fiziksel sağlık sorunlarına, uyku düzeninde bozulmalara ve sosyal izolasyona yol açabilir. Ayrıca, şiddet içeren oyunların, bazı bireylerde agresif davranışları tetikleyebileceği yönünde endişeler bulunmaktadır. Bu nedenle, oyun oynama süresinin dengeli ve sağlıklı bir şekilde yönetilmesi önemlidir. Ebeveynler ve oyuncular, oyun seçiminde dikkatli olmalı ve oyun süresini kontrol altında tutmalıdır.\r\n\r\nSonuç olarak, video oyunları modern toplumun vazgeçilmez bir parçası haline gelmiştir. Bilişsel ve sosyal faydalar sağlarken, potansiyel olumsuz etkileri de göz önünde bulundurulmalıdır. Denge ve sorumluluk bilinciyle oyun oynamak, bu etkinliğin bireyler ve toplum üzerindeki olumlu etkilerini maksimize ederken, olumsuz sonuçlarını minimize edebilir. Video oyunları, doğru kullanıldığında, hem eğlenceli hem de eğitici bir araç olabilir. Bu nedenle, oyun kültürünü anlamak ve bu kültürün getirdiği fırsatları ve zorlukları dikkatle değerlendirmek önemlidir.\r\n\r\n\r\n\r\n\r\n\r\n",
                            OkumaSuresi = 10,
                            OkunmaSayisi = 0,
                            UyeID = 1,
                            YazimTarihi = new DateTime(2024, 5, 26, 13, 33, 31, 258, DateTimeKind.Local).AddTicks(6567)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.KonuMakale", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Konu", "Konu")
                        .WithMany("KonuMakeleler")
                        .HasForeignKey("KonuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmreBekfilavioglu_Blog.Models.Makale", "Makale")
                        .WithMany("KonuMakaleler")
                        .HasForeignKey("MakaleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Konu");

                    b.Navigation("Makale");
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.KonuUye", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Konu", "Konu")
                        .WithMany("KonuUyeler")
                        .HasForeignKey("KonuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", "Uye")
                        .WithMany("TakipEdilenKonular")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Konu");

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Makale", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", "Uye")
                        .WithMany("YazilanMakaleler")
                        .HasForeignKey("UyeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Uye");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Rol", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("EmreBekfilavioglu_Blog.Models.Identity.Uye", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Identity.Uye", b =>
                {
                    b.Navigation("TakipEdilenKonular");

                    b.Navigation("YazilanMakaleler");
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Konu", b =>
                {
                    b.Navigation("KonuMakeleler");

                    b.Navigation("KonuUyeler");
                });

            modelBuilder.Entity("EmreBekfilavioglu_Blog.Models.Makale", b =>
                {
                    b.Navigation("KonuMakaleler");
                });
#pragma warning restore 612, 618
        }
    }
}
