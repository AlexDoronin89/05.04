namespace MySQLLesson2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.buttonFieldClearBook = new System.Windows.Forms.Button();
            this.numericUpDownBookCount = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownPageCountBook = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonSelectBook = new System.Windows.Forms.Button();
            this.buttonBookNewAuthor = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBook = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBookAuthor = new System.Windows.Forms.ComboBox();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.buttonFieldClearReader = new System.Windows.Forms.Button();
            this.buttonUpdateReader = new System.Windows.Forms.Button();
            this.buttonSelectReader = new System.Windows.Forms.Button();
            this.buttonAddReader = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerReader = new System.Windows.Forms.DateTimePicker();
            this.textBoxOrganizationReader = new System.Windows.Forms.TextBox();
            this.textBoxNameReader = new System.Windows.Forms.TextBox();
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.tabPageSubscription = new System.Windows.Forms.TabPage();
            this.buttonFieldClearSubscription = new System.Windows.Forms.Button();
            this.buttonSelectSubscription = new System.Windows.Forms.Button();
            this.buttonUpdateSubscription = new System.Windows.Forms.Button();
            this.buttonAddSubscription = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIsReturn = new System.Windows.Forms.CheckBox();
            this.dateTimePickerBringSubscription = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTakeSubscription = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBookSubscription = new System.Windows.Forms.ComboBox();
            this.comboBoxReaderSubscription = new System.Windows.Forms.ComboBox();
            this.dataGridViewSubscription = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCountBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            this.tabPageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            this.tabPageSubscription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageBook);
            this.tabControl.Controls.Add(this.tabPageClient);
            this.tabControl.Controls.Add(this.tabPageSubscription);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1026, 567);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.buttonFieldClearBook);
            this.tabPageBook.Controls.Add(this.numericUpDownBookCount);
            this.tabPageBook.Controls.Add(this.label12);
            this.tabPageBook.Controls.Add(this.numericUpDownPageCountBook);
            this.tabPageBook.Controls.Add(this.buttonUpdateBook);
            this.tabPageBook.Controls.Add(this.buttonSelectBook);
            this.tabPageBook.Controls.Add(this.buttonBookNewAuthor);
            this.tabPageBook.Controls.Add(this.buttonAddBook);
            this.tabPageBook.Controls.Add(this.label4);
            this.tabPageBook.Controls.Add(this.label3);
            this.tabPageBook.Controls.Add(this.label2);
            this.tabPageBook.Controls.Add(this.dateTimePickerBook);
            this.tabPageBook.Controls.Add(this.comboBoxBookAuthor);
            this.tabPageBook.Controls.Add(this.textBoxBookTitle);
            this.tabPageBook.Controls.Add(this.label1);
            this.tabPageBook.Controls.Add(this.dataGridViewBook);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1018, 541);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Книги";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // buttonFieldClearBook
            // 
            this.buttonFieldClearBook.Location = new System.Drawing.Point(6, 311);
            this.buttonFieldClearBook.Name = "buttonFieldClearBook";
            this.buttonFieldClearBook.Size = new System.Drawing.Size(150, 30);
            this.buttonFieldClearBook.TabIndex = 16;
            this.buttonFieldClearBook.Text = "Очистиь";
            this.buttonFieldClearBook.UseVisualStyleBackColor = true;
            this.buttonFieldClearBook.Click += new System.EventHandler(this.buttonFieldClearBook_Click);
            // 
            // numericUpDownBookCount
            // 
            this.numericUpDownBookCount.Location = new System.Drawing.Point(6, 178);
            this.numericUpDownBookCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownBookCount.Name = "numericUpDownBookCount";
            this.numericUpDownBookCount.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownBookCount.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Кол-во:";
            // 
            // numericUpDownPageCountBook
            // 
            this.numericUpDownPageCountBook.Location = new System.Drawing.Point(6, 103);
            this.numericUpDownPageCountBook.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPageCountBook.Name = "numericUpDownPageCountBook";
            this.numericUpDownPageCountBook.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownPageCountBook.TabIndex = 13;
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(6, 239);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateBook.TabIndex = 12;
            this.buttonUpdateBook.Text = "Обновить";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // buttonSelectBook
            // 
            this.buttonSelectBook.Location = new System.Drawing.Point(6, 275);
            this.buttonSelectBook.Name = "buttonSelectBook";
            this.buttonSelectBook.Size = new System.Drawing.Size(150, 30);
            this.buttonSelectBook.TabIndex = 11;
            this.buttonSelectBook.Text = "Получить";
            this.buttonSelectBook.UseVisualStyleBackColor = true;
            this.buttonSelectBook.Click += new System.EventHandler(this.buttonSelectBook_Click);
            // 
            // buttonBookNewAuthor
            // 
            this.buttonBookNewAuthor.Location = new System.Drawing.Point(122, 62);
            this.buttonBookNewAuthor.Name = "buttonBookNewAuthor";
            this.buttonBookNewAuthor.Size = new System.Drawing.Size(35, 21);
            this.buttonBookNewAuthor.TabIndex = 10;
            this.buttonBookNewAuthor.Text = "+";
            this.buttonBookNewAuthor.UseVisualStyleBackColor = true;
            this.buttonBookNewAuthor.Click += new System.EventHandler(this.buttonBookNewAuthor_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(6, 203);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(150, 30);
            this.buttonAddBook.TabIndex = 9;
            this.buttonAddBook.Text = "Добавить";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Страниц:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Автор:";
            // 
            // dateTimePickerBook
            // 
            this.dateTimePickerBook.Location = new System.Drawing.Point(6, 142);
            this.dateTimePickerBook.Name = "dateTimePickerBook";
            this.dateTimePickerBook.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerBook.TabIndex = 5;
            // 
            // comboBoxBookAuthor
            // 
            this.comboBoxBookAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookAuthor.FormattingEnabled = true;
            this.comboBoxBookAuthor.Location = new System.Drawing.Point(6, 63);
            this.comboBoxBookAuthor.Name = "comboBoxBookAuthor";
            this.comboBoxBookAuthor.Size = new System.Drawing.Size(110, 21);
            this.comboBoxBookAuthor.TabIndex = 3;
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(6, 24);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(150, 20);
            this.textBoxBookTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewBook.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewBook.Location = new System.Drawing.Point(163, 3);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.Size = new System.Drawing.Size(852, 535);
            this.dataGridViewBook.TabIndex = 0;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.buttonFieldClearReader);
            this.tabPageClient.Controls.Add(this.buttonUpdateReader);
            this.tabPageClient.Controls.Add(this.buttonSelectReader);
            this.tabPageClient.Controls.Add(this.buttonAddReader);
            this.tabPageClient.Controls.Add(this.label7);
            this.tabPageClient.Controls.Add(this.label6);
            this.tabPageClient.Controls.Add(this.label5);
            this.tabPageClient.Controls.Add(this.dateTimePickerReader);
            this.tabPageClient.Controls.Add(this.textBoxOrganizationReader);
            this.tabPageClient.Controls.Add(this.textBoxNameReader);
            this.tabPageClient.Controls.Add(this.dataGridViewReader);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1018, 541);
            this.tabPageClient.TabIndex = 1;
            this.tabPageClient.Text = "Посетители";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // buttonFieldClearReader
            // 
            this.buttonFieldClearReader.Location = new System.Drawing.Point(11, 231);
            this.buttonFieldClearReader.Name = "buttonFieldClearReader";
            this.buttonFieldClearReader.Size = new System.Drawing.Size(150, 30);
            this.buttonFieldClearReader.TabIndex = 10;
            this.buttonFieldClearReader.Text = "Очистить";
            this.buttonFieldClearReader.UseVisualStyleBackColor = true;
            this.buttonFieldClearReader.Click += new System.EventHandler(this.buttonFieldClearReader_Click);
            // 
            // buttonUpdateReader
            // 
            this.buttonUpdateReader.Location = new System.Drawing.Point(11, 159);
            this.buttonUpdateReader.Name = "buttonUpdateReader";
            this.buttonUpdateReader.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateReader.TabIndex = 9;
            this.buttonUpdateReader.Text = "Обновить";
            this.buttonUpdateReader.UseVisualStyleBackColor = true;
            this.buttonUpdateReader.Click += new System.EventHandler(this.buttonUpdateReader_Click);
            // 
            // buttonSelectReader
            // 
            this.buttonSelectReader.Location = new System.Drawing.Point(11, 195);
            this.buttonSelectReader.Name = "buttonSelectReader";
            this.buttonSelectReader.Size = new System.Drawing.Size(150, 30);
            this.buttonSelectReader.TabIndex = 8;
            this.buttonSelectReader.Text = "Получить";
            this.buttonSelectReader.UseVisualStyleBackColor = true;
            this.buttonSelectReader.Click += new System.EventHandler(this.buttonSelectReader_Click);
            // 
            // buttonAddReader
            // 
            this.buttonAddReader.Location = new System.Drawing.Point(11, 123);
            this.buttonAddReader.Name = "buttonAddReader";
            this.buttonAddReader.Size = new System.Drawing.Size(150, 30);
            this.buttonAddReader.TabIndex = 7;
            this.buttonAddReader.Text = "Добавить";
            this.buttonAddReader.UseVisualStyleBackColor = true;
            this.buttonAddReader.Click += new System.EventHandler(this.buttonAddReader_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Организация:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя:";
            // 
            // dateTimePickerReader
            // 
            this.dateTimePickerReader.Location = new System.Drawing.Point(11, 97);
            this.dateTimePickerReader.Name = "dateTimePickerReader";
            this.dateTimePickerReader.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerReader.TabIndex = 3;
            // 
            // textBoxOrganizationReader
            // 
            this.textBoxOrganizationReader.Location = new System.Drawing.Point(11, 58);
            this.textBoxOrganizationReader.Name = "textBoxOrganizationReader";
            this.textBoxOrganizationReader.Size = new System.Drawing.Size(150, 20);
            this.textBoxOrganizationReader.TabIndex = 2;
            // 
            // textBoxNameReader
            // 
            this.textBoxNameReader.Location = new System.Drawing.Point(11, 19);
            this.textBoxNameReader.Name = "textBoxNameReader";
            this.textBoxNameReader.Size = new System.Drawing.Size(150, 20);
            this.textBoxNameReader.TabIndex = 1;
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewReader.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewReader.Location = new System.Drawing.Point(167, 3);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.Size = new System.Drawing.Size(848, 535);
            this.dataGridViewReader.TabIndex = 0;
            // 
            // tabPageSubscription
            // 
            this.tabPageSubscription.Controls.Add(this.buttonFieldClearSubscription);
            this.tabPageSubscription.Controls.Add(this.buttonSelectSubscription);
            this.tabPageSubscription.Controls.Add(this.buttonUpdateSubscription);
            this.tabPageSubscription.Controls.Add(this.buttonAddSubscription);
            this.tabPageSubscription.Controls.Add(this.label11);
            this.tabPageSubscription.Controls.Add(this.label10);
            this.tabPageSubscription.Controls.Add(this.label9);
            this.tabPageSubscription.Controls.Add(this.label8);
            this.tabPageSubscription.Controls.Add(this.checkBoxIsReturn);
            this.tabPageSubscription.Controls.Add(this.dateTimePickerBringSubscription);
            this.tabPageSubscription.Controls.Add(this.dateTimePickerTakeSubscription);
            this.tabPageSubscription.Controls.Add(this.comboBoxBookSubscription);
            this.tabPageSubscription.Controls.Add(this.comboBoxReaderSubscription);
            this.tabPageSubscription.Controls.Add(this.dataGridViewSubscription);
            this.tabPageSubscription.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubscription.Name = "tabPageSubscription";
            this.tabPageSubscription.Size = new System.Drawing.Size(1018, 541);
            this.tabPageSubscription.TabIndex = 2;
            this.tabPageSubscription.Text = "Абонименты";
            this.tabPageSubscription.UseVisualStyleBackColor = true;
            // 
            // buttonFieldClearSubscription
            // 
            this.buttonFieldClearSubscription.Location = new System.Drawing.Point(6, 292);
            this.buttonFieldClearSubscription.Name = "buttonFieldClearSubscription";
            this.buttonFieldClearSubscription.Size = new System.Drawing.Size(150, 30);
            this.buttonFieldClearSubscription.TabIndex = 13;
            this.buttonFieldClearSubscription.Text = "Очистить";
            this.buttonFieldClearSubscription.UseVisualStyleBackColor = true;
            this.buttonFieldClearSubscription.Click += new System.EventHandler(this.buttonFieldClearSubscription_Click);
            // 
            // buttonSelectSubscription
            // 
            this.buttonSelectSubscription.Location = new System.Drawing.Point(6, 256);
            this.buttonSelectSubscription.Name = "buttonSelectSubscription";
            this.buttonSelectSubscription.Size = new System.Drawing.Size(150, 30);
            this.buttonSelectSubscription.TabIndex = 12;
            this.buttonSelectSubscription.Text = "Получить";
            this.buttonSelectSubscription.UseVisualStyleBackColor = true;
            this.buttonSelectSubscription.Click += new System.EventHandler(this.buttonSelectSubscription_Click);
            // 
            // buttonUpdateSubscription
            // 
            this.buttonUpdateSubscription.Location = new System.Drawing.Point(6, 220);
            this.buttonUpdateSubscription.Name = "buttonUpdateSubscription";
            this.buttonUpdateSubscription.Size = new System.Drawing.Size(150, 30);
            this.buttonUpdateSubscription.TabIndex = 11;
            this.buttonUpdateSubscription.Text = "Обновить";
            this.buttonUpdateSubscription.UseVisualStyleBackColor = true;
            this.buttonUpdateSubscription.Click += new System.EventHandler(this.buttonUpdateSubscription_Click);
            // 
            // buttonAddSubscription
            // 
            this.buttonAddSubscription.Location = new System.Drawing.Point(6, 184);
            this.buttonAddSubscription.Name = "buttonAddSubscription";
            this.buttonAddSubscription.Size = new System.Drawing.Size(150, 30);
            this.buttonAddSubscription.TabIndex = 10;
            this.buttonAddSubscription.Text = "Добавить";
            this.buttonAddSubscription.UseVisualStyleBackColor = true;
            this.buttonAddSubscription.Click += new System.EventHandler(this.buttonAddSubscription_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Дата возвращения:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Дата взятия:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Книга:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Посетитель:";
            // 
            // checkBoxIsReturn
            // 
            this.checkBoxIsReturn.AutoSize = true;
            this.checkBoxIsReturn.Location = new System.Drawing.Point(6, 161);
            this.checkBoxIsReturn.Name = "checkBoxIsReturn";
            this.checkBoxIsReturn.Size = new System.Drawing.Size(143, 17);
            this.checkBoxIsReturn.TabIndex = 5;
            this.checkBoxIsReturn.Text = "Возвращена ли книга?";
            this.checkBoxIsReturn.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBringSubscription
            // 
            this.dateTimePickerBringSubscription.Location = new System.Drawing.Point(6, 135);
            this.dateTimePickerBringSubscription.Name = "dateTimePickerBringSubscription";
            this.dateTimePickerBringSubscription.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerBringSubscription.TabIndex = 4;
            // 
            // dateTimePickerTakeSubscription
            // 
            this.dateTimePickerTakeSubscription.Location = new System.Drawing.Point(6, 96);
            this.dateTimePickerTakeSubscription.Name = "dateTimePickerTakeSubscription";
            this.dateTimePickerTakeSubscription.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerTakeSubscription.TabIndex = 3;
            // 
            // comboBoxBookSubscription
            // 
            this.comboBoxBookSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBookSubscription.FormattingEnabled = true;
            this.comboBoxBookSubscription.Location = new System.Drawing.Point(6, 56);
            this.comboBoxBookSubscription.Name = "comboBoxBookSubscription";
            this.comboBoxBookSubscription.Size = new System.Drawing.Size(151, 21);
            this.comboBoxBookSubscription.TabIndex = 2;
            // 
            // comboBoxReaderSubscription
            // 
            this.comboBoxReaderSubscription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReaderSubscription.FormattingEnabled = true;
            this.comboBoxReaderSubscription.Location = new System.Drawing.Point(6, 16);
            this.comboBoxReaderSubscription.Name = "comboBoxReaderSubscription";
            this.comboBoxReaderSubscription.Size = new System.Drawing.Size(150, 21);
            this.comboBoxReaderSubscription.TabIndex = 1;
            // 
            // dataGridViewSubscription
            // 
            this.dataGridViewSubscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubscription.ContextMenuStrip = this.contextMenuStrip;
            this.dataGridViewSubscription.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewSubscription.Location = new System.Drawing.Point(163, 0);
            this.dataGridViewSubscription.Name = "dataGridViewSubscription";
            this.dataGridViewSubscription.Size = new System.Drawing.Size(855, 541);
            this.dataGridViewSubscription.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 567);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.tabPageBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCountBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            this.tabPageClient.ResumeLayout(false);
            this.tabPageClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            this.tabPageSubscription.ResumeLayout(false);
            this.tabPageSubscription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubscription)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.TabPage tabPageSubscription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerBook;
        private System.Windows.Forms.ComboBox comboBoxBookAuthor;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectBook;
        private System.Windows.Forms.Button buttonBookNewAuthor;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.DataGridView dataGridViewReader;
        private System.Windows.Forms.DateTimePicker dateTimePickerReader;
        private System.Windows.Forms.TextBox textBoxOrganizationReader;
        private System.Windows.Forms.TextBox textBoxNameReader;
        private System.Windows.Forms.Button buttonUpdateReader;
        private System.Windows.Forms.Button buttonSelectReader;
        private System.Windows.Forms.Button buttonAddReader;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewSubscription;
        private System.Windows.Forms.ComboBox comboBoxBookSubscription;
        private System.Windows.Forms.ComboBox comboBoxReaderSubscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerBringSubscription;
        private System.Windows.Forms.DateTimePicker dateTimePickerTakeSubscription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkBoxIsReturn;
        private System.Windows.Forms.Button buttonSelectSubscription;
        private System.Windows.Forms.Button buttonUpdateSubscription;
        private System.Windows.Forms.Button buttonAddSubscription;
        private System.Windows.Forms.NumericUpDown numericUpDownPageCountBook;
        private System.Windows.Forms.NumericUpDown numericUpDownBookCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonFieldClearBook;
        private System.Windows.Forms.Button buttonFieldClearReader;
        private System.Windows.Forms.Button buttonFieldClearSubscription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

