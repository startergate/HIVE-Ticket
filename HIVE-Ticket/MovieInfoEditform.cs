using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HIVE_Ticket
{
  public partial class MovieInfoEditform : Form
  {
    public MovieInfoEditform()
    {
      InitializeComponent();
    }

    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;
    private DataSet dataSetDist;

    private void MovieInfoEditform_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=hive_ticket;uid=hive;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet();
      dataSetDist = new DataSet();

      try
      {
        conn.Open();
        if (conn.State == ConnectionState.Open)
        {
          var sql = "SELECT * FROM movies";

          adapter.SelectCommand = new MySqlCommand(sql, conn);
          if (adapter.Fill(dataSet) > 0)
          {
            dataGridViewMovie.DataSource = dataSet.Tables["Table"];
          }
          else
          {
            MessageBox.Show("검색된 데이터가 없습니다.");
          }
          
          sql = "SELECT * FROM distributors";

          adapter.SelectCommand = new MySqlCommand(sql, conn);
          if (adapter.Fill(dataSetDist) > 0)
          {
            dataGridViewDist.DataSource = dataSetDist.Tables["Table"];
          }
          else
          {
            MessageBox.Show("검색된 데이터가 없습니다.");
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }
  }
}