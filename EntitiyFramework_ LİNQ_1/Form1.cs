using EntitiyFramework__LİNQ_1.Design_Patterns.SingletonPattern;
using EntitiyFramework__LİNQ_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitiyFramework__LİNQ_1
{
	public partial class Form1 : Form
	{
		/*
		 LINQ => Language Integrated Query  / Linquery Expression(Lamda Expression) (Lamda Operatörü  => )
		C# içerisinde T-sql'in  rahatça anlayabilcek sorgu komutları yazmaktır.
		Bu desteği sunan metotlar  kendi paremetrelerini  Expression tiipinde arguman beklerler.
		Where

		
		
		_db.Product.Where(x => x.UnitPrice < 20 ).ToList();
		Select * from Product as x Where x.UnitPrice < 20


		LINQ yazımında Lınq destekleyen yazılımlarınız kendilerinden önce hangi yapı geliyorsa
        (üstteki kodlarda önce Products geliyor sonra Categories geliyor)Expression argumanı, Lamda operratörü
		yazldığı anda arguman için kullanılan harfi veya kelimeyi bu yapıyı tekl olarak algılayarak onun suretine bürünür.
		 */
		NorthwindEntities _db;

		public Form1()
		{
			InitializeComponent();
			_db = DBTool.DBInstance;
		}

		private void btnWhere_Click(object sender, EventArgs e)
		{
			//Fiyatı 20 den fazla ve 30 dan az ürünleri listele.
			dgwResult.DataSource = _db.Products.Where(x => x.UnitPrice>20 && x.UnitPrice<30).ToList();
		}

		private void btnOrderBy_Click(object sender, EventArgs e)
		{
			//OrderByAsceding() metodu yoktur.Çünkü OrderBy metodu zaten default olarak asceding yani artan sırada veri getirir.
			//Onun yerine OrderByDescending() metodumuz vardır.

			//dgwResult.DataSource = _db.Products.OrderBy(x=>x.UnitPrice).ToList(); //bu ifade ürünleri fiyatlarına göre artan sırada getirir.
			dgwResult.DataSource = _db.Products.Where(x => x.UnitPrice<20).OrderByDescending(x =>x.UnitPrice).ToList();
		}

		private void btnTake_Click(object sender, EventArgs e)
		{
			//Take : SQL'deki top komutunun buradaki karşılığıdır.Yani dönen sonuçtan Take metoduna içerisine verdiğimiz int arguman kadar satırı listeler.
			//dgwResult.DataSource = _db.Products.Take(1).ToList();
			//En pahalı ürün
			dgwResult.DataSource = _db.Products.OrderByDescending(x => x.UnitPrice).Take(1).ToList();

		}

		private void btnSkip_Click(object sender, EventArgs e)
		{
			//Skip : Offset Verdiğiniz sayı kadar satırı atlar sonraki kayıtları getirir.
			//ikinci pahalı ürün

			dgwResult.DataSource = _db.Products.OrderByDescending(x=>x.UnitPrice).Skip(1).Take(1).ToList();//Gelen ilk veriyi atla diğer ilkini al.
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			//Find ilgili tablonun Primary Key  kolonunda arama yapar.Tek bir nesne döndürüyor.
			//Sadece IQueryable interfaceinden miras almış tipleri veya bizzat o tipleri ToList'e çevirir. 
			//Product p  = _db.Products.Find(2);
			//List<Product> products = new List<Product>{ 
			//p
			//};
			//dgwResult.DataSource = products;


			try
			{
				Product p = _db.Products.Find(Convert.ToInt32(txtID.Text));
				List<Product> products = new List<Product>
				{
					p

				};
				dgwResult.DataSource = products;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
			}
		}

		private void btnSingle_Click(object sender, EventArgs e)
		{
			Product p = _db.Products.Single(x=>x.ProductName == "Chai");
			//Bu sorgudan tek bir değer dönecekse Single() metodu kullanılır.
			

			Product p2 = _db.Products.FirstOrDefault(x=>x.ProductName.StartsWith("c"));
			//FirstOrDefault metodu eğer  birden fazla veri geliyorsa gelen verilerin ilkini alır.Hata vermez.Hiç 
			//veri gelmiyorsa da ilgili alana göre default(varsayılan) değer verir.
		    MessageBox.Show(p2.ProductName);
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			dgwResult.DataSource = _db.Products.ToList();
		}

		private void btnContains_Click(object sender, EventArgs e)
		{
			dgwResult.DataSource = _db.Categories.Where(x=>x.CategoryName.Contains("a")).ToList();
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			dgwResult.DataSource = _db.Categories.Where(x=>x.CategoryName.Contains(txtFirstName.Text)).ToList();
		}

		private void btnVia_Click(object sender, EventArgs e)
		{
			// bu butona tıklandığında kategorisini ismi txtKategoriye yazılmış kategorideki ürünler gelsin.

			dgwResult.DataSource = _db.Products.Where(x => x.Category.CategoryName == txtKategori.Text).ToList();
		}

		private void btnAny_Click(object sender, EventArgs e)
		{
			//Veritabanında aradığınız şey var mı diye sorar.Any metodu verdiğimiz kriterlere göre bir veri tabanında araış olduğumuz değer var mı diye sorgular.
			//bool değer döndürür.

			if (_db.Employees.Any(x => x.FirstName == txtFirstName.Text) && _db.Employees.Any(x => x.LastName == txtLastName.Text)) {
				MessageBox.Show("Hoşgeldiniz.");
			}
			else
			{
				MessageBox.Show("Bçyle bir kullanıcı bulunamadı.");
			}
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			dgwResult.DataSource = _db.Categories.Select(x => new { KategoriIsmi = x.CategoryName, Acıklaması = x.Description }).ToList();


			//Anonim tipleri Linq ifadelerinde sadece Select metodu destekler.
			//Anonim Tipler

			//CategoryName,Description
			//dynamic a = new {CategoryName = "Meyveler" ,Description = "Elma,Armut"};
			//var b =  new {CategoryName = "Meyveler" ,Description = "Elma,Armut"};
			//bject c = new {CategoryName = "Meyveler" ,Description = "Elma,Armut"};
		}
	}
}
