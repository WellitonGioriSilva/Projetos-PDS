using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPDS.RegrasDeNegocio;
using MySql.Data.MySqlClient;

namespace ProjetoPDS.Formularios
{
    public partial class CadastrarContato : Form
    {
        private MySqlConnection _conexao;

        public CadastrarContato()
        {
            InitializeComponent();
            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_db;user=root;password=root;port=3360;";
            
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                dtpNascimento.Format = DateTimePickerFormat.Custom;
                dtpNascimento.CustomFormat = "yyyy-MM-dd";

                var nome = tbNome.Text;
                var sexo = tbSexo.Text;
                var email = tbEmail.Text;
                var telefone = tbTelefone.Text;
                var dataNascimento = dtpNascimento.Text;

                if (nome != "" && sexo != "" && email != "" && telefone != "" && dataNascimento != "")
                {
                    var sql = $"INSERT INTO contato (nome_con, data_nasc_con, sexo_con, email_con, telefone_con) VALUES (@_nome, @_dataNascimento, @_sexo, @_email, @_telefone)";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_dataNascimento", dataNascimento);
                    comando.ExecuteNonQuery();

                    limparEpacos();

                    MessageBox.Show("Contato salvo com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Todos os campos devem estar preenchidos. (CAD 11)");
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Ocorreram erros ao salvar as informações! Contate a equipe de suporte do sistema. (CAD 10)");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            limparEpacos();
        }

        public void limparEpacos()
        {
            tbNome.Clear();
            tbSexo.Clear();
            tbTelefone.Clear();
            tbEmail.Clear();
        }
    }
}
