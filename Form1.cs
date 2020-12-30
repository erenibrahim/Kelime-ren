using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeOgren
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public void RefreshDatagrid()
        {
            dataGridView1.DataSource = null;
            ds.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        public Form1()
        {
            InitializeComponent();
            RefreshDatagrid();
        }
        string sorgu = "select " + '"' + "TrIng" + '"' + "." + '"' + "trIngId" + '"' + " AS " +'"' + "ID" + '"' +", "+ '"'+"WordsIng"+ '"'+"."+ '"'+"word"+ '"'+ " AS "+ '"'+"İNGİLİZCE"+ '"'+", "+ '"'+"WordsTr"+ '"'+"."+ '"'+"word"+ '"'+ " AS "+ '"'+ "TÜRKÇE"+ '"'+ " from "+ '"'+ "TrIng"+ '"'+ " join "+ '"'+ "WordsIng"+ '"'+ " on "+ '"'+ "TrIng"+ '"'+"."+ '"'+"wordsIngId"+ '"'+ "="+ '"'+ "WordsIng"+ '"'+"."+ '"'+"wordsIngId"+ '"'+ " join "+ '"'+ "WordsTr"+ '"'+" on "+ '"'+ "TrIng"+ '"'+"."+ '"'+"wordsTrId"+ '"'+ "="+ '"'+ "WordsTr"+ '"'+"."+ '"'+"wordsTrId"+ '"';

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; Database=Proje; user Id=postgres; password=196196");
        private void button_ekle_Click(object sender, EventArgs e)
        {
            string tr = textBox_tr.Text;
            string ing = textBox_ing.Text;

            string komutstr1 = "select " + '"' + "kelimeEkle" + '"'+ "('"+ing+"','"+tr+"');";
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(komutstr1,baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            RefreshDatagrid();
        }

        private void button_sil_Click(object sender, EventArgs e)
        {
            string ing = textBox_ing.Text;

            string komutstr1 = "select " + '"' + "kelimeSil" + '"' + "('" + ing +  "');";
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(komutstr1, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            RefreshDatagrid();
        }

        private void button_degistir_Click(object sender, EventArgs e)
        {
            string w1 = textBox_d1.Text;
            string w2 = textBox_d2.Text;

            string komutstr1 = "update " + '"' + "WordsIng" + '"'+"SET word =" + "'" + w2 + "' WHERE word='" + w1 + "';";
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(komutstr1, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            RefreshDatagrid();
        }

        private void button_ara_Click(object sender, EventArgs e)
        {
            string aranan = textBox_ara.Text;
            dataGridView1.DataSource = null;
            ds.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string ara = "select " + '"' + "TrIng" + '"' + "." + '"' + "trIngId" + '"' + " AS " + '"' + "ID" + '"' + ", "+ '"' + "WordsIng" + '"' + "." + '"' + "word" + '"' + " AS " + '"' + "İNGİLİZCE" + '"' + ", " + '"' + "WordsTr" + '"' + "." + '"' + "word" + '"' + " AS " + '"' + "TÜRKÇE" + '"' + " from " + '"' + "TrIng" + '"' + " join " + '"' + "WordsIng" + '"' + " on " + '"' + "TrIng" + '"' + "." + '"' + "wordsIngId" + '"' + "=" + '"' + "WordsIng" + '"' + "." + '"' + "wordsIngId" + '"' + " join " + '"' + "WordsTr" + '"' + " on " + '"' + "TrIng" + '"' + "." + '"' + "wordsTrId" + '"' + "=" + '"' + "WordsTr" + '"' + "." + '"' + "wordsTrId" + '"'+ " WHERE " + '"' + "TrIng" + '"' +"."+ '"' + "wordsIngId" + '"' + " = (SELECT " + '"' + "wordsIngId" + '"' + " FROM " + '"' + "WordsIng" + '"' + " WHERE word = " +"'"+ aranan+"'" +")";

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(ara, baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_add_known_Click(object sender, EventArgs e)
        {
            string w1 = textBox_known.Text;

            string komutstr1 = "INSERT INTO " + '"' + "Known" + '"' + " (" + '"' + "userId" + '"' + "," + '"' + "trIngId" + '"' + ") VALUES((SELECT " + '"' + "currentUserId" + '"' + " FROM " + '"' + "CurrentUser" + '"' + "), ( SELECT " + '"' + "trIngId" + '"' + " FROM " + '"' + "TrIng" + '"' + " WHERE " + '"' + "wordsIngId" + '"' + " = (SELECT " + '"' + "wordsIngId" + '"' + " FROM " + '"' + "WordsIng" + '"' + " WHERE word = " + "'" + w1 + "')))";
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand(komutstr1, baglanti);
            komut1.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button_known_Click(object sender, EventArgs e)
        {
        
            dataGridView1.DataSource = null;
            ds.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string bilinenler = "select " + '"' + "Known" + '"' + "." + '"' + "trIngId" + '"' + " AS " + '"' + "ID" + '"' + ", " + '"' + "WordsIng" + '"' + "." + '"' + "word" + '"' + " AS " + '"' + "İNGİLİZCE" + '"' + ", " + '"' + "WordsTr" + '"' + "." + '"' + "word" + '"' + " AS " + '"' + "TÜRKÇE" + '"' + " from " + '"' + "Known" + '"' + " join " + '"' + "TrIng" + '"' + " on " + '"' + "Known" + '"' + "." + '"' + "trIngId" + '"' + "=" + '"' + "TrIng" + '"' + "." + '"' + "trIngId" + '"' + " join " + '"' + "WordsIng" + '"' + " on " + '"' + "TrIng" + '"' + "." + '"' + "wordsIngId" + '"' + "=" + '"' + "WordsIng" + '"' + "." + '"' + "wordsIngId" + '"' + " join " + '"' + "WordsTr" + '"' + " on " + '"' + "TrIng" + '"' + "." + '"' + "wordsTrId" + '"' + "=" + '"' + "WordsTr" + '"' + "." + '"' + "wordsTrId" + '"';

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(bilinenler, baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button_all_Click(object sender, EventArgs e)
        {
            RefreshDatagrid();
        }

        private void button_totalLearned_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            ds.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string totalLearn = "select * FROM" + '"' + "TotalLearn" + '"';

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(totalLearn, baglanti);
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
