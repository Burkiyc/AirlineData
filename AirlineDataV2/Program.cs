using AirlineDataV2.DbModels;
using AirlineDataV2.Forms;
using DevExpress.XtraSplashScreen;
using Microsoft.EntityFrameworkCore;

namespace AirlineDataV2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            //SplashScreenManager.ShowForm(typeof(DXWinSplashScreenForm1));
            //Thread.Sleep(800); 
            using (var context = new AirlineDbContext())
            {
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                //    var ucak1 = new Ucak() { KuyrukNo = "TC-ABC", Model = "Boeing 737", AlimYili = "2015", UcusSaati = 5000, SimdikiMeydan = "LTBS" };
                //    var personel1 = new Personel()
                //    {
                //        AdSoyad = "Ahmet Yılmaz",
                //        UzmanlikAlani = "Mekanik",
                //        IseGirisTarihi = "2020-01-01",
                //        AtananMeydan = "IST"
                //    };
                //    var bakimKaydi1 = new BakimKaydi()
                //    {
                //        Ucak = ucak1,
                //        Personeller = new List<Personel> { personel1 },
                //        BakimTarihi = DateTime.Now
                //    };
                //    context.Ucaklar.Add(ucak1);
                //    context.Personeller.Add(personel1);
                //    context.BakimKayitlari.Add(bakimKaydi1);
                //    context.SaveChanges();



            }

            //SplashScreenManager.CloseForm();
            Application.Run(new AnaForm());

        }
    }
}