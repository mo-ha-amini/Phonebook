namespace Phonebook
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_firstname = new TextBox();
            txt_lastname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_phoneNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            grd_contacts = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)grd_contacts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "First name";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(79, 12);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(140, 23);
            txt_firstname.TabIndex = 1;
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(289, 12);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(145, 23);
            txt_lastname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 15);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Last name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 15);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 4;
            label3.Text = "Phone Number";
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.Location = new Point(534, 12);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(145, 23);
            txt_phoneNumber.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(15, 57);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 6;
            button1.Text = "Save Contact";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 57);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // grd_contacts
            // 
            grd_contacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grd_contacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grd_contacts.Columns.AddRange(new DataGridViewColumn[] { Id, FirstName, LastName, PhoneNumber });
            grd_contacts.Location = new Point(15, 86);
            grd_contacts.Name = "grd_contacts";
            grd_contacts.Size = new Size(773, 352);
            grd_contacts.TabIndex = 8;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "First Name";
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.HeaderText = "Last Name";
            LastName.Name = "LastName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "PhoneNumber";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grd_contacts);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_phoneNumber);
            Controls.Add(label3);
            Controls.Add(txt_lastname);
            Controls.Add(label2);
            Controls.Add(txt_firstname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grd_contacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private Label label2;
        private Label label3;
        private TextBox txt_phoneNumber;
        private Button button1;
        private Button button2;
        private DataGridView grd_contacts;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
    }
}
