using System;
using System.Collections.Generic;
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

    private void buttonSearch1_Click(object sender, EventArgs e)
    {
      var sql = "SELECT * FROM movies";

      List<string> conditions = new List<string>();
      if (!String.IsNullOrWhiteSpace(textBoxMovieDistID.Text))
      {
        conditions.Add("distid=" + textBoxMovieDistID.Text);
      }
      
      if (!String.IsNullOrWhiteSpace(textBoxMovieTitle.Text))
      {
        conditions.Add("title=\"" + textBoxMovieTitle.Text + "\"");
      }

      if (!String.IsNullOrWhiteSpace(textBoxMovieDesc.Text))
      {
        conditions.Add("summary=\"" + textBoxMovieDesc.Text + "\"");
      }

      if (!String.IsNullOrWhiteSpace(textBoxMovieDirector.Text))
      {
        conditions.Add("director=\"" + textBoxMovieDirector.Text + "\"");
      }
      
      if (!String.IsNullOrWhiteSpace(textBoxMovieActor.Text))
      {
        conditions.Add("best_actor=\"" + textBoxMovieActor.Text + "\"");
      }

      var condition = (conditions.ToArray().Length > 0 ? " WHERE " : "") + String.Join(" AND ", conditions.ToArray());

      adapter.SelectCommand = new MySqlCommand(sql + condition, conn);
      if (adapter.Fill(dataSet) > 0)
      {
        dataSet.Clear();
        adapter.Fill(dataSet);
        dataGridViewMovie.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
      }
      else
      {
        MessageBox.Show("검색된 데이터가 없습니다.");
      }
    }

    private void buttonSearch2_Click(object sender, EventArgs e)
    {
      var sql = "SELECT * FROM distributors";

      List<string> conditions = new List<string>();
      if (!String.IsNullOrWhiteSpace(textBoxDistName.Text))
      {
        conditions.Add("name=" + textBoxDistName.Text);
      }
      
      if (!String.IsNullOrWhiteSpace(textBoxDistMother.Text))
      {
        conditions.Add("parent=\"" + textBoxDistMother.Text + "\"");
      }

      if (radioButton1.Checked)
      {
        conditions.Add("size=3");
      }
      if (radioButton2.Checked)
      {
        conditions.Add("size=2");
      }
      if (radioButton3.Checked)
      {
        conditions.Add("size=1");
      }

      var condition = (conditions.ToArray().Length > 0 ? " WHERE " : "") + String.Join(" AND ", conditions.ToArray());

      adapter.SelectCommand = new MySqlCommand(sql + condition, conn);
      if (adapter.Fill(dataSetDist) > 0)
      {
        dataSetDist.Clear();
        adapter.Fill(dataSetDist);
        dataGridViewDist.DataSource = dataSetDist.Tables["Table"].DefaultView.ToTable(true);
      }
      else
      {
        MessageBox.Show("검색된 데이터가 없습니다.");
      }
    }
  }
}