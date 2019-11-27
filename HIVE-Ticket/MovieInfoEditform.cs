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
    private MySqlDataAdapter adapterDist;
    private DataSet dataSet;
    private DataSet dataSetDist;

    private void MovieInfoEditform_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=hive_ticket;uid=hive;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      adapterDist = new MySqlDataAdapter();
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

          adapterDist.SelectCommand = new MySqlCommand(sql, conn);
          if (adapterDist.Fill(dataSetDist) > 0)
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

    private void buttonInsert1_Click(object sender, EventArgs e)
    {
      string sql = "INSERT INTO movies (distid, title, summary, director, best_actor) VALUES (@distid, @title, @summary, @director, @best_actor)";
      
      adapter.InsertCommand = new MySqlCommand(sql, conn);
      adapter.InsertCommand.Parameters.AddWithValue("@distid", int.Parse(textBoxMovieDistID.Text));
      adapter.InsertCommand.Parameters.AddWithValue("@title", textBoxMovieTitle.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@summary", textBoxMovieDesc.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@director", textBoxMovieDirector.Text);
      adapter.InsertCommand.Parameters.AddWithValue("@best_actor", textBoxMovieActor.Text);

      try
      {
        if (conn.State != ConnectionState.Open)
        {
          conn.Open();
        }
        if (adapter.InsertCommand.ExecuteNonQuery() > 0)
        {
          dataSet.Clear();
          adapter.Fill(dataSet, "Table");
          dataGridViewMovie.DataSource = dataSet.Tables["Table"].DefaultView.ToTable(true);
          MessageBox.Show("추가 완료.");
          textBoxMovieActor.Text = "";
          textBoxMovieDesc.Text = "";
          textBoxMovieDirector.Text = "";
          textBoxMovieTitle.Text = "";
          textBoxMovieDistID.Text = "";
        }
        else
        {
          MessageBox.Show("추가된 데이터가 없습니다.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void buttonInsert_Click(object sender, EventArgs e)
    {
      string sql = "INSERT INTO distributors (name, parent, size) VALUES (@name, @parent, @size)";
      adapterDist.InsertCommand = new MySqlCommand(sql, conn);
      adapterDist.InsertCommand.Parameters.AddWithValue("@name", textBoxDistName.Text);
      adapterDist.InsertCommand.Parameters.AddWithValue("@parent", textBoxDistMother.Text);

      int size = 0;
      
      if (radioButton1.Checked)
      {
        size = 3;
      }
      if (radioButton2.Checked)
      {
        size = 2;
      }
      if (radioButton3.Checked)
      {
        size = 1;
      }
      adapterDist.InsertCommand.Parameters.AddWithValue("@size", size);
      
      try
      {
        if (conn.State != ConnectionState.Open)
        {
          conn.Open();
        }
        if (adapterDist.InsertCommand.ExecuteNonQuery() > 0)
        {
          dataSetDist.Clear();
          adapterDist.Fill(dataSetDist, "Table");
          dataGridViewDist.DataSource = dataSetDist.Tables["Table"].DefaultView.ToTable(true);
          MessageBox.Show("추가 완료.");
          textBoxDistName.Text = "";
          textBoxDistMother.Text = "";
        }
        else
        {
          MessageBox.Show("추가된 데이터가 없습니다.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void buttonEdit1_Click(object sender, EventArgs e)
    {
      var sql = "UPDATE movies SET distid = @distid, title = @title, summary = @summary, director = @director, best_actor = @actor WHERE movieid = @movieid";
      
      adapter.UpdateCommand = new MySqlCommand(sql, conn);
      adapter.UpdateCommand.Parameters.AddWithValue("@distid", int.Parse(textBoxMovieDistID.Text));
      adapter.UpdateCommand.Parameters.AddWithValue("@title", textBoxMovieTitle.Text);
      adapter.UpdateCommand.Parameters.AddWithValue("@summary", textBoxMovieDesc.Text);
      adapter.UpdateCommand.Parameters.AddWithValue("@director", textBoxMovieDirector.Text);
      adapter.UpdateCommand.Parameters.AddWithValue("@actor", textBoxMovieActor.Text);
      
      int id = (int) dataGridViewMovie.SelectedRows[0].Cells["movieid"].Value;
      adapter.UpdateCommand.Parameters.AddWithValue("@movieid", id);
      string filter = "movieid=" + id;
      DataRow[] findRows = dataSet.Tables["Table"].Select(filter);
      findRows[0]["distid"] = int.Parse(textBoxMovieDistID.Text);
      findRows[0]["title"] = textBoxMovieTitle.Text;
      findRows[0]["summary"] = textBoxMovieDesc.Text;
      findRows[0]["director"] = textBoxMovieDirector.Text;
      findRows[0]["best_actor"] = textBoxMovieActor.Text;

      try
      {
        adapter.Update(dataSet, "Table");
        MessageBox.Show("수정 완료.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      const string sql = "UPDATE distributors SET name = @name, parent = @parent, size = @size WHERE distid = @distid";
      
      adapterDist.UpdateCommand = new MySqlCommand(sql, conn);
      adapterDist.UpdateCommand.Parameters.AddWithValue("@name", textBoxDistName.Text);
      adapterDist.UpdateCommand.Parameters.AddWithValue("@parent", textBoxDistMother.Text);
      
      var id = (int) dataGridViewDist.SelectedRows[0].Cells["distid"].Value;
      adapterDist.UpdateCommand.Parameters.AddWithValue("@distid", id);
      string filter = "distid=" + id;
      var findRows = dataSetDist.Tables["Table"].Select(filter);
      findRows[0]["name"] = textBoxDistName.Text;
      findRows[0]["parent"] = textBoxDistMother.Text;
      if (radioButton1.Checked)
      {
        adapterDist.UpdateCommand.Parameters.AddWithValue("@size", 3);
        findRows[0]["size"] = 3;
      }
      if (radioButton2.Checked)
      {
        adapterDist.UpdateCommand.Parameters.AddWithValue("@size", 2);
        findRows[0]["size"] = 2;
      }
      if (radioButton3.Checked)
      {
        adapterDist.UpdateCommand.Parameters.AddWithValue("@size", 1);
        findRows[0]["size"] = 1;
      }

      try
      {
        adapterDist.Update(dataSetDist, "Table");
        MessageBox.Show("수정 완료.");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dataGridViewMovie_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      textBoxMovieTitle.Text = dataGridViewMovie.Rows[e.RowIndex].Cells["title"].Value as String;
      textBoxMovieDesc.Text = dataGridViewMovie.Rows[e.RowIndex].Cells["summary"].Value as String;
      textBoxMovieDirector.Text = dataGridViewMovie.Rows[e.RowIndex].Cells["director"].Value as String;
      textBoxMovieActor.Text = dataGridViewMovie.Rows[e.RowIndex].Cells["best_actor"].Value as String;
      textBoxMovieDistID.Text = dataGridViewMovie.Rows[e.RowIndex].Cells["distid"].Value.ToString();
    }

    private void dataGridViewDist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      textBoxDistName.Text = dataGridViewDist.Rows[e.RowIndex].Cells["name"].Value as String;
      textBoxDistMother.Text = dataGridViewDist.Rows[e.RowIndex].Cells["parent"].Value as String;
      switch (dataGridViewDist.Rows[e.RowIndex].Cells["size"].Value.ToString())
      {
        case "1":
          radioButton3.Checked = true;
          break;
        case "2":
          radioButton2.Checked = true;
          break;
        case "3":
          radioButton1.Checked = true;
          break;
      }
    }
    private void buttonDelete1_Click(object sender, EventArgs e)
    {
      string sql = "DELETE FROM movies WHERE movieid=@id";
      adapter.DeleteCommand = new MySqlCommand(sql, conn);
      int id = (int) dataGridViewMovie.SelectedRows[0].Cells["movieid"].Value;
      adapter.DeleteCommand.Parameters.AddWithValue("@id", id);
      
      
      try
      {
        if (conn.State != ConnectionState.Open)
        {
          conn.Open();
        }
        if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
        {
          dataSet.Clear();
          adapter.Fill(dataSet, "Title");
          dataGridViewMovie.DataSource = dataSet.Tables["Title"];
        }
        else
        {
          MessageBox.Show("삭제된 데이터가 없습니다.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}