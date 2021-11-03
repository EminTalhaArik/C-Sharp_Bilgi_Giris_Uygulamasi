using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiGirisUygulamasi
{
    public partial class frm_bilgiGirisUygulamasi : Form
    {
        public frm_bilgiGirisUygulamasi()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        Ogrenci selectedOgrenci = null;

        private void frm_bilgiGirisUygulamasi_Load(object sender, EventArgs e)
        {
            TemelBaslangic();
        }

        #region Kontroller
        private bool TcNoKontrol(string tcNo)
        {
            try
            {
                tcNo = Convert.ToInt64(tcNo).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Geçerli bir tc kimlik numarası giriniz..");
                return false;
            }

            if (tcNo.Length == 11)
            {
                if (Convert.ToInt64(tcNo) % 2 == 0)
                {
                    foreach (var item in ogrenciler)
                    {
                        if (tcNo == item.tcNo)
                        {
                            return false;
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool OgrenciKontrol(Ogrenci ogrenci)
        {
            if (ogrenci.ad != "" && ogrenci.soyad != "" && TcNoKontrol(ogrenci.tcNo) && ogrenci.sinif != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Veriler
        private void VeriEkle(Ogrenci ogrenci)
        {
            if (OgrenciKontrol(ogrenci))
            {
                ogrenciler.Add(ogrenci);
            }
            else
            {
                MessageBox.Show("Girdiğiniz veriler hatalıdır..");
            }
        }

        private void OgrenciBulTC(string tc)
        {
            foreach (var item in ogrenciler)
            {
                if (item.tcNo == tc)
                {
                    OgrenciSec(item);
                    tbx_tcNo.Text = item.tcNo;
                    tbx_ad.Text = item.ad;
                    tbx_soyad.Text = item.soyad;
                    cbx_sinif.Text = item.sinif;

                    return;
                }
            }
        }

        private void OgrenciBulIsim(string ad)
        {
            foreach (var item in ogrenciler)
            {
                if (ad == item.ad + " " + item.soyad || ad == item.ad)
                {
                    OgrenciSec(item);
                    tbx_tcNo.Text = item.tcNo;
                    tbx_ad.Text = item.ad;
                    tbx_soyad.Text = item.soyad;
                    cbx_sinif.Text = item.sinif;

                    return;
                }
            }
        }

        private void OgrenciSil()
        {
            if (selectedOgrenci != null)
            {
                int index = ListedenIndexBul();
                if (index != -5)
                    ogrenciler.RemoveAt(index);
                ListeleriYenile();
            }
        }

        private void OgrenciSec(Ogrenci ogrenci)
        {
            if (ogrenci != null)
                selectedOgrenci = ogrenci;
        }

        private void OgrenciGuncelle(Ogrenci yeniOgrenci)
        {
            if (selectedOgrenci != null)
            {
                int index = ListedenIndexBul();
                if (index != -5)
                {
                    ogrenciler.RemoveAt(index);
                    ogrenciler.Add(yeniOgrenci);
                }

                ListeleriYenile();
            }
        }

        private void ButonlariGuncelle(string durum)
        {
            if (durum == "true")
            {
                btn_sil.Enabled = true;
                btn_degistir.Enabled = true;
                tbx_tcNo.Enabled = false;
                btn_ekleVeGuncelle.Enabled = false;
            }
            else
            {
                btn_sil.Enabled = false;
                btn_degistir.Enabled = false;
                tbx_tcNo.Enabled = true;
                btn_ekleVeGuncelle.Enabled = true;
            }

        }

        #endregion

        #region Butonlar
        private void btn_sil_Click(object sender, EventArgs e)
        {
            OgrenciSil();
            ButonlariGuncelle("false");
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {

            OgrenciGuncelle(new Ogrenci(tbx_tcNo.Text, tbx_ad.Text, tbx_soyad.Text, cbx_sinif.Text));
            ButonlariGuncelle("false");
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            if (tbx_bul.Text.Trim() != "")
            {
                if (rbtn_adVeSoyad.CanSelect)
                {
                    OgrenciBulIsim(tbx_bul.Text);
                }

                if (rbtn_tcNo.CanSelect)
                {
                    OgrenciBulTC(tbx_bul.Text);
                }

                ButonlariGuncelle("true");
            }
        }

        private void btn_ekleVeGuncelle_Click(object sender, EventArgs e)
        {
            VeriEkle(new Ogrenci(tbx_tcNo.Text, tbx_ad.Text, tbx_soyad.Text, cbx_sinif.Text));
            ListeleriYenile();
        }

        #endregion

        #region TemelKodlar
        private void TemelBaslangic()
        {
            cbx_sinif.Items.Add("9. Sınıf");
            cbx_sinif.Items.Add("10. Sınıf");
            cbx_sinif.Items.Add("11. Sınıf");
            cbx_sinif.Items.Add("12. Sınıf");

            cbx_sinif.Text = "9. Sınıf";
        }
        private int ListedenIndexBul()
        {
            int index = 0;
            foreach (var item in ogrenciler)
            {
                if (item == selectedOgrenci)
                    return index;
                index++;
            }

            return -5;
        }
        private void ListeleriTemizle()
        {
            tbx_ad.Text = "";
            tbx_soyad.Text = "";
            tbx_tcNo.Text = "";
            cbx_sinif.Text = "9. Sınıf";
            lbx_tcNo.Items.Clear();
            lbx_adVeSoyad.Items.Clear();
            lbx_sinif.Items.Clear();
            selectedOgrenci = null;
        }
        private void ListeleriYenile()
        {
            ListeleriTemizle();
            foreach (var item in ogrenciler)
            {
                lbx_tcNo.Items.Add(item.tcNo);
                lbx_adVeSoyad.Items.Add(item.ad + " " + item.soyad);
                lbx_sinif.Items.Add(item.sinif);
            }

            lbl_studentCount.Text = "Öğrenci Sayısı : " + ogrenciler.Count;
        }
        #endregion
    }

    public class Ogrenci
    {
        public string tcNo;
        public string ad;
        public string soyad;
        public string sinif;

        public Ogrenci(string tcNo, string ad, string soyad, string sinif)
        {
            this.tcNo = tcNo;
            this.ad = ad;
            this.soyad = soyad;
            this.sinif = sinif;
        }
    }
}
