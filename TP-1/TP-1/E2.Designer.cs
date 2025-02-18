namespace TP_1
{
    partial class E2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            post = new Button();
            txtSurname = new TextBox();
            txtName = new TextBox();
            delete = new Button();
            fullNameList = new ListBox();
            SuspendLayout();
            // 
            // post
            // 
            post.Location = new Point(56, 170);
            post.Name = "post";
            post.Size = new Size(141, 27);
            post.TabIndex = 0;
            post.Text = "Agregar";
            post.UseVisualStyleBackColor = true;
            post.Click += button1_Click;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(56, 126);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "Apellido";
            txtSurname.Size = new Size(226, 23);
            txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 85);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Nombre";
            txtName.Size = new Size(226, 23);
            txtName.TabIndex = 2;
            // 
            // delete
            // 
            delete.Location = new Point(408, 348);
            delete.Name = "delete";
            delete.Size = new Size(120, 37);
            delete.TabIndex = 3;
            delete.Text = "Borrar";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // fullNameList
            // 
            fullNameList.FormattingEnabled = true;
            fullNameList.ItemHeight = 15;
            fullNameList.Location = new Point(377, 34);
            fullNameList.Name = "fullNameList";
            fullNameList.Size = new Size(179, 289);
            fullNameList.TabIndex = 4;
            // 
            // E2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(fullNameList);
            Controls.Add(delete);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(post);
            Name = "E2";
            Text = "E2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button post;
        private TextBox txtSurname;
        private TextBox txtName;
        private Button delete;
        private ListBox fullNameList;
    }
}