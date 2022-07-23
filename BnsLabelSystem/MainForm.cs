using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using ExcelDataReader;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using Z.Dapper.Plus;
using DevExpress.XtraReports.Configuration;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.Preview;
using System.Configuration;

namespace BnsLabelSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           
            checkEdit1.Enabled = false;
            checkEdit2.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }
        DataTableCollection tableCollection;
        string connectionstring = ConfigurationManager.ConnectionStrings["Connectionstring"].ConnectionString;


        private void button1_Click_1(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = ofd.FileName;
                        using (var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                        {
                            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollection = result.Tables;
                                comboBox1.Items.Clear();
                                foreach (DataTable table in tableCollection)
                                {
                                    comboBox1.Items.Add(table.TableName);
                                }

                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                WriteToFileError(ex.Message);
            }
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try {
                DataTable dt = tableCollection[comboBox1.SelectedItem.ToString()];

                if (dt != null)
                {
                    List<Products> products = new List<Products>();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        Products products1 = new Products();
                        products1.SeriesNumberofRow = dt.Rows[i]["SeriesNumberofRow"].ToString();
                        products1.Brand = dt.Rows[i]["Brand"].ToString();
                        products1.DocumentNumberInBns = dt.Rows[i]["DocumentNumberInBns"].ToString();
                        products1.Article = dt.Rows[i]["Article"].ToString();
                        products1.EAN = dt.Rows[i]["EAN"].ToString();
                        products1.ProductName = dt.Rows[i]["ProductName"].ToString();
                        products1.MainFabricComp = dt.Rows[i]["MainFabricComp"].ToString();
                        products1.LiningComp = dt.Rows[i]["LiningComp"].ToString();
                        products1.SoleComp = dt.Rows[i]["SoleComp"].ToString();
                        products1.ProductionDate = dt.Rows[i]["ProductionDate"];
                        products1.ServiceField1 = dt.Rows[i]["ServiceField1"].ToString();
                        products1.ServiceField2 = dt.Rows[i]["ServiceField2"].ToString();
                        products1.Origin = dt.Rows[i]["Origin"].ToString();
                        products1.Manufacturer = dt.Rows[i]["Manufacturer"].ToString();
                        products1.MansAdress = dt.Rows[i]["MansAdress"].ToString();
                        products1.EAC = dt.Rows[i]["EAC"].ToString();
                        products1.Conformity = dt.Rows[i]["Conformity"].ToString();
                        products1.DataMatrixCode = dt.Rows[i]["DataMatrixCode"].ToString();
                        products1.UniqueSerialNumber = dt.Rows[i]["UniqueSerialNumber"].ToString();
                        products1.ServiceField = dt.Rows[i]["ServiceField"].ToString();
                        products1.Dimension = dt.Rows[i]["Dimension"].ToString();
                        products1.Color = dt.Rows[i]["Color"].ToString();
                        products1.KutuNo = dt.Rows[i]["KutuNo"].ToString();
                        // products1.IsPrinted = dt.Rows[i]["IsPrinted"].ToString();
                        products.Add(products1);
                    }
                    productsBindingSource.DataSource = products;
                }
            }
            catch(Exception ex)
            {
                WriteToFileError(ex.Message);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                DapperPlusManager.Entity<Products>().Table("ztBNSLabel");
                List<Products> products = productsBindingSource.DataSource as List<Products>;
                if (products != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionstring))
                    {
                        db.BulkInsert(products);
                    }
                    MessageBox.Show("Aktarım basarılı!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Messeage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlCommand sql_cmnd = new SqlCommand("SELECT COUNT(EAN) FROM ztBNSLabel WHERE EAN=@EAN", connection);

                if (textEdit1.Text != null)
                {
                    sql_cmnd.Parameters.Add("@EAN", SqlDbType.NVarChar).Value = textEdit1.Text;
                }

                sql_cmnd.CommandType = CommandType.Text;

                int control = 0;

                int Success = (int)sql_cmnd.ExecuteScalar();

                connection.Close();
               
                if (Success > 0)
                {
                    if (textEdit1.Text != null)
                    {
                        control=ControlDataMatrixExistence(textEdit1.Text);
                        if (control == 1)
                        {

                            checkEdit1.Checked = true;
                            PrintDataMatrixDesing(textEdit1.Text);
                            textEdit1.EditValue = "";

                        }
                        else if (control == 0)
                        {

                            checkEdit2.Checked = true;
                            PrintStandartDesing(textEdit1.Text);
                            textEdit1.EditValue = "";
                           

                        }
                        else MessageBox.Show("Unexpected Erorr 'See Log Results'","ERROR!!!!"); textEdit1.Refresh();


                    }
                   
                }
                if (Success <= 0)
                {
                    MessageBox.Show("Eşleşme yok", "Hata");
                    textBox2.Text = textEdit1.Text + " " + "Eşleşme yok";
                }

            }
            catch (Exception ex)
            {
                WriteToFileError(ex.Message);
            }
        }
        public int ControlDataMatrixExistence(string Barcode)
        {
            try
            {

                SqlConnection cnn = new SqlConnection(connectionstring);

                cnn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Unknown=CASE WHEN DataMatrixCode='' THEN 0 ELSE 1 END  FROM ztBNSLabel WHERE EAN=@EAN", cnn);

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.Add("@EAN", System.Data.SqlDbType.VarChar, 50).Value = Barcode;

                SqlDataReader reader = cmd.ExecuteReader();

                int ReturnValue=-1;


                while (reader.Read())
                {
                    ReturnValue = (Int32)reader["Unknown"];

                    return ReturnValue;
                }

                cnn.Close();
            }
            catch (Exception ex)
            {
                WriteToFileError(ex.Message);
                return -1;
            }

            return -1;


        }
        private void PrintDataMatrixDesing(string Barcode)
        {
            try
            {
                Dm report = new Dm();
                if (GetDataFromTable(textBox1.Text)!=null)
                {
                    if (GetDataFromTable(textBox1.Text).Rows.Count > 0) 
                    {
                        report.DataSource = GetDataFromTable(textEdit1.Text);
                        ReportPrintTool printTool = new ReportPrintTool(report);
                        if (checkEdit4.Checked)
                        {
                            printTool.ShowRibbonPreview();
                        }
                        else
                        {
                            report.PrintingSystem.EndPrint += PrintingSystem_EndPrint;
                            printTool.Print();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu etiket daha önce basılmış", "HATA");
                    }

                }
                else
                {
                    MessageBox.Show("Bu etiket daha önce basılmış", "HATA");
                }
               
            }

            catch(Exception ex)
            {
                WriteToFileError(ex.Message);
            }
         






        }
        private void PrintStandartDesing(string Barcode)
        {
            try
            {
                NoDM report = new NoDM();
                report.DataSource = GetDataFromTable(textEdit1.Text);
                ReportPrintTool printTool = new ReportPrintTool(report);
                if (checkEdit4.Checked)
                {
                    printTool.ShowRibbonPreview();
                }
                else
                {
                    report.PrintingSystem.EndPrint += PrintingSystem_EndPrint;
                    printTool.Print();
                }
            }
            catch(Exception Ex)
            {
                WriteToFileError(Ex.Message);
            }
           

        }
        private DataTable GetDataFromTable(string Barcode)
        {
            try
            {
                string cmdText = "SELECT * FROM ztBNSLabel WHERE EAN=@EAN AND IsPrinted!=1";

                DataTable dataTable = new DataTable();

                SqlConnection sqlConnection = new SqlConnection(connectionstring);

                SqlConnection connection = sqlConnection;

                SqlCommand selectCommand = new SqlCommand(cmdText, connection);

                selectCommand.Parameters.Add("@EAN", SqlDbType.NVarChar).Value = Barcode;

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);

                sqlDataAdapter.Fill(dataTable);

                sqlConnection.Close();

                sqlDataAdapter.Dispose();

                return dataTable;

            }    
            catch (Exception Ex)
            {
                WriteToFileError(Ex.Message);
                return null;
            }
            

        }
        private void PrintingSystem_EndPrint(object sender, EventArgs e)
        {
            WriteToFile(GetDataFromTable(textEdit1.Text));
            IsPrintedControlMethod();
        }
        public void WriteToFile(DataTable dataTable)
        {
            if (dataTable.Rows.Count > 0)
            {
                try
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\PrintLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
                    if (!File.Exists(filepath))
                    {

                        // Create a file to write to.   
                        using (StreamWriter sw = File.CreateText(filepath))
                        {
                            int i = 0;
                            for (i = 0; i < dataTable.Columns.Count - 1; i++)
                            {

                                sw.Write(dataTable.Columns[i].ColumnName + ";");

                            }
                            sw.Write(dataTable.Columns[i].ColumnName);
                            sw.WriteLine("=>>>>" + DateTime.Now);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                object[] array = row.ItemArray;

                                for (i = 0; i < array.Length - 1; i++)
                                {
                                    sw.Write(array[i].ToString() + ";");
                                }
                                sw.Write(array[i].ToString());
                                sw.WriteLine("=>>>>" + DateTime.Now);

                            }
                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.AppendText(filepath))
                        {
                            int i = 0;
                            for (i = 0; i < dataTable.Columns.Count - 1; i++)
                            {

                                sw.Write(dataTable.Columns[i].ColumnName + ";");

                            }
                            sw.Write(dataTable.Columns[i].ColumnName);
                            sw.WriteLine("=>>>>" + DateTime.Now);

                            foreach (DataRow row in dataTable.Rows)
                            {
                                object[] array = row.ItemArray;

                                for (i = 0; i < array.Length - 1; i++)
                                {
                                    sw.Write(array[i].ToString() + ";");
                                }
                                sw.Write(array[i].ToString());
                                sw.WriteLine("=>>>>" + DateTime.Now);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteToFileError(ex.Message);
                }
            }
          
        }
        public void WriteToFileError(string Message)
        {
            try {
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\Errors";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\ErrorLog" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
                if (!File.Exists(filepath))
                {
                    // Create a file to write to.   
                    using (StreamWriter sw = File.CreateText(filepath))
                    {
                        sw.WriteLine(Message + " " + DateTime.Now);
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(filepath))
                    {
                        sw.WriteLine(Message + " " + DateTime.Now);
                    }
                }
            }
            catch(Exception ex)
            {
                WriteToFileError(ex.Message);
            }
            
        }
        private void IsPrintedControlMethod()
        {
            try
            {

                SqlConnection connection = new SqlConnection(connectionstring);

                connection.Open();

                SqlCommand sql_cmnd = new SqlCommand("Update ztBNSLabel Set IsPrinted=1 WHERE EAN=@EAN AND DataMatrixCode!='' ", connection);

                if (textEdit1.Text != null)
                {
                    sql_cmnd.Parameters.Add("@EAN", SqlDbType.NVarChar).Value = textEdit1.Text;
                }

                sql_cmnd.CommandType = CommandType.Text;

                sql_cmnd.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                WriteToFileError(ex.Message);
            }
        }
        private void PrintedLabel() { }
    }
}