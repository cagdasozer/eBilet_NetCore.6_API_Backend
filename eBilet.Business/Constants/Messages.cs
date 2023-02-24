using eBilet.Core.Entities.Concrete;
using eBilet.Entities.Dtos.Buses;
using eBilet.Entities.Dtos.Customers;
using eBilet.Entities.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace eBilet.Business.Constants
{
	public static class Messages
	{
		public static string TicketAdded = "BİLET EKLENDİ.";
		public static string TicketDeleted = "BİLET SİLİNDİ.";
		public static string TicketNotFound = "BİLET BULUNAMADI.";
		public static string TicketUpdated = "BİLET GÜNCELLENDİ.";
		public static string TicketListed = "BİLETLER LİSTELENDİ.";
		public static string TicketGeted = "BİLET GETİRİLDİ";
		public static string FirstNameNotEmpty = "İSİM BOŞ OLAMAZ.";
		public static string LastNameNotEmpty = "SOYİSİM BOŞ OLAMAZ ";
		public static string FirstNameMaxLenght = "MAX UZUNLUK 30 KARAKTER. ";
		public static string LastNameMaxLenght = "MAX UZUNLUK 30 KARAKTER. ";
		public static string EmailNotEmpty = "E-MAİL BOŞ OLAMAZ ";
		public static string SeatNoNotEmpty = "KOLTUK NO BOŞ OLAMAZ ";
		public static string BusIdNotEmpty = "OTOBÜS NUMARASI BOŞ OLAMAZ ";
		public static string ToWhereNotEmpty = "NEREYE GİDECEKSİNİZ? ";
		public static string FromWhereNotEmpty = "NEREDEN GİDECEKSİNİZ? ";
		public static string PriceNotEmpty = "BİLET FİYATI BOŞ OLAMAZ";
		public static string AuthorizationDenied = "YETKİNİZ YOK";
		public static string UserRegistered = "KAYIT BAŞARILI";
		public static string UserNotFound = "KULLANICI BULUNAMADI";
		public static string PasswordError = "HATALI ŞİFRE";
		public static string SuccessfulLogin = "GİRİŞ BAŞARILI";
		public static string AccessTokenCreated = "TOKEN OLUŞTURULDU";
		public static string UserAlreadyExists = "E-MAİL ÜZERİNDE KAYITLI KULLANICI MEVCUT";
		public static string MailNotEmpty = "MAİL ZORUNLU";
		public static string EmailTooLong = "MAX UZUNLUK 50 KARAKTER OLMALI";
		public static string FirstNameTooLong = "MAX UZUNLUK 50 KARAKTER OLMALI";
		public static string LastNameTooLong = "MAX UZUNLUK 50 KARAKTER OLMALI";
		public static string TicketAlreadyInBus = "KOLTUK DOLU";
		public static string UserDeleted = "KULLANICI SİLİNDİ.";
		public static string UsersListed = "KULLANICILAR LİSTELENDİ.";
		public static string UserFound = "KULLANICI BULUNDU.";
		public static string CustomerUpdated = "MÜŞTERİ BİLGİLERİ GÜNCELLENDİ.";
		public static string CustomerNotFound = "MÜŞTERİ BULUNAMADI.";
		public static string CustomerDeleted = "MÜŞTERİ SİLİNDİ.";
		public static string CustomerAdded = "MÜŞTERİ EKLENDİ.";
		public static string AgeNotEmpty = "YAŞ BOŞ OLAMAZ.";
		public static string PhoneNotEmpty = "TELEFON NUMARASI BOŞ OLAMAZ.";
		public static string GenderNotEmpty = "CİNSİYET BOŞ OLAMAZ.";
		public static string CustomersListed = "MÜŞTERİLER LİSTELENDİ.";
		public static string CustomerFound = "MÜŞTERİ BULUNDU.";
		public static string BusNotFound = "OTOBÜS BULUNAMADI.";
		public static string BusGeted = "OTOBÜS GETİRİLDİ.";
		public static string BusesListed = "OTOBÜSLER LİSTELENDİ.";
		public static string BusDeleted = "OTOBÜS SİLİNDİ.";
		public static string BusAdded = "OTOBÜS EKLENDİ.";
		public static string PnrNoNotEmpty = "PNRNO BOŞ OLAMAZ.";
		public static string SeatCapacityNotEmpty = "OTOBÜS KAPASİTESİ BOŞ OLAMAZ.";
	}
}
