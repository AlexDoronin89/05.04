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
using MySQLLesson2.Model;

namespace MySQLLesson2
{
    public partial class Form1 : Form
    {
        private string _connectionStr = "Server=localhost;User=root;Password=1234;Database=test_sql_lesson;";
        private MySqlConnection _connection;

        public Form1()
        {
            InitializeComponent();
            _connection = new MySqlConnection(_connectionStr);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeBookPage();
            InitializeReaderPage();
            InitializeSubscriptionPage();
        }

        private List<Book> GetBooks(string filtersString = "")
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;

            List<Book> books = new List<Book>();

            try
            {
                _connection.Open();

                command.CommandText = "SELECT b.id, b.title, b.author_id, b.pages_count, b.date, a.name AS `author` , bc.count " +
                    "FROM book b " +
                    "JOIN author a ON b.author_id = a.id " +
                    "JOIN book_count bc ON b.id = bc.book_id " + filtersString + ";";

                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        Id = reader.GetInt32("id"),
                        Title = reader.GetString("title"),
                        AuthorId = reader.GetInt32("author_id"),
                        AuthorName = reader.GetString("author"),
                        PageCount = reader.GetInt32("pages_count"),
                        Date = reader.IsDBNull(4) ? new DateTime() : reader.GetDateTime("date").Date,
                        Count = reader.GetInt32("count")
                    });
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                _connection.Close();
            }


            return books;
        }

        private List<Author> GetAuthors()
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;

            _connection.Open();

            command.CommandText = "SELECT * FROM author; ";

            MySqlDataReader reader = command.ExecuteReader();
            List<Author> authors = new List<Author>();

            while (reader.Read())
            {
                authors.Add(new Author
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                });
            }

            _connection.Close();

            return authors;
        }

        private List<Reader> GetReaders(string filtersString = "")
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT * FROM reader r " + filtersString + " ; ";

            _connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            List<Reader> readers = new List<Reader>();

            while (reader.Read())
            {
                readers.Add(new Reader
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Organization = reader.GetString("organization"),
                    Birthday = reader.GetDateTime("birthday").Date
                });
            }

            _connection.Close();

            return readers;
        }

        private List<Subscription> GetSubscriptions(string filtersString = "")
        {
            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;

            command.CommandText = "SELECT s.id, r.name AS `reader`, s.reader_id, b.title AS `book`, s.book_id, s.taking_date, s.bringing_date, s.is_return " +
                "FROM subscription s " +
                "JOIN reader r ON s.reader_id = r.id " +
                "JOIN book b ON s.book_id = b.id " + filtersString + " ; ";

            _connection.Open();

            MySqlDataReader reader = command.ExecuteReader();
            List<Subscription> subscriptions = new List<Subscription>();

            while (reader.Read())
            {
                subscriptions.Add(new Subscription
                {
                    Id = reader.GetInt32("id"),
                    ReaderId = reader.GetInt32("reader_id"),
                    ReaderName = reader.GetString("reader"),
                    BookId = reader.GetInt32("book_id"),
                    BookName = reader.GetString("book"),
                    TakingDate = reader.GetDateTime("taking_date").Date,
                    BringDate = reader.GetDateTime("bringing_date").Date,
                    IsReturn = reader.GetBoolean("is_return")
                });
            }

            _connection.Close();

            return subscriptions;
        }

        private void buttonBookNewAuthor_Click(object sender, EventArgs e)
        {
            comboBoxBookAuthor.DropDownStyle = ComboBoxStyle.DropDown;


        }

        public void InitializeBookPage()
        {
            RefreshBookData(GetBooks());
            RefreshComboBoxAuthor();
        }

        private void RefreshComboBoxAuthor()
        {
            comboBoxBookAuthor.DataSource = GetAuthors();
            comboBoxBookAuthor.SelectedIndex = -1;
        }

        private void RefreshBookData(List<Book> books)
        {
            dataGridViewBook.DataSource = books;

            dataGridViewBook.Columns["id"].Visible = false;
            dataGridViewBook.Columns["AuthorId"].Visible = false;
        }

        public void InitializeReaderPage()
        {
            RefreshReaderData(GetReaders());
        }

        private void RefreshReaderData(List<Reader> readers)
        {
            dataGridViewReader.DataSource = readers;

            dataGridViewReader.Columns["id"].Visible = false;
        }

        public void InitializeSubscriptionPage()
        {
            RefreshSubscriptionData(GetSubscriptions());

            comboBoxReaderSubscription.DataSource = GetReaders();
            comboBoxReaderSubscription.SelectedIndex = -1;
            comboBoxBookSubscription.DataSource = GetBooks();
            comboBoxBookSubscription.SelectedIndex = -1;
        }

        private void RefreshSubscriptionData(List<Subscription> subscriptions)
        {
            dataGridViewSubscription.DataSource = subscriptions;

            dataGridViewSubscription.Columns["id"].Visible = false;
            dataGridViewSubscription.Columns["ReaderId"].Visible = false;
            dataGridViewSubscription.Columns["BookId"].Visible = false;
        }


        private void buttonSelectBook_Click(object sender, EventArgs e)
        {
            string filtersString = string.Empty;
            List<string> filters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxBookTitle.Text) == false)
                filters.Add($"b.title LIKE '%{textBoxBookTitle.Text}%' ");

            if (numericUpDownPageCountBook.Value != 0)
                filters.Add($"b.pages_count = {numericUpDownPageCountBook.Value} ");

            if (numericUpDownBookCount.Value != 0)
                filters.Add($"bc.count = {numericUpDownBookCount.Value} ");

            if (comboBoxBookAuthor.SelectedItem != null)
                filters.Add($"a.id = {(comboBoxBookAuthor.SelectedItem as Author).Id} ");

            if (dateTimePickerBook.Value.Date != DateTime.Now.Date)
                filters.Add($"b.date = '{dateTimePickerBook.Value.ToString("yyyy-MM-dd")}' ");

            if (filters.Count > 0)
                filtersString = "WHERE " + string.Join(" AND ", filters);

            RefreshBookData(GetBooks(filtersString));
        }

        private void buttonFieldClearBook_Click(object sender, EventArgs e)
        {
            textBoxBookTitle.Text = string.Empty;
            comboBoxBookAuthor.SelectedIndex = -1;
            numericUpDownBookCount.Value = 0;
            numericUpDownPageCountBook.Value = 0;
            dateTimePickerBook.Value = DateTime.Now;
        }

        private void buttonFieldClearReader_Click(object sender, EventArgs e)
        {
            textBoxNameReader.Text = string.Empty;
            textBoxOrganizationReader.Text = string.Empty;
            dateTimePickerReader.Value = DateTime.Now;
        }

        private void buttonFieldClearSubscription_Click(object sender, EventArgs e)
        {
            comboBoxReaderSubscription.SelectedIndex = -1;
            comboBoxBookSubscription.SelectedIndex = -1;
            dateTimePickerTakeSubscription.Value = DateTime.Now;
            dateTimePickerBringSubscription.Value = DateTime.Now;
            checkBoxIsReturn.Checked = false;
        }

        private void buttonSelectReader_Click(object sender, EventArgs e)
        {
            string filtersString = string.Empty;
            List<string> filters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxNameReader.Text) == false)
                filters.Add($"r.name LIKE '%{textBoxNameReader.Text}%'");

            if (string.IsNullOrWhiteSpace(textBoxOrganizationReader.Text) == false)
                filters.Add($"r.organization LIKE '%{textBoxOrganizationReader.Text}%'");

            if (dateTimePickerBook.Value.Date != DateTime.Now.Date)
                filters.Add($"r.birthday = '{dateTimePickerBook.Value.ToString("yyyy-MM-dd")}'");

            if (filters.Count > 0)
                filtersString = "WHERE " + string.Join(" AND ", filters);

            RefreshReaderData(GetReaders(filtersString));
        }

        private void buttonSelectSubscription_Click(object sender, EventArgs e)
        {
            string filtersString = string.Empty;
            List<string> filters = new List<string>();

            if (comboBoxReaderSubscription.SelectedItem != null)
                filters.Add($"r.id = {(comboBoxReaderSubscription.SelectedItem as Reader).Id}");

            if (comboBoxBookSubscription.SelectedItem != null)
                filters.Add($"b.id = {(comboBoxBookSubscription.SelectedItem as Book).Id}");

            if (dateTimePickerTakeSubscription.Value.Date != DateTime.Now.Date)
                filters.Add($"s.taking_date = '{dateTimePickerTakeSubscription.Value.ToString("yyyy-MM-dd")}'");

            if (dateTimePickerBringSubscription.Value.Date != DateTime.Now.Date)
                filters.Add($"s.bringing_date = '{dateTimePickerBringSubscription.Value.ToString("yyyy-MM-dd")}'");

            if (checkBoxIsReturn.Checked != false)
                filters.Add($"s.is_return = {1}");

            if (filters.Count > 0)
                filtersString = "WHERE " + string.Join(" AND ", filters);

            RefreshSubscriptionData(GetSubscriptions(filtersString));
        }
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            _connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = string.Empty;

            string authorIdQuery = string.Empty;

            if (comboBoxBookAuthor.SelectedIndex != -1)
            {
                authorIdQuery = $"{(comboBoxBookAuthor.SelectedItem as Author).Id} ";
            }
            else if (comboBoxBookAuthor.DropDownStyle == ComboBoxStyle.DropDown && string.IsNullOrWhiteSpace(comboBoxBookAuthor.Text) == false)
            {
                command.CommandText += $"INSERT author (name) VALUE('{comboBoxBookAuthor.Text}'); ";
                authorIdQuery = $"(SELECT id FROM author WHERE name = '{comboBoxBookAuthor.Text}') ";
            }
            else
            {
                return;
            }

            command.CommandText += "INSERT book (title, author_id, pages_count, date) " +
                $"VALUES ('{textBoxBookTitle.Text}', {authorIdQuery}, " +
                $"{numericUpDownPageCountBook.Value}, '{dateTimePickerBook.Value.ToString("yyyy-MM-dd")}'); " +
                $"INSERT book_count (book_id, count) " +
                $"VALUES ((SELECT b.id FROM book b WHERE b.title = '{textBoxBookTitle.Text}'), {numericUpDownPageCountBook.Value}); ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }

            RefreshBookData(GetBooks());
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedCells.Count == 0)
                return;

            int rowIndex = dataGridViewBook.SelectedCells[0].RowIndex;
            Book book = dataGridViewBook.Rows[rowIndex].DataBoundItem as Book;

            List<string> setters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxBookTitle.Text) == false)
                setters.Add($"b.title = '{textBoxBookTitle.Text}'");

            if (comboBoxBookAuthor.SelectedIndex != -1)
                setters.Add($"b.author_id = {(comboBoxBookAuthor.SelectedItem as Author).Id}");

            if (numericUpDownPageCountBook.Value != book.PageCount)
                setters.Add($"b.pages_count = {numericUpDownPageCountBook.Value}");

            if (dateTimePickerBook.Value.ToString("yyyy-MM-dd") != book.Date.ToString("yyyy-MM-dd"))
                setters.Add($"b.date = '{dateTimePickerBook.Value.ToString("yyyy-MM-dd")}'");

            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;
            if (setters.Count > 0)
            {
                command.CommandText += "UPDATE book b " +
                    $"SET {string.Join(", ", setters)} " +
                    $"WHERE b.id = {book.Id}; ";
            }
            if (numericUpDownBookCount.Value != book.Count)
            {
                command.CommandText += $"UPDATE book_count bc  " +
                    $"SET bc.count = {numericUpDownBookCount.Value} " +
                    $"WHERE bc.book_id = {book.Id}; ";
            }
            _connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            _connection.Close();

            RefreshBookData(GetBooks());
        }

        private void buttonAddReader_Click(object sender, EventArgs e)
        {
            _connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = string.Empty;

            command.CommandText += "INSERT reader(name, birthday, organization) " +
                $"VALUES ('{textBoxNameReader.Text}', '{dateTimePickerReader.Value.ToString("yyyy-MM-dd")}', '{textBoxOrganizationReader.Text}') ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }

            RefreshReaderData(GetReaders());
        }

        private void buttonUpdateReader_Click(object sender, EventArgs e)
        {
            if (dataGridViewReader.SelectedCells.Count == 0)
                return;

            int rowIndex = dataGridViewReader.SelectedCells[0].RowIndex;
            Reader reader = dataGridViewReader.Rows[rowIndex].DataBoundItem as Reader;

            List<string> setters = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxNameReader.Text) == false)
                setters.Add($"r.name = '{textBoxNameReader.Text}'");

            if (dateTimePickerReader.Value.ToString("yyyy-MM-dd") != reader.Birthday.ToString("yyyy-MM-dd"))
                setters.Add($"r.birthday = '{dateTimePickerReader.Value.ToString("yyyy-MM-dd")}'");

            if (string.IsNullOrWhiteSpace(textBoxOrganizationReader.Text) == false)
                setters.Add($"r.organization = '{textBoxOrganizationReader.Text}'");

            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;

            if (setters.Count > 0)
            {
                command.CommandText += "UPDATE reader r " +
                    $"SET {string.Join(", ", setters)} " +
                    $"WHERE r.id = {reader.Id};";
            }

            _connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            _connection.Close();

            RefreshReaderData(GetReaders());
        }

        private void buttonAddSubscription_Click(object sender, EventArgs e)
        {
            _connection.Open();

            MySqlCommand command = new MySqlCommand();
            command.Connection = _connection;
            command.CommandText = string.Empty;

            if (comboBoxReaderSubscription.SelectedIndex == -1 || comboBoxBookSubscription.SelectedIndex == -1)
            {

            }
            else if (comboBoxReaderSubscription.DropDownStyle == ComboBoxStyle.DropDown && string.IsNullOrWhiteSpace(comboBoxReaderSubscription.Text) == false || comboBoxBookSubscription.DropDownStyle == ComboBoxStyle.DropDown && string.IsNullOrWhiteSpace(comboBoxBookSubscription.Text) == false)
            {
                command.CommandText += $"INSERT subscription (reader_id, book_id, taking_date, bringing_date, is_return) VALUE({(comboBoxReaderSubscription.SelectedItem as Reader).Id}, {(comboBoxBookSubscription.SelectedItem as Book).Id}, '{dateTimePickerTakeSubscription.Value.ToString("yyyy-MM-dd")}', '{dateTimePickerBringSubscription.Value.ToString("yyyy-MM-dd")}', {false}) ";
            }
            else
            {
                return;
            }

            command.CommandText = "INSERT subscription(reader_id, book_id, taking_date, bring_date, is_return) " +
                $"VALUES({(comboBoxReaderSubscription.SelectedItem as Reader).Id}, " +
                $"{(comboBoxBookSubscription.SelectedItem as Book).Id}," +
                $" '{dateTimePickerTakeSubscription.Value.ToString("yyyy-MM-dd")}', " +
                $"'{dateTimePickerBringSubscription.Value.ToString("yyyy-MM-dd")}', " +
                $"{false}); ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }

            RefreshSubscriptionData(GetSubscriptions());
        }

        private void buttonUpdateSubscription_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubscription.SelectedCells.Count == 0)
                return;

            int rowIndex = dataGridViewSubscription.SelectedCells[0].RowIndex;
            Subscription subscription = dataGridViewSubscription.Rows[rowIndex].DataBoundItem as Subscription;

            List<string> setters = new List<string>();

            if (comboBoxReaderSubscription.SelectedIndex != -1)
                setters.Add($"s.reader_id = {(comboBoxReaderSubscription.SelectedItem as Reader).Id}");

            if (comboBoxBookSubscription.SelectedIndex != -1)
                setters.Add($"s.book_id = {(comboBoxBookSubscription.SelectedItem as Book).Id}");

            if (dateTimePickerTakeSubscription.Value.ToString("yyyy-MM-dd") != subscription.TakingDate.ToString("yyyy-MM-dd"))
                setters.Add($"s.taking_date = '{dateTimePickerTakeSubscription.Value.ToString("yyyy-MM-dd")}'");

            if (dateTimePickerBringSubscription.Value.ToString("yyyy-MM-dd") != subscription.BringDate.ToString("yyyy-MM-dd"))
                setters.Add($"s.bring_date = '{dateTimePickerBringSubscription.Value.ToString("yyyy-MM-dd")}'");

            setters.Add($"s.is_return = {false}");

            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;

            if (setters.Count > 0)
            {
                command.CommandText += "UPDATE subscription s " +
                    $"SET {string.Join(", ", setters)} " +
                    $"WHERE s.id = {subscription.Id};";
            }

            _connection.Open();

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

            _connection.Close();

            RefreshSubscriptionData(GetSubscriptions());
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridView grid = (((sender as ToolStripItem).Owner as ContextMenuStrip).SourceControl as DataGridView);

            if (grid?.SelectedCells.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;

                switch (grid.Rows[rowIndex].DataBoundItem)
                {
                    case Book book:
                        DeleteBook(book);
                        break;
                    case Reader reader:
                        DeleteReader(reader);
                        break;
                    case Subscription subscription:
                        DeleteSubscription(subscription);
                        break;
                }
            }
        }

        private void DeleteBook(Book book)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;

            _connection.Open();

            command.CommandText += "DELETE FROM book_count " +
                $"WHERE book_id = {book.Id}; ";

            command.CommandText += "DELETE FROM book " +
                $"WHERE id = {book.Id}; ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void DeleteReader(Reader reader)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;

            _connection.Open();

            command.CommandText += "DELETE FROM reader " +
                $"WHERE id = {reader.Id} ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void DeleteSubscription(Subscription subscription)
        {
            MySqlCommand command = new MySqlCommand();
            command.CommandText = string.Empty;
            command.Connection = _connection;

            _connection.Open();

            command.CommandText += "DELETE FROM subscription " +
                $"WHERE id = {subscription.Id} ";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
            finally
            {
                _connection.Close();
            }
        }
    }
}
