# 🛒 eShopping

> **Microsoft SQL Server** və **C# (.NET)** ilə hazırlanmış konsol əsaslı onlayn alış-veriş tətbiqi.

---

## 📋 Layihə haqqında

**eShopping** — məhsulları verilənlər bazasında saxlayan və C# vasitəsilə oxuyan sadə bir e-ticarət sistemidir. Layihə SQL Server ilə ADO.NET inteqrasiyasını nümayiş etdirmək üçün yaradılmışdır.

---

## 🗂️ Layihə strukturu

```
eShopping/
├── Program.cs          # Əsas C# tətbiqi — DB bağlantısı və məhsul oxuma
├── Shopping.sql        # Verilənlər bazası sxemi və nümunə məlumatlar
├── .gitignore          # Git tərəfindən nəzərə alınmayacaq fayllar
└── README.md           # Layihə sənədləşməsi
```

---

## 🗃️ Verilənlər bazası sxemi

### `Products` cədvəli

| Sütun | Tip | Açıqlama |
|---|---|---|
| `ProductId` | `INT IDENTITY` | Unikal məhsul identifikatoru (avtomatik) |
| `ProductName` | `NVARCHAR(100)` | Məhsulun adı |
| `ProductColorName` | `NVARCHAR(100)` | Rəng adı (ixtiyari) |
| `ProductPrice` | `DECIMAL(18,2)` | Qiymət (manatla) |
| `ProductDescription` | `NVARCHAR(1000)` | Məhsulun təsviri |

### Nümunə məlumatlar

| # | Məhsul | Qiymət |
|---|---|---|
| 1 | iPhone 15 Pro (Titan Qara) | ₼5,499.99 |
| 2 | Samsung Galaxy S24 (Night Purple) | ₼3,299.99 |
| 3 | Sony WH-1000XM5 (Silver) | ₼1,199.99 |
| 4 | Logitech MX Master 3 (Dark Blue) | ₼449.99 |
| 5 | Dell XPS 15 (Platinum Silver) | ₼8,999.99 |

---

## ⚙️ Tələblər

Layihəni işə salmaq üçün aşağıdakılar lazımdır:

- [.NET 6+](https://dotnet.microsoft.com/download)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server) və ya **SQL Server LocalDB**
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (tövsiyə olunur)
- NuGet paketi: `Microsoft.Data.SqlClient`

---

## 🚀 Quraşdırma və İşə Salma

### 1. Layihəni klonlayın

```bash
git clone https://github.com/istifadeciadı/eShopping.git
cd eShopping
```

### 2. Verilənlər bazasını yaradın

SQL Server Management Studio (SSMS) və ya `sqlcmd` vasitəsilə `Shopping.sql` faylını icra edin:

```bash
sqlcmd -S "(localdb)\MSSQLLocalDB" -i Shopping.sql
```

### 3. Bağlantı sətirini yoxlayın

`Program.cs` faylında bağlantı sətiri bu formatda olmalıdır:

```csharp
string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=eShopping;Trusted_Connection=True;TrustServerCertificate=True;";
```

### 4. Tətbiqi işə salın

```bash
dotnet run
```

---

## 💻 Nümunə Çıxış

```
Dataya qoşulur...

Product Id: 1
Product Name: IPhone 15 Pro
Product Price: 5499.99
Test description: Apple IPhone 15 Pro 256GB yaddas, A17 Pro cip, Titanium

Product Id: 2
Product Name: Samsung Galaxy S24
Product Price: 3299.99
Test description: Samsung Galaxy S24 128GB, Snapdragon 8 Gen 3, 50MP kamera

...
```

---

## 🛠️ İstifadə olunan texnologiyalar

| Texnologiya | Versiya | Məqsəd |
|---|---|---|
| C# / .NET | 6+ | Əsas proqramlaşdırma dili |
| Microsoft SQL Server | LocalDB | Verilənlər bazası |
| ADO.NET (`SqlClient`) | — | DB bağlantısı və sorğular |
| T-SQL | — | Cədvəl yaratma və məlumat daxil etmə |

---

## 🔮 Gələcək planlar

- [ ] Məhsul axtarışı (ad, qiymət aralığına görə)
- [ ] Yeni məhsul əlavə etmə imkanı
- [ ] Məhsul silmə və yeniləmə (CRUD)
- [ ] Kateqoriyalar üzrə filtrləmə
- [ ] İstifadəçi girişi və sifariş sistemi

---

<p align="center">
  C# və SQL Server ilə hazırlanmışdır ❤️
</p>