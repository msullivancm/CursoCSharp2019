using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaProtheus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /*
             cria colunas no DataGridView
             */
            dgProtheus.Columns.Add("Filial", "Filial");
            dgProtheus.Columns.Add("Entrada", "Data de Entrada");
            dgProtheus.Columns.Add("CFOP", "CFOP");
            dgProtheus.Columns.Add("NotaFiscal", "Nota Fiscal");
            dgProtheus.Columns.Add("Valor", "Valor da Nota");


            /*
              Recupera dados do servidor
             
             */
            string query = "select TOP 30 " +
                            " FT_FILIAL," +
                            " CAST(FT_ENTRADA AS DATE) AS DATA_ENTRADA," +
                            " FT_NFISCAL," +
                            " CAST(FT_VALCONT AS DECIMAL(12, 2)) AS VALOR," +
                            " FT_CFOP" +
                            " from SFT990" +
                            " WHERE" +
                            " D_E_L_E_T_ = ''" +
                            " AND FT_FILIAL = '01'" +
                            " AND FT_EMISSAO BETWEEN '20160101' AND '20160105'" +
                            " AND FT_DTCANC = ''";

            using (SqlConnection conecxao = Sessao.session)
            {
                SqlCommand comando = conecxao.CreateCommand();
                comando.CommandText = query;
                SqlDataReader leitor = comando.ExecuteReader();


                while (leitor.Read())
                {
                    string[] linha = new string[5];
                    linha[0] = Convert.ToString(leitor["FT_FILIAL"]);
                    linha[1] = Convert.ToString(leitor["DATA_ENTRADA"]);
                    linha[2] = Convert.ToString(leitor["FT_NFISCAL"]);
                    linha[3] = Convert.ToString(leitor["FT_CFOP"]);
                    linha[4] = Convert.ToString(leitor["VALOR"]);


                    dgProtheus.Rows.Add(linha);
                }

                /*Perfumaria*/

                //Estica a última coluna até o fim
                dgProtheus.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                //Estiliza um coluna
                DataGridViewCellStyle estilo = new DataGridViewCellStyle();
                estilo.Alignment = DataGridViewContentAlignment.MiddleCenter;
                estilo.BackColor = Color.Green;
                estilo.Font = new Font("Arial Balck", 10, FontStyle.Bold);
                estilo.ForeColor = Color.Wheat;

                dgProtheus.Columns["Filial"].DefaultCellStyle=estilo;


                //Bloqueia a grid para edição 
                dgProtheus.AllowUserToAddRows = false;
                dgProtheus.ScrollBars = ScrollBars.Vertical;
                dgProtheus.EditMode = DataGridViewEditMode.EditProgrammatically;
                
            }
          


        }
    }
}
