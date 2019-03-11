using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;

namespace ImportarDBF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string SelectedTable = string.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Selecione o arquivo";
            fdlg.InitialDirectory = @"c:\";
            fdlg.FileName = txtNomeArquivo.Text;
            fdlg.Filter = "DBF Files(*.dbf)|*.dbf|All Files(*.*)|*.*";
            fdlg.FilterIndex = 1;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                txtNomeArquivo.Text = fdlg.FileName;
                Importar();
                Application.DoEvents();
            }
        }

        private void Importar()
        {
            if (txtNomeArquivo.Text.Trim() != string.Empty)
            {
                try
                {
                    DataTable dt = GetDataTableDBF(txtNomeArquivo.Text);
                    gdvDados.DataSource = dt.DefaultView;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
        public static DataTable GetDataTableDBF(string strFileName)
        {
            OdbcConnection conn = new OdbcConnection("Driver={Microsoft Visual FoxPro Driver};SourceType=DBF;SourceDB=" + System.IO.Path.GetFullPath(strFileName).Replace(System.IO.Path.GetFileName(strFileName), "") + ";Exclusive=No");
            conn.Open();
            string strConsulta = "SELECT * FROM [" + Path.GetFileName(strFileName) + "]";
            OdbcDataAdapter adapter = new OdbcDataAdapter(strConsulta, conn);
            System.Data.DataSet ds = new System.Data.DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }
    }
}