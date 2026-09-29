#nullable disable
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace bilet_satis_kenan_aliyev_5094a1
{
    public partial class Form1 : Form
    {
        ComboBox cbFrom, cbTo;
        MaskedTextBox mtTarix, mtTel;
        TextBox tbYer, tbAd, tbFin, tbMail;
        Button btnPlan, btnSil, btnCix;

        List<string> biletler = new List<string>();
        string[] saatlar = { "07:00", "09:00", "11:00", "13:00", "15:00", "17:00", "19:00", "21:00" };
        CultureInfo inv = CultureInfo.InvariantCulture;

        public Form1()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        // ---- kontrolları adına görə yox, növünə və yerinə görə tapırıq ----
        static IEnumerable<T> Tap<T>(Control p) where T : Control
        {
            foreach (Control c in p.Controls)
            {
                if (c is T) yield return (T)c;
                foreach (T x in Tap<T>(c)) yield return x;
            }
        }
        static int X(Control c) { int v = 0; for (; c != null && !(c is Form); c = c.Parent) v += c.Left; return v; }
        static int Y(Control c) { int v = 0; for (; c != null && !(c is Form); c = c.Parent) v += c.Top; return v; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var combolar = Tap<ComboBox>(this).OrderBy(Y).ToList();
            cbFrom = combolar[0]; cbTo = combolar[1];

            var maskeli = Tap<MaskedTextBox>(this).OrderBy(X).ToList();
            mtTarix = maskeli[0]; mtTel = maskeli[1];

            int orta = ClientSize.Width / 2;
            var yazilar = Tap<TextBox>(this).ToList();
            tbYer = yazilar.First(t => X(t) < orta);
            var sag = yazilar.Where(t => X(t) >= orta).OrderBy(Y).ToList();
            tbAd = sag[0]; tbFin = sag[1]; tbMail = sag[2];

            var duymeler = Tap<Button>(this).ToList();
            btnPlan = duymeler.First(b => b.Text.Contains("planla"));
            btnSil = duymeler.First(b => b.Text.Contains("sil"));
            btnCix = duymeler.First(b => b.Text.Contains("çıx"));

            string[] seherler = { "Bakı", "Sumqayıt", "Gəncə", "Lənkəran", "Şəki", "Mingəçevir", "Naxçıvan" };
            cbFrom.Items.AddRange(seherler); cbTo.Items.AddRange(seherler);
            cbFrom.DropDownStyle = cbTo.DropDownStyle = ComboBoxStyle.DropDownList;

            mtTarix.Mask = @"00\.00\.0000 00:00";
            mtTel.Mask = @"(\+994) 00-000-00-00";
            tbFin.MaxLength = 7;                       // FİN max 7 simvol
            tbFin.CharacterCasing = CharacterCasing.Upper;
            tbYer.MaxLength = 2;
            tbYer.KeyPress += (s, a) => a.Handled = !char.IsControl(a.KeyChar) && !char.IsDigit(a.KeyChar);

            cbFrom.SelectedIndexChanged += (s, a) => Yenile();
            cbTo.SelectedIndexChanged += (s, a) => Yenile();
            mtTarix.TextChanged += (s, a) => Yenile();
            btnPlan.Click += Planla;
            btnSil.Click += Sil;
            btnCix.Click += (s, a) => Close();

            listBoxBiletler.HorizontalScrollbar = true;
            Yenile();
        }

        // Çıxış sorğusu
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing &&
                MessageBox.Show("Proqramdan çıxmaq istəyirsiniz?", "Çıxış",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        // Seçilən gün üçün qalan reys saatları
        List<string> Saatlar(DateTime gun)
        {
            if (gun.Date < DateTime.Today) return new List<string>();
            if (gun.Date > DateTime.Today) return saatlar.ToList();
            return saatlar.Where(t => TimeSpan.Parse(t) > DateTime.Now.TimeOfDay).ToList();
        }

        // listBoxBiletler: 1-ci sətir saatlar, sonra biletlər
        void Yenile()
        {
            listBoxBiletler.Items.Clear();
            string s = "Saatları görmək üçün Haradan, Haraya və Tarix seçin";

            if (cbFrom.SelectedIndex >= 0 && cbTo.SelectedIndex >= 0)
            {
                if (cbFrom.Text == cbTo.Text) s = "Haradan və Haraya eyni ola bilməz!";
                else
                {
                    DateTime g;
                    string gunStr = mtTarix.Text.Length >= 10 ? mtTarix.Text.Substring(0, 10) : "";
                    if (!DateTime.TryParseExact(gunStr, "dd.MM.yyyy", inv, DateTimeStyles.None, out g))
                        g = DateTime.Today;

                    var q = Saatlar(g);
                    s = q.Count == 0 ? "Bu tarix üçün reys yoxdur"
                        : "Reys saatları: " + string.Join("  ", q) + "   |   Növbəti avtobus: " + q[0];
                }
            }
            listBoxBiletler.Items.Add(s);
            listBoxBiletler.Items.AddRange(biletler.ToArray());
        }

        void Planla(object sender, EventArgs e)
        {
            DateTime t;
            if (cbFrom.SelectedIndex < 0 || cbTo.SelectedIndex < 0 || cbFrom.Text == cbTo.Text)
            { Xeta("Haradan və Haraya düzgün seçin!"); return; }

            if (!DateTime.TryParseExact(mtTarix.Text, "dd.MM.yyyy HH:mm", inv, DateTimeStyles.None, out t) || t <= DateTime.Now)
            { Xeta("Tarix və saatı düzgün yazın (keçmiş ola bilməz)!"); return; }

            if (!saatlar.Contains(t.ToString("HH:mm", inv)))
            { Xeta("Bu saatda reys yoxdur!\nReys saatları: " + string.Join(", ", saatlar)); return; }

            int yer;
            if (!int.TryParse(tbYer.Text, out yer) || yer < 1 || yer > 45)
            { Xeta("Yer nömrəsi 1-45 arası olmalıdır!"); return; }

            string ad = tbAd.Text.Trim(), fin = tbFin.Text.Trim(), mail = tbMail.Text.Trim();
            if (!ad.Contains(" ")) { Xeta("Ad və soyadı tam yazın!"); return; }
            if (fin.Length != 7) { Xeta("FİN 7 simvol olmalıdır!"); return; }
            if (!mtTel.MaskCompleted) { Xeta("Telefonu tam yazın!"); return; }
            if (!mail.Contains("@") || !mail.Contains(".")) { Xeta("E-Mail düzgün deyil!"); return; }

            string acar = $"{t:dd.MM.yyyy HH:mm} | {cbFrom.Text} → {cbTo.Text} | Yer {yer} |";
            if (biletler.Any(b => b.StartsWith(acar))) { Xeta("Bu yer artıq tutulub!"); return; }

            biletler.Add($"{acar} {ad} | FİN: {fin} | {mtTel.Text} | {mail}");
            Yenile();

            tbAd.Clear(); tbFin.Clear(); mtTel.Clear(); tbMail.Clear(); tbYer.Clear();
        }

        void Sil(object sender, EventArgs e)
        {
            int i = listBoxBiletler.SelectedIndex;
            if (i < 1) { Xeta("Silmək üçün siyahıdan bilet seçin!"); return; }
            biletler.RemoveAt(i - 1);
            Yenile();
        }

        // Dizayn faylının tələb etdiyi boş metodlar (silmə!)
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }

        void Xeta(string mesaj) { MessageBox.Show(mesaj); }
    }
}
