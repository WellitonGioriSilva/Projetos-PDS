using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Google.Protobuf.Reflection;

namespace ProjetoPDS.Formularios
{
    public partial class ListagemContato : Form
    {
        private MySqlConnection _conexao;
        private bool pesq;
        private string pesqDados;
        private string pesqTipoInf;

        public ListagemContato()
        {
            InitializeComponent();
            Conexao();
            Listar();
            pesqTipoInf = "nome_con";
            rbNome.Checked = true;
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_db;user=root;password=root;port=3360;";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void Listar()
        {
            string sql;
            sql = "SELECT * FROM contato;";

            if(pesq == true)
            {
                sql = $"SELECT * FROM contato WHERE {pesqTipoInf} LIKE '{pesqDados}%';";
            }

            var comando = new MySqlCommand(sql, _conexao);
            var da = new MySqlDataAdapter(comando);
            comando.ExecuteNonQuery();

            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            dataTable.Columns["id_con"].ColumnName = "ID";
            dataTable.Columns["nome_con"].ColumnName = "Nome";
            dataTable.Columns["data_nasc_con"].ColumnName = "Data de Nascimento";
            dataTable.Columns["sexo_con"].ColumnName = "Sexo";
            dataTable.Columns["email_con"].ColumnName = "Email";
            dataTable.Columns["telefone_con"].ColumnName = "Telefone";

            dgvLista.DataSource = dataTable;
            
        }

        private void tbPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesqDados = tbPesquisa.Text;

            if (tbPesquisa.Text != "")
            {
                pesq = true;
                Listar();
            }
            else
            {
                pesq = false;
                Listar();
            }
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            pesqTipoInf = "nome_con";
        }

        private void rbSexo_CheckedChanged(object sender, EventArgs e)
        {
            pesqTipoInf = "sexo_con";
        }
    }
}
