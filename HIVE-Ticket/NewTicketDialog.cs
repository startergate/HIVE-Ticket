using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HIVE_Ticket
{
  public partial class NewTicketDialog : Form
  {

    private MySqlConnection conn;
    private MySqlDataAdapter adapter;
    private DataSet dataSet;

    private bool isUpdate;
    private int ticketid = -1;
    
    public NewTicketDialog()
    {
      InitializeComponent();
    }
    
    public NewTicketDialog(int ticketid, int userid, int movieid, DateTime time)
    {
      InitializeComponent();

      this.ticketid = ticketid;
      textBox3.Text = userid.ToString();
      textBox1.Text = movieid.ToString();
      textBox2.Text = time.ToString("yyyy-MM-dd HH:mm");
    }

    private void NewTicketDialog_Load(object sender, EventArgs e)
    {
      string connStr = "server=db.donote.co;port=3306;database=hive_ticket;uid=hive;pwd=1111";
      conn = new MySqlConnection(connStr);
      adapter = new MySqlDataAdapter();
      dataSet = new DataSet(); 

      try
      {
        conn.Open();
        if (conn.State == ConnectionState.Open)
        {
          var sql = "SELECT movieid, title, summary, director, best_actor, name FROM movies_with_dist";

          adapter.SelectCommand = new MySqlCommand(sql, conn);
          if (adapter.Fill(dataSet) > 0)
          {
            dataGridView1.DataSource = dataSet.Tables["Table"];
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

    private void button1_Click(object sender, EventArgs e)
    {
      if (ticketid == -1)
      {
        var sql =
          "INSERT INTO tickets (userid, movieid, created_at, available_at) VALUES (@userid, @movieid, now(), @date)";
      
        adapter.InsertCommand = new MySqlCommand(sql, conn);
        try
        {
          if (conn.State != ConnectionState.Open)
          {
            conn.Open();
          }

          adapter.InsertCommand.Parameters.AddWithValue("@userid", int.Parse(textBox3.Text));
          adapter.InsertCommand.Parameters.AddWithValue("@movieid", int.Parse(textBox1.Text));
          adapter.InsertCommand.Parameters.AddWithValue("@date", textBox2.Text);
          if (adapter.InsertCommand.ExecuteNonQuery() > 0)
          {
            MessageBox.Show("데이터 추가가 완료되었습니다.");
            DialogResult = DialogResult.OK;
            this.Close();
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
      else
      {
        var sql = "UPDATE tickets SET userid = @userid, movieid = @movieid, available_at = @date WHERE ticketid = @ticketid";
        adapter.UpdateCommand = new MySqlCommand(sql, conn);

        adapter.UpdateCommand.Parameters.AddWithValue("@userid", int.Parse(textBox3.Text));
        adapter.UpdateCommand.Parameters.AddWithValue("@movieid", int.Parse(textBox1.Text));
        adapter.UpdateCommand.Parameters.AddWithValue("@date", textBox2.Text);
        adapter.UpdateCommand.Parameters.AddWithValue("@ticketid", ticketid);
        
        try
        {
          if (conn.State != ConnectionState.Open)
          {
            conn.Open();
          }
          
          if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
          {
            MessageBox.Show("데이터 수정이 완료되었습니다.");
            DialogResult = DialogResult.OK;
            this.Close();
          }
          else
          {
            MessageBox.Show("Yep.");
          }
        }
        catch (Exception exception)
        {
          Console.WriteLine(exception);
        }
      }
    }
  }
}